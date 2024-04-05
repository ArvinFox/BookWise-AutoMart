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
        private string categoryName = "Books";

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\BookWise AutoMart\\BookWise AutoMart\\BookWiseAutoMart.mdf\";Integrated Security=True";

        public UserControlInventoryManagement()
        {
            InitializeComponent();

            // Subscribe to the ParentChanged event to update the size when the parent changes
            this.ParentChanged += UserControlInventoryManagement_ParentChanged;

            DisplayCategories();
            DisplayItems();
        }

        private void DisplayCategories()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT category_name FROM Categories ORDER BY category_id DESC";
                    // The data is fetched from the bottom to top (ORDER BY) because due to the 'Dock' property being set to 'Top', the last button added will be at the top (in the panel)

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Iterate over the data
                            while (reader.Read())
                            {
                                // Create a new Button for each data row
                                string category = reader["category_name"].ToString();
                                CategoriesButton categoryButton = new CategoriesButton(category);

                                // Add the button to a container control (panel)
                                pnlDisplayCategories.Controls.Add(categoryButton);

                                categoryButton.Click += (sender, e) =>
                                {
                                    categoryName = categoryButton.Text;
                                    DisplayItems();
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }
        private void DisplayItems()
        {
            // Clear existing items from flowLayoutPanelDisplayItems
            flowLayoutPanelDisplayItems.Controls.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT Items.* 
                             FROM Items 
                             INNER JOIN Categories ON Items.item_category_id = Categories.category_id 
                             WHERE Categories.category_name = @CategoryName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryName", categoryName);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }

        private void btnAddNewCategory_MouseEnter(object sender, EventArgs e)
        {
            btnAddNewCategory.ForeColor = Color.White;
            btnAddNewCategory.Image = Properties.Resources.add_new_item__white_;
        }
        private void btnAddNewCategory_MouseLeave(object sender, EventArgs e)
        {
            btnAddNewCategory.ForeColor = Color.DeepSkyBlue;
            btnAddNewCategory.Image = Properties.Resources.add_new_item__blue_;
        }

        private void UserControlInventoryManagement_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Width = this.Parent.ClientSize.Width;
            }
        }
    }
}
