using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class FormNewPassword : Form
    {
        public FormNewPassword()
        {
            InitializeComponent();
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            // Get the text from the text boxes
            string newPassword = textBox1.Text;
            string confirmPassword = textBox2.Text;

            // Check if the new password and confirm password are the same
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }

            // If the passwords match, continue with password change logic
            // Here, you'd add your code to actually change the password, e.g., save to a database or update user info

            MessageBox.Show("Password successfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally close the form
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without changing the password
            this.Close();
        }
    }
}

