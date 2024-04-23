using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookWise_AutoMart
{
    public partial class UserLogin : Form
    {
        private string connectionString = DatabaseString.GetUserDatabase();
        private string passcode = "admin123";
        private int currentIndex = 0;

        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnGuestLogin_Click(object sender, EventArgs e)
        {
            GuestLogin guestLogin = new GuestLogin();
            guestLogin.Show();
            this.Show();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            string contact = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(contact))
            {
                lblNotification.Visible = true;
                lblNotification.Text = "Please enter your phone number";
                lblNotification.ForeColor = Color.Red;
            }
            else if (!ValidatePhoneNumber(contact))
            {
                lblNotification.Visible = true;
                lblNotification.Text = "Invalid phone number";
                lblNotification.ForeColor = Color.Red;
            }
            else
            {
                lblNotification.Visible = false;
            }

            if (lblNotification.Visible == false)
            {
                CheckPhoneNo(contact);
            }
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            // Regular expression pattern to validate the phone number
            string pattern = @"^\(?[0-9]{3}\)?[-.]?([0-9]{3})[-.]?([0-9]{4})$";

            // Check if the phone number matches the pattern
            return Regex.IsMatch(phoneNumber.ToString(), pattern);
        }

        private void CheckPhoneNo(string contact)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT COUNT(1) FROM [Users] WHERE contact_number = @contact";
                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@contact", contact);

                    connection.Open();

                    int result = Convert.ToInt32(command.ExecuteScalar());  

                    if(result == 1)
                    {
                        UserPanel userPanel = new UserPanel();
                        userPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblNotification.Visible = true;
                        lblNotification.Text = "Invalid mobile number";
                        lblNotification.ForeColor = Color.Red;
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

        private void lblCreateacc_Click(object sender, EventArgs e)
        {
            UserRegistrationForm userRegistration = new UserRegistrationForm();
            userRegistration.Show();
            this.Hide();
        }

        private void UserLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentIndex < passcode.Length && e.KeyChar == passcode[currentIndex])
            {
                // Move to the next character
                currentIndex++;

                // If the passcode is complete
                if (currentIndex == passcode.Length)
                {
                    currentIndex = 0;   // Reset the passcode

                    bool adminLoginFormFound = false;

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is AdminLoginForm)
                        {
                            form.Show();
                            adminLoginFormFound = true;
                            break;
                        }
                    }
                    // The above code is used to check whether there already is an instance of the form to be displayed (in this case, AdminLoginForm) currently opened, and if so, it is displayed (rather than creating a new instance of the form every time)

                    if (!adminLoginFormFound)
                    {
                        AdminLoginForm adminLoginForm = new AdminLoginForm();
                        adminLoginForm.Show();
                    }

                    this.Hide();
                }
            }
            else
            {
                // Reset the passcode if the user types an incorrect character
                currentIndex = 0;
            }
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
