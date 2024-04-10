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
        private string categoryName;

        SqlConnection connectionString = new SqlConnection(DatabaseString.GetUserDatabase());

        public UserDisplayItemsPanel(string category)
        {
            InitializeComponent();
            categoryName = category;
        }

        private void displayItem_load(object sender, EventArgs e)
        {
            Items();
            lblCategoryName.Text = UserPanel.categoryName;
        }

        private void Items()
        {
            //clear existing items from flowlayoutPanelDisplayItems
            flpItemCardsContainer.Controls.Clear();

            try
            {
                using (connectionString)
                {
                    string query = @"SELECT Items.* ,
                             (SELECT TOP 1 discount_percentage FROM Offers WHERE applicable_items LIKE '%' + CAST(Items.item_id AS  VARCHAR) + '%') AS item_discount_percentage 
                             FROM Items 
                             INNER JOIN Categories ON Items.item_category_id = Categories.category_id 
                             WHERE Categories.category_name = @CategoryName";

                    using (SqlCommand command = new SqlCommand(query, connectionString))
                    {
                        command.Parameters.AddWithValue("@CategoryName", categoryName);

                        connectionString.Open();

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
                                int discount;

                                // Convert byte array to image
                                Image image;
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    image = Image.FromStream(ms);
                                }

                                //checking whether the discount is null
                                if (reader["item_discount_percentage"] is DBNull)
                                {
                                    discount = 0;
                                }
                                else
                                {
                                    discount = (int)reader["item_discount_percentage"];
                                }

                                ItemPanel newItem = new ItemPanel(itemId, itemName, itemDescription, price, stock, image, discount);

                                // Add item (panel) to FlowLayoutPanel
                                flpItemCardsContainer.Controls.Add(newItem);
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
    }

}
