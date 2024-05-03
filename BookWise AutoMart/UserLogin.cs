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
        private readonly string connectionString = DatabaseString.GetUserDatabase();

        public static UserPanel userPanel;  // to track the current UserPanel instance (current user)

        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnGuestLogin_Click(object sender, EventArgs e)
        {
            bool guestLoginFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is GuestLogin)
                {
                    form.Show();
                    guestLoginFormFound = true;
                    break;
                }
            }

            if (!guestLoginFormFound)
            {
                GuestLogin guestLoginForm = new GuestLogin();
                guestLoginForm.Show();
            }

            ClearUserLoginData();   // Reset user input
            this.Hide();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            string contact = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(contact))
            {
                lblNotification.Visible = true;
                lblNotification.Text = "Please enter your phone number";
            }
            else if (!ValidatePhoneNumber(contact))
            {
                lblNotification.Visible = true;
                lblNotification.Text = "Invalid phone number";
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
                        userPanel = new UserPanel(GetCustomerId(contact), "Customer");
                        userPanel.Show();

                        ClearUserLoginData();   // Reset user input
                        this.Hide();
                    }
                    else
                    {
                        lblNotification.Visible = true;
                        lblNotification.Text = "Invalid mobile number";
                    }
                }
            }
            catch (Exception)
            {
                // Error
            }
        }
        private int GetCustomerId(string contactNo)
        {
            int customerId = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT user_id FROM Users WHERE contact_number = @ContactNumber";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@ContactNumber", contactNo.Trim());

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            customerId = (int)result;
                        }
                    }
                    catch (Exception)
                    {
                        // error
                    }
                }
            }

            return customerId;
        }

        private void lblCreateacc_Click(object sender, EventArgs e)
        {
            bool userRegistrationFound = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form is UserRegistrationForm)
                {
                    userRegistrationFound = true;
                    form.Show();
                    break;
                }
            }
            if (!userRegistrationFound)
            {
                UserRegistrationForm userRegistration = new UserRegistrationForm();
                userRegistration.Show();
            }

            ClearUserLoginData();   // Reset user input
            this.Hide();
        }

        private void ClearUserLoginData()
        {
            txtPhone.Text = "";
            lblNotification.Visible = false;
        }

        // allow the user to only enter numbers
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                // login when the user presses the 'Enter' key
                if (e.KeyChar == (char)Keys.Enter)
                {
                    butLogin.PerformClick();
                }
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            bool adminLoginFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is AdminLoginForm)
                {
                    adminLoginFormFound = true;
                    form.Show();
                    break;
                }
            }
            if (!adminLoginFormFound)
            {
                AdminLoginForm adminLoginForm = new AdminLoginForm();
                adminLoginForm.Show();
            }

            ClearUserLoginData();   // Reset user input
            this.Hide();
        }
    }
}
