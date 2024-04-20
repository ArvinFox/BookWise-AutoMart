using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BookWise_AutoMart
{
    public partial class AdminManageSubcategoriesForm : Form
    {
        private string connectionString = DatabaseString.GetUserDatabase();

        private bool isCategorySelected = false;
        private string oldSubcategories = "";   // subcategories existing in the database
        private string newSubcategories = "";   // subcategories selected by the admin

        public AdminManageSubcategoriesForm()
        {
            InitializeComponent();

            PopulateCategoriesComboBox();
            Placeholder(txtNewSubcategory, "Enter Subcategory Name");
        }

        private void btnAddNewSubcategory_Click(object sender, EventArgs e)
        {
            if (!isCategorySelected)
            {
                lblCategoryError.Visible = true;

                lblErrors.Text = "Please select a category first";
                lblErrors.Visible = true;
            }
            else
            {
                if (IsFieldEmpty(txtNewSubcategory))
                {
                    lblErrors.Text = "Please enter a subcategory name";
                    lblErrors.Visible = true;
                    return;
                }

                string subcategoryName = txtNewSubcategory.Text.Trim();

                if (newSubcategories.Split(',').Any(s => s.Trim() == subcategoryName))
                {
                    lblErrors.Text = "Subcategory already added";
                    lblErrors.Visible = true;
                }
                else
                {
                    // Add entered subcategory to newSubcategories array
                    if (newSubcategories.Trim() == "")
                    {
                        newSubcategories += subcategoryName;
                    }
                    else
                    {
                        newSubcategories += "," + subcategoryName;
                    }

                    DisplaySubcategories(newSubcategories);  // update the subcategories display
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();

            string errors = "";

            if (!isCategorySelected)
            {
                errors += "Please select a category first";
            }
            else
            {
                if (newSubcategories.Trim() == "" || newSubcategories.Trim() == ",")
                {
                    errors += "Please add subcategories to the selected category\n";
                }
            }

            // Check for any errors
            if (errors != "")
            {
                DisplayErrorMessages(errors);
                return;
            }

            int selectedCategoryId = GetCategoryIdByName(comboBoxCategories.SelectedItem.ToString());
            UpdateSubcategories(selectedCategoryId);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateCategoriesComboBox()
        {
            comboBoxCategories.Items.Clear();

            comboBoxCategories.Items.Add("Select category");
            comboBoxCategories.SelectedIndex = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT category_name FROM Categories";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string categoryName = reader["category_name"].ToString();
                                    comboBoxCategories.Items.Add(categoryName);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No existing categories. Please add a category first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void GetExistingSubcategories(int id)
        {
            oldSubcategories = "";  // reset subcategories array

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT subcategory_name FROM SubCategories WHERE subcategory_category_id = @CategoryId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@CategoryId", id);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string subcategoryName = reader["subcategory_name"].ToString();

                                    if (oldSubcategories.Trim() == "")
                                    {
                                        oldSubcategories += subcategoryName;
                                    }
                                    else
                                    {
                                        oldSubcategories += "," + subcategoryName;
                                    }
                                }

                                newSubcategories = oldSubcategories;
                            }
                            else
                            {
                                MessageBox.Show("Category does not exist or category does not contain subcategories.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving subcategories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private int GetCategoryIdByName(string categoryName)
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

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return (int)result;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving category id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }
            }
        }
        private void DisplaySubcategories(string subcategoriesArray)
        {
            pnlSubcategories.Controls.Clear();  // Clear existing subcategories

            // Split the subcategories (array) into individual subcategories
            string[] subcategoryNames = subcategoriesArray.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Iterate through each item id and fetch its name (from Items table)
            foreach (string subcategoryName in subcategoryNames)
            {
                string subcategory = subcategoryName.Trim();
                /*int subcategoryId = GetSubcategoryIdByName(subcategory);*/

                // Subcategory container
                TableLayoutPanel tblSubcategory = new TableLayoutPanel();
                tblSubcategory.Dock = DockStyle.Top;
                tblSubcategory.ColumnCount = 2;
                tblSubcategory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
                tblSubcategory.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
                tblSubcategory.Height = 40;

                Label lblSubcategory = new Label();
                lblSubcategory.AutoSize = true;
                lblSubcategory.Anchor = AnchorStyles.Left;
                /*lblSubcategory.Text = $"[{subcategoryId}] {subcategory.Trim()}";*/
                lblSubcategory.Text = $"{subcategory.Trim()}";
                tblSubcategory.Controls.Add(lblSubcategory, 0, 0);

                Button btnRemoveSubcategory = new Button();
                btnRemoveSubcategory.Anchor = AnchorStyles.None;
                btnRemoveSubcategory.FlatStyle = FlatStyle.Flat;
                btnRemoveSubcategory.FlatAppearance.BorderSize = 0;
                btnRemoveSubcategory.Font = new Font("Gadugi", 11, FontStyle.Bold);
                btnRemoveSubcategory.Size = new Size(110, 30);
                btnRemoveSubcategory.Text = "Remove";
                btnRemoveSubcategory.Cursor = Cursors.Hand;
                btnRemoveSubcategory.BackColor = Color.Tomato;
                btnRemoveSubcategory.ForeColor = Color.White;
                btnRemoveSubcategory.Tag = subcategoryName;
                btnRemoveSubcategory.Click += (sender, e) =>
                {
                    if (pnlSubcategories.Controls.Count == 1)
                    {
                        ResetSubcategories();
                    }

                    // remove the subcategory from the subcategories string
                    string subcategoryToRemove = btnRemoveSubcategory.Tag.ToString();
                    string[] updatedSubcategoryNames = subcategoryNames.Where(name => name != subcategoryToRemove).ToArray();
                    string updatedSubcategories = string.Join(",", updatedSubcategoryNames);

                    // update the subcategories string
                    newSubcategories = updatedSubcategories;

                    subcategoryNames = updatedSubcategoryNames;

                    // get the parent row of the button
                    TableLayoutPanel parentTableLayoutPanel = (TableLayoutPanel)btnRemoveSubcategory.Parent;

                    // remove the corresponding row (table layout panel)
                    pnlSubcategories.Controls.Remove(parentTableLayoutPanel);
                };
                tblSubcategory.Controls.Add(btnRemoveSubcategory, 1, 0);

                pnlSubcategories.Controls.Add(tblSubcategory);
            }
        }
        private int GetSubcategoryIdByName(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT subcategory_id FROM SubCategories WHERE subcategory_name = @SubcategoryName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@SubcategoryName", name);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return (int)result;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving subcategory id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }
            }
        }
        private void UpdateSubcategories(int categoryId)
        {
            bool sameSubcategories = true;
            bool newSubcategoryAdded = false;
            bool oldSubcategoryRemoved = false;
            string removedSubcategories = "";
            string addedSubcategories = "";

            // compare old and new subcategories
            string[] oldSubcategoriesArray = oldSubcategories.Split(',');
            string[] newSubcategoriesArray = newSubcategories.Split(',');

            // check if all new subcategories are in the old ones
            foreach (var item in newSubcategoriesArray)
            {
                if (!oldSubcategoriesArray.Contains(item))
                {
                    sameSubcategories = false;
                    newSubcategoryAdded = true;

                    if (addedSubcategories.Trim() == "")
                    {
                        addedSubcategories += item;
                    }
                    else
                    {
                        addedSubcategories += "," + item;
                    }
                }
            }

            // check if all old subcategories are in the new ones
            foreach (var item in oldSubcategoriesArray)
            {
                if (!newSubcategoriesArray.Contains(item))
                {
                    sameSubcategories = false;
                    oldSubcategoryRemoved = true;
                    
                    if (removedSubcategories.Trim() == "")
                    {
                        removedSubcategories += item;
                    }
                    else
                    {
                        removedSubcategories += "," + item;
                    }
                }
            }

            if (sameSubcategories)
            {
                // no change done to subcategories
                MessageBox.Show($"[Category ID: {categoryId}]\nSubcategories updated successfully.", "Update Subcategory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool updated = false;
                string updateError = "";

                if (oldSubcategoryRemoved)
                {
                    // check if there are any items which fall under the subcategories to be deleted
                    if (ItemsExistInSubcategoryToDelete(removedSubcategories))
                    {
                        DialogResult result = MessageBox.Show($"[Category ID: {categoryId}]\n{GetItemDetails(removedSubcategories)}\nThe above mentioned items will be deleted if you proceed. Are you sure you want to continue?", "Delete Subcategory", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            // delete items which fall under the subcategories to be deleted
                            DeleteItemsInSubcategoryToDelete(removedSubcategories);
                        }
                        else
                        {
                            return;
                        }
                    }

                    updated = DeleteSubcategories(removedSubcategories);  // delete the subcategories
                    updateError = "Error in deleting subcategories";
                }

                if (newSubcategoryAdded)
                {
                    updated = AddSubcategories(addedSubcategories, categoryId);   // add the subcategories
                    updateError = "Error in adding subcategories";
                }

                // check if there were any errors in updating subcategories
                if (updated)
                {
                    MessageBox.Show($"[Category ID: {categoryId}]\nSubcategories updated successfully.", "Update Subcategory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to update subcategories.\n" + updateError, "Update Subcategory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            btnCancel.PerformClick();
            AdminControlForm.btnReloadInventoryManagementForm.PerformClick();   // Refresh form
        }
        private string GetItemDetails(string subcategoriesToDelete)
        {
            StringBuilder itemDetails = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT item_id, item_name FROM Items WHERE item_subcategory_id = @SubcategoryId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Split the subcategoriesToDelete (array) into individual subcategories
                        string[] subcategoryNames = subcategoriesToDelete.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string subcategoryName in subcategoryNames)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@SubcategoryId", GetSubcategoryIdByName(subcategoryName));

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    itemDetails.Append($"\nSubcategory: {subcategoryName}\n");

                                    while (reader.Read())
                                    {
                                        int itemId = (int)reader["item_id"];
                                        string itemName = reader["item_name"].ToString();

                                        itemDetails.AppendLine($"   [{itemId}] {itemName}");
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving item details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return itemDetails.ToString();
        }
        private bool ItemsExistInSubcategoryToDelete(string subcategoriesToDelete)
        {
            int itemCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Items WHERE item_subcategory_id = @SubcategoryId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Split the subcategoriesToDelete (array) into individual subcategories
                        string[] subcategoryNames = subcategoriesToDelete.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string subcategoryName in subcategoryNames)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@SubcategoryId", GetSubcategoryIdByName(subcategoryName));
                            itemCount += (int)command.ExecuteScalar();
                        }

                        return itemCount > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in deleting sucategories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        private void DeleteItemsInSubcategoryToDelete(string subcategoriesToDelete)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Items WHERE item_subcategory_id = @SubcategoryId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Split the subcategoriesToDelete (array) into individual subcategories
                        string[] subcategoryNames = subcategoriesToDelete.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string subcategoryName in subcategoryNames)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@SubcategoryId", GetSubcategoryIdByName(subcategoryName));
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in deleting sucategories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool DeleteSubcategories(string subcategoriesToDelete)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM SubCategories WHERE subcategory_name = @SubcategoryName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Split the subcategoriesToDelete (array) into individual subcategories
                        string[] subcategoryNames = subcategoriesToDelete.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string subcategoryName in subcategoryNames)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@SubcategoryName", subcategoryName.Trim());
                            command.ExecuteNonQuery();
                        }

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in deleting sucategories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        private bool AddSubcategories(string subcategoriesToAdd, int categoryIdToAddTo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SubCategories (subcategory_category_id, subcategory_name) VALUES (@CategoryId, @SubcategoryName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Split the subcategoriesToAdd (array) into individual subcategories
                        string[] subcategoryNames = subcategoriesToAdd.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string subcategoryName in subcategoryNames)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@CategoryId", categoryIdToAddTo);
                            command.Parameters.AddWithValue("@SubcategoryName", subcategoryName.Trim());
                            command.ExecuteNonQuery();
                        }

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in adding sucategories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
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
        private void ResetSubcategories()
        {
            pnlSubcategories.Controls.Clear();

            // Item container
            TableLayoutPanel tblNoSubcategories = new TableLayoutPanel();
            tblNoSubcategories.Dock = DockStyle.Top;
            tblNoSubcategories.ColumnCount = 1;
            tblNoSubcategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tblNoSubcategories.Height = 40;

            Label lblNoSubcategories = new Label();
            lblNoSubcategories.AutoSize = true;
            lblNoSubcategories.Anchor = AnchorStyles.Left;
            lblNoSubcategories.ForeColor = SystemColors.GrayText;
            lblNoSubcategories.Text = (isCategorySelected) ? "Add Subcategories" : "Select a category";
            tblNoSubcategories.Controls.Add(lblNoSubcategories, 0, 0);

            pnlSubcategories.Controls.Add(tblNoSubcategories);
        }

        private void DisplayErrorMessages(string errors)
        {
            string[] errorMessages = errors.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            // split the errors into sub-errors (separated using the new line character)
            // StringSplitOptions.RemoveEmptyEntries --> excludes any empty strings

            foreach (string errorMessage in errorMessages)
            {
                if (errorMessage.Contains("Please add subcategories to the selected category"))
                {
                    lblSubcategoriesError.Visible = true;

                    lblErrors.Text = "Please add subcategories to the selected category";
                    lblErrors.Visible = true;
                }

                if (errorMessage.Contains("Please select a category first"))
                {
                    lblCategoryError.Visible = true;

                    lblErrors.Text = "Please select a category first";
                    lblErrors.Visible = true;
                }
            }
        }
        private void ClearErrorMessages()
        {
            lblErrors.Text = "";

            lblErrors.Visible = false;
            lblCategoryError.Visible = false;
            lblSubcategoriesError.Visible = false;
        }

        private bool IsFieldEmpty(TextBox textBox)
        {
            if (textBox == txtNewSubcategory)
            {
                if (textBox.Text.Trim() == "Enter Subcategory Name" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxCategories.SelectedItem.ToString();

            if (!selectedCategory.Equals("Select category"))
            {
                isCategorySelected = true;

                int categoryId = GetCategoryIdByName(selectedCategory);
                GetExistingSubcategories(categoryId);
                DisplaySubcategories(newSubcategories);
            }
            else
            {
                isCategorySelected = false;
                ResetSubcategories();
            }

            Placeholder(txtNewSubcategory, "Enter Subcategory Name");
            lblCategoryError.Visible = false;
            lblErrors.Visible = false;
        }
        private void txtNewSubcategory_TextChanged(object sender, EventArgs e)
        {
            lblSubcategoriesError.Visible = false;
            lblErrors.Visible = false;
        }
        private void txtNewSubcategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnAddNewSubcategory.PerformClick();
            }
        }
    }
}
