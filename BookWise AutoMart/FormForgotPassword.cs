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
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form when "Cancel" is clicked
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Example logic for the "Next" button
            string cnic = textBox1.Text; // Assuming you have a TextBox for CNIC
            DateTime dob = dateTimePicker1.Value; // Assuming you have a DateTimePicker for DOB

            // Example validation logic
            if (string.IsNullOrWhiteSpace(cnic) || cnic.Length != 13)
            {
                MessageBox.Show("Please enter a valid 13-digit CNIC.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dob > DateTime.Now)
            {
                MessageBox.Show("The Date of Birth cannot be in the future.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If validation is successful, you can proceed to the next step
            // For example, open a new form to reset the password
            FormNewPassword newPasswordForm = new FormNewPassword(); // Ensure this form exists
            newPasswordForm.StartPosition = FormStartPosition.CenterParent; // Opens centered
            newPasswordForm.ShowDialog(); // Opens as a modal dialog
        }
    }
}


