using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class UserPanel : Form
    {
        public static int id;
        public static string categoryName;
        private UserDisplayItemsPanel UserDisplayItemsPanel;
        public static DataGridView cart;
        public static Label total;
        public static TextBox Qty;
        private string connectionString = DatabaseString.GetUserDatabase();

        //SqlConnection connectionString = new SqlConnection(DatabaseString.GetUserDatabase());

        public UserPanel()
        {
            InitializeComponent();
            DisplayCategories();
            cart = dataGridViewCart;
            total = lblAmount;
        }

        /*private void ShowMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                HideMenu();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }
        private void HideMenu()
        {
            pnlCategoryScroll.Visible = false;
        }*/

        private void DisplayCategories()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Categories ORDER BY category_id DESC";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader readCategories = cmd.ExecuteReader())
                        {
                            while (readCategories.Read())
                            {
                                int categoryId = (int)readCategories["category_id"];
                                string category = readCategories["category_name"].ToString();
                                CategoriesButton categoryButton = new CategoriesButton(categoryId, category);
                                pnlCategoryScroll.Controls.Add(categoryButton);
                                categoryButton.Click += (sender, e) =>
                                {
                                    categoryName = categoryButton.Text;
                                    UserDisplayItemsPanel = new UserDisplayItemsPanel(categoryName);
                                    SwitchUserControl(UserDisplayItemsPanel);
                                };
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Add a user control to User display items panel
        private void AddUserControl(Control control)
        {
            control.Dock = DockStyle.Fill;
            panelItemDisplay.Controls.Add(control);
        }

        private void SwitchUserControl(Control newControl)
        {
            panelItemDisplay.Controls.Clear();
            AddUserControl(newControl);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            /* ShowMenu(pnlCategoryScroll);*/
        }

        private void butPay_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridViewCart.Rows)
            {
                int itemId = Convert.ToInt32(row.Cells["ColumnId"].Value);
                int quantity = Convert.ToInt32(row.Cells["ColumnQty"].Value);
                int itemStock = GetStock(itemId);
                UpdateStock(itemId, quantity,itemStock);
            }

        }

        private void UpdateStock(int itemId, int quantity,int itemStock)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Items SET stock = @Stock WHERE item_id = @ItemId";
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Stock", itemStock-quantity);
                        cmd.Parameters.AddWithValue("@ItemId", itemId);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        //---------Error-----------
                    }
                }
                 
            }
        }

        private int GetStock(int ItemId)
        {
            int stock = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Items WHERE item_id = @ItemId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@ItemId", ItemId);
                        connection.Open();
                        using(SqlDataReader stockReader = cmd.ExecuteReader())
                        {
                            stockReader.Read();
                            stock = (int)stockReader["stock"];
                            return stock;
                        }
                    }
                    catch(Exception)
                    {
                        //-------error---------
                    }
                }
            }
            return -1;
        }
        
        private void dataGridViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if the "Delete" column is clicked
            if (e.ColumnIndex == UserPanel.cart.Columns["ColumnDelete"].Index && e.RowIndex >= 0)
            {
                // get the corresponding row that the user clicked
                DataGridViewRow row = UserPanel.cart.Rows[e.RowIndex];

                // Remove the row from the cart
                UserPanel.cart.Rows.Remove(row);

                // Update total
                ItemPanel.UpdateTotal();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
