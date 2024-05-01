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
        private readonly string passcode = "admin123";
        private int currentIndex = 0;

        public static UserPanel userPanel;  // to track the current UserPanel instance (current user)

        public UserLogin()
        {
            InitializeComponent();

            butLogin.KeyPress += UserLogin_KeyPress;
            btnGuestLogin.KeyPress += UserLogin_KeyPress;
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

                    ClearUserLoginData();   // Reset user input
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
            this.Activate();    // Focus the form
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
            }
        }
    }
}
