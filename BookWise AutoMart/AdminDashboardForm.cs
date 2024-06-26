﻿using System;
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
    public partial class AdminDashboardForm : Form
    {
        public static AdminControlForm adminControlForm;

        public AdminDashboardForm(string username)
        {
            InitializeComponent();

            lblWelcomeAdmin.Text = $"Welcome, Admin ({username})";
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string formControl = button.Text;

            bool adminControlFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is AdminControlForm)
                {
                    form.Show();
                    adminControlFormFound = true;
                    break;
                }
            }

            if (!adminControlFormFound)
            {
                adminControlForm = new AdminControlForm(formControl);
                adminControlForm.Show();
            }

            this.Close();
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
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

            this.Close();
        }
    }
}
