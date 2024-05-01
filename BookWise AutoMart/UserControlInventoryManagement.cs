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
    public partial class UserControlInventoryManagement : UserControl
    {
        private string selectedCategory;
        private string searchedItem;
        private string categoryName = "Books";

        private readonly string connectionString = DatabaseString.GetUserDatabase();

        public UserControlInventoryManagement()
        {
            InitializeComponent();

            // Subscribe to the ParentChanged event to update the size when the parent changes
            this.ParentChanged += UserControlInventoryManagement_ParentChanged;

            DisplayCategories();
            DisplayItems();
            PopulateCategoriesComboBox();
            Placeholder(txtSearchBar, "Enter item name...");
        }

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
        private void DisplayCategories()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Categories ORDER BY category_id DESC";
                // The data is fetched from the bottom to top (ORDER BY) because due to the 'Dock' property being set to 'Top', the last button added will be at the top (in the panel)

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        CategoriesButton lastCategoryButton = null; // To keep track of the last category added

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Iterate over the data
                            while (reader.Read())
                            {
                                // Create a new Button for each data row
                                int categoryId = (int)reader["category_id"];
                                string category = reader["category_name"].ToString();
                                CategoriesButton categoryButton = new CategoriesButton(categoryId, category, true);

                                // Add the button to the panel
                                pnlDisplayCategories.Controls.Add(categoryButton);

                                categoryButton.Click += (sender, e) =>
                                {
                                    categoryName = categoryButton.Text;
                                    PopulateCategoriesComboBox();
                                    Placeholder(txtSearchBar, "Enter item name...");
                                    DisplayItems();
                                };

                                // Update the reference to the last category button
                                lastCategoryButton = categoryButton;
                            }
                        }
                        // Trigger the click event for the last category button (which is also the first category in the database as it is fetched in reverse order)
                        if (lastCategoryButton != null)
                        {
                            lastCategoryButton.PerformClick();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void DisplayItems(string filterOption = null, string searchedItemName = null)
        {
            lblSelectedCategory.Text = " " + categoryName;

            // Clear existing items from flowLayoutPanelDisplayItems
            flowLayoutPanelDisplayItems.Controls.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
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

                                    // Convert byte array to image
                                    Image image;
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        image = Image.FromStream(ms);
                                    }

                                    DisplayItemsPanel newItem = new DisplayItemsPanel(itemId, itemName, itemDescription, price, stock, image);

                                    // Add item (panel) to FlowLayoutPanel
                                    flowLayoutPanelDisplayItems.Controls.Add(newItem);
                                }
                            }
                            else
                            {
                                Label noItemsLabel = new Label();
                                noItemsLabel.Text = "No items available.";
                                noItemsLabel.ForeColor = Color.LightGray;
                                noItemsLabel.Font = new Font("Gadugi", 15, FontStyle.Bold);
                                noItemsLabel.TextAlign = ContentAlignment.MiddleCenter;
                                noItemsLabel.Padding = new Padding(12);
                                noItemsLabel.AutoSize = true;

                                flowLayoutPanelDisplayItems.Controls.Add(noItemsLabel);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void PopulateCategoriesComboBox()
        {
            comboBoxFilterCategories.Items.Clear(); // Clear the items in the combo box

            comboBoxFilterCategories.Items.Add("All " + categoryName);  // Add "All items" option

            comboBoxFilterCategories.SelectedIndex = 0;

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
                                comboBoxFilterCategories.Items.Add(subcategoryName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FilteringConditionsApplied(object sender, EventArgs e)
        {
            searchedItem = txtSearchBar.Text.Trim();
            selectedCategory = comboBoxFilterCategories.SelectedItem?.ToString();
            //  If whatever before the '?' sign exists (is not empty), then do what comes after it. Otherwise, just stop and don't do anything.

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                if (selectedCategory.Equals("All " + categoryName))
                {
                    if (string.IsNullOrWhiteSpace(searchedItem) || searchedItem.Equals("Enter item name..."))
                    {
                        DisplayItems();
                    }
                    else
                    {
                        DisplayItems(filterOption: null, searchedItemName: searchedItem);
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(searchedItem) || searchedItem.Equals("Enter item name..."))
                    {
                        DisplayItems(filterOption: selectedCategory, searchedItemName: null);
                    }
                    else
                    {
                        DisplayItems(filterOption: selectedCategory, searchedItemName: searchedItem);
                    }
                }
            }
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            bool adminAddNewCategoryFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is AdminAddNewCategoryForm)
                {
                    form.ShowDialog();
                    adminAddNewCategoryFormFound = true;
                    break;
                }
            }

            if (!adminAddNewCategoryFormFound)
            {
                AdminAddNewCategoryForm adminAddNewCategoryForm = new AdminAddNewCategoryForm();
                adminAddNewCategoryForm.ShowDialog();
            }
        }
        private void btnAddNewCategory_MouseEnter(object sender, EventArgs e)
        {
            btnAddNewCategory.ForeColor = Color.White;
            btnAddNewCategory.Image = Properties.Resources.add_new_item__white_;
            btnAddNewCategory.FlatAppearance.BorderColor = Color.White;
        }
        private void btnAddNewCategory_MouseLeave(object sender, EventArgs e)
        {
            btnAddNewCategory.ForeColor = Color.DeepSkyBlue;
            btnAddNewCategory.Image = Properties.Resources.add_new_item__blue_;
            btnAddNewCategory.FlatAppearance.BorderColor = Color.DeepSkyBlue;
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            bool adminAddNewItemFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is AdminAddNewItemForm)
                {
                    form.ShowDialog();
                    adminAddNewItemFormFound = true;
                    break;
                }
            }

            if (!adminAddNewItemFormFound)
            {
                AdminAddNewItemForm adminAddNewItemForm = new AdminAddNewItemForm();
                adminAddNewItemForm.ShowDialog();
            }
        }
        private void btnAddNewItem_MouseEnter(object sender, EventArgs e)
        {
            btnAddNewItem.ForeColor = Color.White;
            btnAddNewItem.Image = Properties.Resources.add_new_item__white_;
            btnAddNewItem.FlatAppearance.BorderColor = Color.White;
        }
        private void btnAddNewItem_MouseLeave(object sender, EventArgs e)
        {
            btnAddNewItem.ForeColor = Color.Navy;
            btnAddNewItem.Image = Properties.Resources.add_new_item__navy_;
            btnAddNewItem.FlatAppearance.BorderColor = Color.Navy;
        }

        private void UserControlInventoryManagement_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                // To take the entire screen size
                this.Width = this.Parent.ClientSize.Width;
                this.Height = this.Parent.ClientSize.Height;
            }
        }
    }
}
