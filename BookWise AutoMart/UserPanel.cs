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
        public static string categoryName;
        private UserDisplayItemsPanel UserDisplayItemsPanel;
        public static Panel pnl;
        public static Label total;
        public static TextBox Qty;
        public static Checkout checkoutForm;
        private string connectionString = DatabaseString.GetUserDatabase();

        //SqlConnection connectionString = new SqlConnection(DatabaseString.GetUserDatabase());

        public UserPanel()
        {
            InitializeComponent();
            DisplayCategories();
            total = lblAmount;
            pnl = pnlCart;
            checkoutForm = new Checkout();
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
                 checkoutForm.BillValue = this.lblAmount.Text;
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
            this.Close();
        }
    }
    
}
