﻿using System;
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
        private string connectionString = DatabaseString.GetUserDatabase();

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
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "All the fields must be filled";
            }
            else if (!ValidateName(name))
            {
                lblNotification.Visible = true;
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Invalid name format.";
            }
            else if (!ValidatePhoneNumber(contact))
            {
                lblNotification.Visible = true;
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Invalid phone number format.";
            }
            else
            {
                lblNotification.Visible = false;
            }

            if(lblNotification.Visible == false)
            {
                InsertData(name, contact);
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
            string pattern = @"^\(?[0-9]{3}\)?[-.]?([0-9]{3})[-.]?([0-9]{4})$";

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

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@contactNo", contact);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        UserPanel userPanel = new UserPanel();
                        userPanel.Show();
                        this.Hide();
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

        //To prevent entering letters and characters in the phone no textbox
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
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
            }
        }
    }
}