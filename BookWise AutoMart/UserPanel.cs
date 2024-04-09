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
    public partial class UserPanel : Form
    {
        public static int id;
        public static string category_Name;

        private UserDisplayItemsPanel UserDisplayItemsPanel;

        SqlConnection connectionString = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\123ma\\OneDrive\\Documents\\C#\\BookWise-AutoMart\\BookWise AutoMart\\BookWiseAutoMart.mdf\";Integrated Security=True");


        public UserPanel()
        {
            InitializeComponent();
            UserDisplayItemsPanel = new UserDisplayItemsPanel();
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

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
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
            }
        }
    }
}
