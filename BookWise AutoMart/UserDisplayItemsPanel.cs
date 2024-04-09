using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class UserDisplayItemsPanel : UserControl
    {

        SqlConnection connectionString = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\123ma\\OneDrive\\Documents\\C#\\BookWise-AutoMart\\BookWise AutoMart\\BookWiseAutoMart.mdf\";Integrated Security=True");

        public UserDisplayItemsPanel()
        {
            InitializeComponent();
        }

        private void displayItem_load(object sender, EventArgs e)
        {
            Items();
            lblCategoryName.Text = UserPanel.category_Name;
        }

        private void Items()
        {
            int item_id = UserPanel.id;
            string query = $"SELECT * FROM Items where item_category_id = {item_id}";

            using (SqlCommand cmd = new SqlCommand(query, connectionString))
            {
                try
                {
                    connectionString.Open();
                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        List<Item> items = new List<Item>();

                        while (datareader.Read())
                        {
                            Item item = new Item(Convert.ToInt32(datareader["item_id"])); 
                            // Create a new Item for each row
                            items.Add(item);
                        }
                        flpItemCardsContainer.Controls.Clear();
                        foreach (Item item in items)
                        {
                            flpItemCardsContainer.Controls.Add(item); // Add each item to the panel
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connectionString.Close();
                }
            }
        }

        
    }

}
