using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class UserDisplayItemsPanel : UserControl
    {
        private string categoryName ;
        string searchedItem;
        string selectedCategory;

        private string connectionString = DatabaseString.GetUserDatabase();

        public UserDisplayItemsPanel(string category)
        {
            categoryName = category;
            InitializeComponent();
            PopulateSubCategoriesComboBox();
            Placeholder(txtItemName, "Enter item name...");
            
        }

        private void displayItem_load(object sender, EventArgs e)
        {
            Items();
            lblCategoryName.Text = UserPanel.categoryName;
        }

        private void Items(string filterOption = null, string searchedItemName = null)
        {
            //clear existing items from flowlayoutPanelDisplayItems
            flpItemCardsContainer.Controls.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    /*string query = @"SELECT Items.* ,
                             (SELECT TOP 1 discount_percentage FROM Offers WHERE applicable_items LIKE '%' + CAST(Items.item_id AS  VARCHAR) + '%') AS item_discount_percentage 
                             FROM Items 
                             INNER JOIN Categories ON Items.item_category_id = Categories.category_id 
                             WHERE Categories.category_name = @CategoryName";*/

                    string query = "";

                    // not filtered item and not searched item (filterOption == null && searchedItemName == null)
                    if (string.IsNullOrEmpty(filterOption) && string.IsNullOrEmpty(searchedItemName))
                    {
                        query = @"SELECT Items.*
                              FROM Items
                              INNER JOIN Categories ON Items.item_category_id = Categories.category_id
                              WHERE Categories.category_name = @CategoryName";
                    }

                    // filtered item but not searched item (filterOption != null && searchedItemName == null)
                    else if (!string.IsNullOrEmpty(filterOption) && string.IsNullOrEmpty(searchedItemName))
                    {
                        query = @"SELECT Items.* 
                              FROM Items
                              INNER JOIN SubCategories ON Items.item_subcategory_id = SubCategories.subcategory_id
                              WHERE SubCategories.subcategory_name = @FilterOption";
                    }

                    // not filtered item but searched item (filterOption == null && searchedItemName != null)
                    else if (string.IsNullOrEmpty(filterOption) && !string.IsNullOrEmpty(searchedItemName))
                    {
                        query = @"SELECT Items.* 
                              FROM Items
                              INNER JOIN Categories ON Items.item_category_id = Categories.category_id
                              INNER JOIN SubCategories ON Items.item_subcategory_id = SubCategories.subcategory_id
                              WHERE (Items.item_name LIKE @ItemName OR Categories.category_name = @ItemName) AND Categories.category_name = @CategoryName";
                    }

                    // filtered item and searched item (filterOption != null && searchedItemName != null)
                    else if (!string.IsNullOrEmpty(filterOption) && !string.IsNullOrEmpty(searchedItemName))
                    {
                        query = @"SELECT Items.*
                              FROM Items
                              INNER JOIN Categories ON Items.item_category_id = Categories.category_id
                              INNER JOIN SubCategories ON Items.item_subcategory_id = SubCategories.subcategory_id
                              WHERE SubCategories.subcategory_name = @FilterOption AND (Items.item_name LIKE @ItemName OR Categories.category_name LIKE @ItemName)";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            // not filtered item and not searched item (filterOption == null && searchedItemName == null)
                            if (string.IsNullOrEmpty(filterOption) && string.IsNullOrEmpty(searchedItemName))
                            {
                                command.Parameters.AddWithValue("@CategoryName", $"{categoryName}");
                            }

                            // filtered item but not searched item (filterOption != null && searchedItemName == null)
                            else if (!string.IsNullOrEmpty(filterOption) && string.IsNullOrEmpty(searchedItemName))
                            {
                                command.Parameters.AddWithValue("@FilterOption", $"{filterOption}");
                            }

                            // not filtered item but searched item (filterOption == null && searchedItemName != null)
                            else if (string.IsNullOrEmpty(filterOption) && !string.IsNullOrEmpty(searchedItemName))
                            {
                                command.Parameters.AddWithValue("@ItemName", $"%{searchedItemName}%");
                                command.Parameters.AddWithValue("@CategoryName", $"{categoryName}");
                            }

                            // filtered item and searched item (filterOption != null && searchedItemName != null)
                            else if (!string.IsNullOrEmpty(filterOption) && !string.IsNullOrEmpty(searchedItemName))
                            {
                                command.Parameters.AddWithValue("@FilterOption", $"{filterOption}");
                                command.Parameters.AddWithValue("@ItemName", $"%{searchedItemName}%");
                            }

                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        int itemId = (int)reader["item_id"];
                                        string itemName = reader["item_name"].ToString();
                                        string itemDescription = reader["item_description"].ToString();
                                        decimal price = (decimal)reader["price"];
                                        int stock = (int)reader["stock"];
                                        byte[] imageData = (byte[])reader["image"];
                                        int discount = GetItemDiscount(itemId);

                                        // Convert byte array to image
                                        Image image;
                                        using (MemoryStream ms = new MemoryStream(imageData))
                                        {
                                            image = Image.FromStream(ms);
                                        }

                                        ItemPanel newItem = new ItemPanel( itemName, itemDescription, price, image, discount);

                                        // Add item (panel) to FlowLayoutPanel
                                        flpItemCardsContainer.Controls.Add(newItem);
                                    }
                                }
                                else
                                {
                                    Label noItemsLabel = new Label();
                                    noItemsLabel.Text = "No items available.";
                                    noItemsLabel.ForeColor = Color.Black;
                                    noItemsLabel.Font = new Font("Segoe UI", 15);
                                    noItemsLabel.TextAlign = ContentAlignment.MiddleCenter;
                                    noItemsLabel.Padding = new Padding(12);
                                    noItemsLabel.AutoSize = true;
                                    flpItemCardsContainer.Controls.Add(noItemsLabel);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            // Error
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Error
            }
        }

        //Placeholder for item search textBox
        private void Placeholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = SystemColors.GrayText;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = SystemColors.GrayText;
                }
            };
        }

        private void PopulateSubCategoriesComboBox()
        {
            comboBoxFilterSubCategories.Items.Clear(); // Clear the items in the combo box

            comboBoxFilterSubCategories.Items.Add("All " + categoryName);  // Add "All items" option

            comboBoxFilterSubCategories.SelectedIndex = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT subcategory_name
                                 FROM SubCategories
                                 INNER JOIN Categories ON SubCategories.subcategory_category_id = Categories.category_id
                                 WHERE Categories.category_name = @CategoryName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@CategoryName", categoryName);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string subcategoryName = reader["subcategory_name"].ToString();
                                comboBoxFilterSubCategories.Items.Add(subcategoryName);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        // Error
                    }
                }
            }
        }

        private void FilteringConditionsApplied(object sender, EventArgs e)
        {
            searchedItem = txtItemName.Text.Trim();
            selectedCategory = comboBoxFilterSubCategories.SelectedItem?.ToString();
            //  If whatever before the '?' sign exists (is not empty), then do what comes after it. Otherwise, just stop and don't do anything.

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                if (selectedCategory.Equals("All " + categoryName))
                {
                    if (string.IsNullOrWhiteSpace(searchedItem) || searchedItem.Equals("Enter item name..."))
                    {
                        Items();
                    }
                    else
                    {
                        Items(filterOption: null, searchedItemName: searchedItem);
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(searchedItem) || searchedItem.Equals("Enter item name..."))
                    {
                        Items(filterOption: selectedCategory, searchedItemName: null);
                    }
                    else
                    {
                        Items(filterOption: selectedCategory, searchedItemName: searchedItem);
                    }
                }
            }
        }

        private int GetItemDiscount(int itemId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Offers WHERE is_active = @isactive";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@isactive", true);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string applicableItems = reader["applicable_items"].ToString();
                                    int discount = (int)reader["discount_percentage"];

                                    string[] items = applicableItems.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                                    foreach (string item in items)
                                    {
                                        if (itemId.ToString() == item.Trim())
                                        {
                                            return discount;
                                        }
                                    }
                                }
                                return -1;
                            }
                            else
                            {
                                return -1;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        //---------Error-----------
                        return -1;
                    }
                }
            }
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm();
            informationForm.Show();
        }
    }
}
