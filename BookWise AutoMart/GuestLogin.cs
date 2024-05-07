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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookWise_AutoMart
{
    public partial class GuestLogin : Form
    {
        public static UserPanel userPanel;  // to track the current UserPanel instance (current user)

        private readonly string connectionString = DatabaseString.GetUserDatabase();

        public GuestLogin()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string contact = txtPhone.Text.Trim();
            

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contact))
            {
                lblNotification.Visible = true;
                lblNotification.Text = "All the fields must be filled";
            }
            else if (!ValidateName(name))
            {
                lblNotification.Visible = true;
                lblNotification.Text = "Invalid name format.";
            }
            else if (!ValidatePhoneNumber(contact))
            {
                lblNotification.Visible = true;
                lblNotification.Text = "Invalid phone number format.";
            }
            else
            {
                lblNotification.Visible = false;
            }

            if(lblNotification.Visible == false)
            {
                // check if guest is already in the database
                int guestId = GetGuestId(name, contact);

                if (guestId != -1)
                {
                    userPanel = new UserPanel(guestId, "Guest");
                    userPanel.Show();

                    ClearGuestLoginData();  // Reset user input
                    this.Close();
                }
                else
                {
                    // add new guest
                    InsertData(name, contact);
                }
            }
        }

        private bool ValidateName(string name)
        {
            foreach(char c in name)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            // Regular expression pattern to validate the phone number
            string pattern = @"^(070|071|072|074|075|076|077|078)[0-9]{7}$";

            // Check if the phone number matches the pattern
            return Regex.IsMatch(phoneNumber.ToString(), pattern);
        }

        private void InsertData(string name, string contact)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Guests (guest_name, guest_contact_number) VALUES (@name, @contactNo)";
                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@name", name.Trim());
                    command.Parameters.AddWithValue("@contactNo", contact.Trim());

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        userPanel = new UserPanel(GetGuestId(name, contact), "Guest");
                        userPanel.Show();

                        ClearGuestLoginData();  // Reset user input
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                // Error
            }
        }
        private int GetGuestId(string guestName, string contactNo)
        {
            int lastGuestId = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT guest_id FROM Guests WHERE guest_name = @GuestName AND guest_contact_number = @ContactNumber";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@GuestName", guestName.Trim());
                        command.Parameters.AddWithValue("@ContactNumber", contactNo.Trim());

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            lastGuestId = (int)result;
                        }
                    }
                    catch (Exception)
                    {
                        // error
                    }
                }
            }

            return lastGuestId;
        }

        //To prevent entering letters and characters in the phone no textbox
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch(Exception)
            {
                //--------------
            }
        }
        
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if(txtPhone.Text.Length >= 10)
            {
                txtPhone.Text = txtPhone.Text.Substring(0, 10);
                //SelectionStart --> To prevent cursor to go to the begining
                txtPhone.SelectionStart = txtPhone.Text.Length;
            }
        }

        //To prevent entering numbers and characters in the name no textbox
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                // go to the next input field when the user presses the 'Enter' key
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtPhone.Focus();
                }
            }
        }

        private void lblBacktologin_Click(object sender, EventArgs e)
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

            ClearGuestLoginData();  // Reset user input
            this.Close();
        }

        private void ClearGuestLoginData()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            lblNotification.Visible = false;
        }
    }
}
