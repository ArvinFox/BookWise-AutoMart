﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class AdminAddNewCategoryForm : Form
    {
        private readonly string connectionString = DatabaseString.GetUserDatabase();

        public AdminAddNewCategoryForm()
        {
            InitializeComponent();

            Placeholder(txtNewCategory, "Enter Category Name");
        }

        private void Placeholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = SystemColors.GrayText;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = SystemColors.GrayText;
                }
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewCategory.Text) || txtNewCategory.Text.Trim().Equals("Enter Category Name"))
            {
                lblNewCategoryRequired.Visible = true;
                return;
            }

            string categoryName = txtNewCategory.Text.Trim();

            // Check if category already exists
            if (CategoryExists(categoryName))
            {
                MessageBox.Show("Category already exists.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new category
            AddCategory(categoryName);

            // Add default subcategory to newly added category
            AddDefaultSubCategory(categoryName);
        }
        private void btnManageSubcategories_Click(object sender, EventArgs e)
        {
            bool adminManageSubcategoriesFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is AdminManageSubcategoriesForm)
                {
                    form.ShowDialog();
                    adminManageSubcategoriesFormFound = true;
                    break;
                }
            }

            if (!adminManageSubcategoriesFormFound)
            {
                AdminManageSubcategoriesForm adminManageSubcategoriesForm = new AdminManageSubcategoriesForm();
                adminManageSubcategoriesForm.ShowDialog();
            }

            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CategoryExists(string categoryName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Categories WHERE category_name = @CategoryName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@CategoryName", categoryName);

                        connection.Open();

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        private void AddCategory(string categoryName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Categories (category_name) VALUES (@CategoryName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@CategoryName", categoryName);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New category added successfully.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnCancel.PerformClick();
                            AdminControlForm.btnReloadInventoryManagementForm.PerformClick();   // Refresh form
                        }
                        else
                        {
                            MessageBox.Show("Unable to add new category.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void AddDefaultSubCategory(string categoryName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SubCategories (subcategory_category_id, subcategory_name) VALUES (@SubcategoryId, @SubcategoryName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@SubcategoryId", GetCategoryId(categoryName));
                        command.Parameters.AddWithValue("@SubcategoryName", $"Default [{categoryName}]");

                        connection.Open();

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding default subcategory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private int GetCategoryId(string categoryName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT category_id FROM Categories WHERE category_name = @CategoryName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@CategoryName", categoryName);

                        connection.Open();

                        int categoryId = (int)command.ExecuteScalar();

                        return categoryId;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving category id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return -1;
        }

        private void txtNewCategory_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewCategory.Text) || txtNewCategory.Text.Trim().Equals("Enter Category Name"))
            {
                btnManageSubcategories.Visible = true;
                return;
            }
            else
            {
                btnManageSubcategories.Visible = false;
                lblNewCategoryRequired.Visible = false;
            }
        }

        private void txtNewCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSave.PerformClick();
            }
        }
    }
}
