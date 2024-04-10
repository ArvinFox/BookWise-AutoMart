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

namespace BookWise_AutoMart
{
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
        }
        private static bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }

        private bool ValidatePhoneNumber(int phoneNumber)
        {
            // Regular expression pattern to validate the phone number
            string pattern = @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$";

            // Check if the phone number matches the pattern
            return Regex.IsMatch(phoneNumber.ToString(), pattern);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string errors = "";
            string name = tbname.Text;
            string gender = "";
            string phoneNumberStr = tbpn.Text;
            string email = tbemail.Text;
            string registrationDate = DateTime.Now.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(name))
            {
                errors += "Please enter a name.\n";
            }
            if (name.Any(char.IsDigit))
            {
                errors += "Name cannot contain numeric characters.\n";
            }

            if (!radiomale.Checked && !radiofemale.Checked)
            {
                errors += "Please select a gender.\n";
            }
            else
            {
                gender = radiomale.Checked ? "Male" : "Female";
            }

            if (string.IsNullOrWhiteSpace(phoneNumberStr))
            {
                errors += "Please enter a phone number.\n";
            }

            if (!int.TryParse(phoneNumberStr, out int phoneNumber))
            {
                errors += "Phone number must be a valid integer.\n";
            }

            if (!ValidatePhoneNumber(phoneNumber))
            {
                errors += "Invalid phone number format.\n";
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                errors += "Please enter an email address.\n";
            }
            else if (!IsValid(email))
            {
                errors += "Invalid email address format.\n";
            }

            if (errors != "")
            {
                MessageBox.Show(errors, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            Console.ReadLine();

            // If all validations pass, proceed with database insertion
            SqlConnection con1 = new SqlConnection(DatabaseString.GetUserDatabase());

            string query = $"INSERT INTO Users (name, gender, email, contact_number, registration_date) VALUES ('{name}', '{gender}','{email}', {phoneNumber}, '{registrationDate}')";

            SqlCommand cmd = new SqlCommand(query, con1);

            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful data entry");
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Database error: " + sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
            }
        }
    }
}
