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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Attach the event handler for the LinkLabel
            linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked); // Ensure you have the semicolon here
        }

        // This is your event handler method for the LinkLabel
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the FormForgotPassword
            FormForgotPassword forgotPasswordForm = new FormForgotPassword();
            forgotPasswordForm.StartPosition = FormStartPosition.CenterParent; // Centered relative to parent
            forgotPasswordForm.ShowDialog(); // Opens as a modal dialog
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Check username and password
                string username = textBox1.Text;
                string password = textBox2.Text;

                // Example validation - replace with your authentication logic
                if (username == "admin" && password == "password")
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Open main form or perform other actions
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
