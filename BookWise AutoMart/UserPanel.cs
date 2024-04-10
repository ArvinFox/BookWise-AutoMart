using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class UserPanel : Form
    {
        public static int id;
        public static string category_Name;

        private UserDisplayItemsPanel UserDisplayItemsPanel;

        SqlConnection connectionString = new SqlConnection(DatabaseString.GetUserDatabase());


        public UserPanel()
        {
            InitializeComponent();
            UserDisplayItemsPanel = new UserDisplayItemsPanel();
            
            DisplayCategories();
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
        }*/
        private void HideMenu()
        {
            pnlCategoryScroll.Visible = false;
        }

        private void DisplayCategories()
        {
            try
            {
                string query = "SELECT category_name FROM Categories ORDER BY category_id DESC";
                using (SqlCommand cmd = new SqlCommand(query, connectionString))
                {
                    connectionString.Open();
                    using (SqlDataReader readCategories = cmd.ExecuteReader())
                    {
                        while (readCategories.Read())
                        {
                            string category = readCategories["category_name"].ToString();
                            CategoriesButton categoryButton = new CategoriesButton(category);
                            pnlCategoryScroll.Controls.Add(categoryButton);
                            categoryButton.Click += (sender, e) => 
                            { 
                                category_Name = categoryButton.Text;
                                SwitchUserControl(UserDisplayItemsPanel);
                            };
                        }
                    }
                    connectionString.Close();
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
            /* Button button = (Button)sender;
             string C_name = button.Text;
             category_Name = button.Text;

             try
             {
                 string query = $"SELECT * FROM Categories WHERE category_name = '{C_name}'";
                 SqlCommand cmd = new SqlCommand(query, connectionString);
                 connectionString.Open();
                 SqlDataReader reader = cmd.ExecuteReader();
                 if (reader.HasRows)
                 {
                     reader.Read();
                     id = Convert.ToInt32(reader["category_id"]);
                     SwitchUserControl(UserDisplayItemsPanel);
                 }
                 else
                 {
                     // Message for category is not found 
                     MessageBox.Show("Category not found.");
                 }
             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
           /* ShowMenu(pnlCategoryScroll);*/
        }
    }
}
