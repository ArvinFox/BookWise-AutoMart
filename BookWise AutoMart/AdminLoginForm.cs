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
using BCrypt.Net;

namespace BookWise_AutoMart
{
    public partial class AdminLoginForm : Form
    {
        private string connectionString = DatabaseString.GetAdminDatabase();

        public AdminLoginForm()
        {
            InitializeComponent();

            Placeholder(txtAdminUsername, "Enter Username");
            Placeholder(txtAdminPassword, "Enter Password");
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string adminUsername = txtAdminUsername.Text;
            string adminPassword = txtAdminPassword.Text;

            if (CheckCredentials(adminUsername, adminPassword))
            {
                bool adminDashboardFormFound = false;

                foreach (Form form in Application.OpenForms)
                {
                    if (form is AdminDashboardForm)
                    {
                        form.Show();
                        adminDashboardFormFound = true;
                        break;
                    }
                }

                if (!adminDashboardFormFound)
                {
                    AdminDashboardForm adminDashboardForm = new AdminDashboardForm(adminUsername);
                    adminDashboardForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Admin Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private bool CheckCredentials(string username, string password)
        {
            string query = "SELECT admin_password FROM Admins WHERE BINARY_CHECKSUM(admin_username) = BINARY_CHECKSUM(@Username)";
            // BINARY_CHECKSUM is used for comparing the checksums of two sets of data to determine if they are identical (in this case, it is used to check the letter-case of the data)

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        connection.Open();

                        string hashedPassword = command.ExecuteScalar() as string;

                        // If username doesn't exist, return false
                        if (hashedPassword == null)
                            return false;

                        // Verify the hashed password using BCrypt
                        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
                    }
                    catch (Exception)
                    {
                        return false;   // Consider login failed in case of an error
                    }
                }
            }
            // Closing the connection is not necessary.
            // Using the 'using' statement with 'SqlConnection', will automatically call the 'Dispose' method (this will close the connection to the database) on the 'SqlConnection' object when the execution leaves the scope of the 'using' block.
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            txtAdminUsername.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtAdminPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAdminPassword.Text) && txtAdminPassword.Text != "Enter Password")
            {
                txtAdminPassword.PasswordChar = '•';

                btnPasswordToggleVisibility.Visible = true;
                btnPasswordToggleVisibility.Enabled = true;
            }
            else if (string.IsNullOrWhiteSpace(txtAdminPassword.Text))
            {
                txtAdminPassword.PasswordChar = '\0';

                btnPasswordToggleVisibility.Visible = false;
                btnPasswordToggleVisibility.Enabled = false;
            }
        }
        private void btnPasswordToggleVisibility_Click(object sender, EventArgs e)
        {
            txtAdminPassword.UseSystemPasswordChar = !txtAdminPassword.UseSystemPasswordChar;

            btnPasswordToggleVisibility.Image = txtAdminPassword.UseSystemPasswordChar ? Properties.Resources.show : Properties.Resources.hide;

            txtAdminPassword.Focus();    // Focus the textbox so that the rectangle (caused due to focus on button) is not displayed on the button (eye)
        }

        private void txtAdminUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the Enter key from being processed by the textbox
                txtAdminPassword.Focus(); // Move focus to the next textbox
            }
        }
        private void txtAdminPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnAdminLogin.PerformClick();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
