using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookWise_AutoMart
{
    public partial class UserPanel : Form
    {
        public static int id;
        public static string user;

        public static string categoryName;
        private UserDisplayItemsPanel UserDisplayItemsPanel;
        public static Panel pnl;
        public static Label total;
        public static TextBox Qty;
        public static Checkout checkoutForm;

        private string connectionString = DatabaseString.GetUserDatabase();

        public UserPanel(int userId, string userType)
        {
            InitializeComponent();

            id = userId;
            user = userType;

            lblUserGreet.Text = $"Hi, {GetUsername(id)}";

            DisplayCategories();
            total = lblAmount;
            pnl = pnlCart;
            checkoutForm = new Checkout();
        }

        private string GetUsername(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "";

                if (user == "Customer")
                {
                    query = "SELECT name FROM Users WHERE user_id = @UserId";
                }
                else
                {
                    query = "SELECT guest_name FROM Guests WHERE guest_id = @UserId";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@UserId", id);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();
                        }
                    }
                    catch (Exception)
                    {
                        // error
                    }
                }
            }

            return "User";
        }

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
            catch (Exception)
            {
                // Error
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

        private void butPay_Click(object sender, EventArgs e)
        {
            bool hasTable = false;
             foreach(Control control in pnlCart.Controls)
             {
                 if(control is TableLayoutPanel)
                 {
                     hasTable = true;
                     break;
                 }
             }
             if(hasTable)
             {
                 checkoutForm.BillValue = lblAmount.Text;
                 checkoutForm.Show();
                 this.Hide();
             }

            /*if(pnl.Controls.Count != 0)
            {
                checkoutForm.BillValue = this.lblAmount.Text;
                checkoutForm.Show();
                this.Hide();
            }*/
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //return items in cart
            foreach(Control control in pnlCart.Controls)
            {
                if(control is TableLayoutPanel tbl)
                {
                    if (tbl.Controls[1] is Label lblItemName)
                    {
                        UpdateTempStock(lblItemName.Text);
                    }
                }
            }

            bool userLoginFound = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form is UserLogin)
                {
                    userLoginFound = true;
                    form.Show();
                    break;
                }
            }
            if (!userLoginFound)
            {
                UserLogin userLogin = new UserLogin();
                userLogin.Show();
            }

            checkoutForm.Close();
            this.Close();
        }

        private void UpdateTempStock(string itemName)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Items SET temporary_stock = @Stock WHERE item_name = @ItemName";

                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Stock",GetItemStock(itemName));
                        cmd.Parameters.AddWithValue("@ItemName", itemName.Trim());
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception)
                    {
                        //-------Error------------
                    }
                }
            }
        }

        private int GetItemStock(string itemName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT stock FROM Items WHERE item_name = @ItemName";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ItemName", itemName.Trim());
                        connection.Open();
                        object result = cmd.ExecuteScalar();

                        if(result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                    catch (Exception)
                    {
                        //-------Error------------
                    }
                }
            }
            return -1;
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            CategoriesButton lastButton = null;    //Actually getting the first button
            foreach (Control control in pnlCategoryScroll.Controls)
            {
                if (control is CategoriesButton btn)
                {
                    lastButton = btn;
                }
            }

            if (lastButton != null)
            {
                lastButton.PerformClick();
            }
        }
    }
}
