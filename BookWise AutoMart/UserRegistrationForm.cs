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
    public partial class UserRegistrationForm : Form
    {

        private string connectionString = DatabaseString.GetUserDatabase();

        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string gender = "";
            string contact = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime date = DateTime.Now;


            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contact) || string.IsNullOrWhiteSpace(email))
            {
                lblNotification.Visible = true;
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "All the fields must be filled";
            }
            else if (!ValidateName(name))
            {
                lblNotification.Visible = true;
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Invalid name format.";
            }
            else if (!radioMale.Checked && !radioFemale.Checked)
            {
                lblNotification.Visible = true;
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Select your gender";
            }
            else if (!ValidatePhoneNumber(contact))
            {
                lblNotification.Visible = true;
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Invalid phone number format.";
            }
            else if (!ValidateEmail(email))
            {
                lblNotification.Visible = true;
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Invalid email format.";
            }
            else
            {
                lblNotification.Visible = false;
            }

            if (radioMale.Checked)
            {
                gender = radioMale.Text.Trim();
            }
            else
            {
                gender = radioFemale.Text.Trim();
            }

            if (lblNotification.Visible == false)
            {
                InsertData(name, gender, contact, email, date);
            }
        }

        private bool ValidateName(string name) 
        {
            // Validating the name
            foreach (char c in name)
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
            string pattern = @"^\(?[0-9]{3}\)?[-.]?([0-9]{3})[-.]?([0-9]{4})$";

            // Check if the phone number matches the pattern
            return Regex.IsMatch(phoneNumber.ToString(), pattern);
        }

        private bool ValidateEmail(string email)
        {
            // Regular expression pattern to validate the email address
            string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            // Check if the email matches the pattern
            return Regex.IsMatch(email.ToString(), regex);
        }

        private void InsertData(string name, string gender, string contact, string email, DateTime date)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Users (name, gender,contact_number,email,registration_date) VALUES (@name,@gender, @contactNo, @email,@date)";
                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@contactNo", contact);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@date", date);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        UserLogin userLogin = new UserLogin();
                        userLogin.Show();
                        this.Close();
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validating whether the name is a letter, a control character and the field is not empty
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validating whether the phone number is a control character and a digit 
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                //--------------
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            //validating whether the phone number contains only ten digits
            if (txtPhone.Text.Length >= 10)
            {
                txtPhone.Text = txtPhone.Text.Substring(0, 10);
                //SelectionStart --> To prevent cursor to go to the begining
                txtPhone.SelectionStart = txtPhone.Text.Length;
            }
        }

        private void lblBacktologin_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
        }
    }
}
