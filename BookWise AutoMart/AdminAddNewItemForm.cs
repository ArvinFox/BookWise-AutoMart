using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class AdminAddNewItemForm : Form
    {
        // Timer for incrementing stock
        private readonly Timer incrementTimer = new Timer();
        // Timer for decrementing stock
        private readonly Timer decrementTimer = new Timer();

        private bool imageChanged = false;
        private bool isCategorySelected = false;
        private bool isSubcategorySelected = false;

        private readonly string connectionString = DatabaseString.GetUserDatabase();

        public AdminAddNewItemForm()
        {
            InitializeComponent();

            // Initialize and configure timers
            incrementTimer.Interval = 100;
            incrementTimer.Tick += (sender, e) => pictureBoxIncrementStock_Click(sender, e);
            decrementTimer.Interval = 100;
            decrementTimer.Tick += (sender, e) => pictureBoxDecrementStock_Click(sender, e);

            PopulateCategoriesComboBox();
            ResetSubcategoriesComboBox();
            Placeholder("Enter Item Name", txtItemName, null);
            Placeholder("Enter Item Description", null, rtbItemDescription);
            Placeholder("Enter Item Price", txtPrice, null);
            Placeholder("Enter Item Stock", txtStock, null);
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            // Create OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options and filter index
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            // Do not allow multiple file selection
            openFileDialog.Multiselect = false;

            // Display OpenFileDialog by calling ShowDialog method
            DialogResult result = openFileDialog.ShowDialog();

            // Check if the user selected a file
            if (result == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog.FileName;

                try
                {
                    // Load the selected image
                    Image selectedImage = Image.FromFile(filePath);
                    pictureBoxImage.Image = selectedImage;
                    imageChanged = true;
                    lblImageRequired.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading the selected image: " + ex.Message);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();

            string errors = "";

            if (IsFieldEmpty(txtItemName) && IsFieldEmpty(null, rtbItemDescription) && !isCategorySelected && !isSubcategorySelected && IsFieldEmpty(txtPrice) && IsFieldEmpty(txtStock) && !imageChanged)
            {
                errors += "Please fill out all the fields\n";
            }
            else
            {
                if (IsFieldEmpty(txtItemName))
                {
                    errors += "Please enter item name\n";
                }

                if (IsFieldEmpty(null, rtbItemDescription))
                {
                    errors += "Please enter item description\n";
                }

                if (!isCategorySelected)
                {
                    errors += "Please select item type\n";
                }

                if (!isSubcategorySelected)
                {
                    errors += "Empty subcategory\n";
                }

                if (IsFieldEmpty(txtPrice))
                {
                    errors += "Please enter item price\n";
                }
                else if (!IsValidPrice(txtPrice))
                {
                    errors += "Please enter a valid price\n";
                }

                if (IsFieldEmpty(txtStock))
                {
                    errors += "Please enter item stock\n";
                }
                else if (!IsValidStock(txtStock))
                {
                    errors += "Please enter a valid stock\n";
                }

                if (!imageChanged)
                {
                    errors += "Please upload item image\n";
                }
            }

            // Check for any errors
            if (errors != "")
            {
                DisplayErrorMessages(errors);
                return;
            }

            AddItem();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();

            Placeholder("Enter Item Name", txtItemName, null);
            Placeholder("Enter Item Description", null, rtbItemDescription);
            comboBoxCategories.SelectedIndex = 0;
            ResetSubcategoriesComboBox();
            Placeholder("Enter Item Price", txtPrice, null);
            Placeholder("Enter Item Stock", txtStock, null);
            pictureBoxImage.Image = Properties.Resources.folder__gray_;

            isCategorySelected = false;
            isSubcategorySelected = false;
            imageChanged = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItem()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Items (item_name, item_description, item_category_id, item_subcategory_id, price, stock, temporary_stock, image) VALUES (@ItemName, @ItemDescription, @ItemCategoryId, @ItemSucategoryId, @Price, @Stock, @Stock, @ImageData)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@ItemName", txtItemName.Text.Trim());
                        command.Parameters.AddWithValue("@ItemDescription", rtbItemDescription.Text.Trim());

                        string categoryName = comboBoxCategories.SelectedItem.ToString();
                        int categoryId = GetCategoryId(categoryName);
                        command.Parameters.AddWithValue("@ItemCategoryId", categoryId);

                        string subcategoryName = comboBoxSubCategories.SelectedItem.ToString();
                        int subcategoryId = GetSubcategoryId(subcategoryName);
                        command.Parameters.AddWithValue("@ItemSucategoryId", subcategoryId);

                        command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text.Trim()));
                        command.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text.Trim()));

                        byte[] imageData;

                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBoxImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            imageData = ms.ToArray();
                        }

                        command.Parameters.AddWithValue("@ImageData", imageData);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item added successfully.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnCancel.PerformClick();
                            AdminControlForm.btnReloadInventoryManagementForm.PerformClick();   // Refresh form
                        }
                        else
                        {
                            MessageBox.Show("Unable to add item.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error addng item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
        private bool PopulateSubcategoriesComboBox(string selectedCategoryName)
        {
            // the method has a return type (bool) to verify whether the selected category has any subcategories

            comboBoxSubCategories.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT subcategory_name
                                 FROM SubCategories
                                 INNER JOIN Categories ON SubCategories.subcategory_category_id = Categories.category_id
                                 WHERE category_name = @CategoryName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@CategoryName", selectedCategoryName);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string subcategoryName = reader["subcategory_name"].ToString();
                                    comboBoxSubCategories.Items.Add(subcategoryName);
                                }
                                return true;    // selected category has subcategories
                            }
                            else
                            {
                                MessageBox.Show($"Category does not contain any subcategories.\nPlease add subcategories to this category ({selectedCategoryName}).", "Missing Subcategories", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;    // selected category does not have subcategories
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving subcategories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;    // consider selected category does not have subcategories in case of any errors
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
        private int GetSubcategoryId(string subcategoryName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT subcategory_id FROM SubCategories WHERE subcategory_name = @SubcategoryName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@SubcategoryName", subcategoryName);

                        connection.Open();

                        int subcategoryId = (int)command.ExecuteScalar();

                        return subcategoryId;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving subcategory id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return -1;
        }

        private void Placeholder(string placeholder, TextBox textBox = null, RichTextBox rtb = null)
        {
            if (textBox == null)
            {
                rtb.Text = placeholder;
                rtb.ForeColor = SystemColors.GrayText;

                rtb.GotFocus += (sender, e) =>
                {
                    if (rtb.Text == placeholder)
                    {
                        rtb.Text = "";
                        rtb.ForeColor = SystemColors.WindowText;
                    }
                };

                rtb.LostFocus += (sender, e) =>
                {
                    if (string.IsNullOrWhiteSpace(rtb.Text))
                    {
                        rtb.Text = placeholder;
                        rtb.ForeColor = SystemColors.GrayText;
                    }
                };
            }
            else
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
        }
        private void ResetSubcategoriesComboBox()
        {
            comboBoxSubCategories.Items.Clear();
            comboBoxSubCategories.Items.Add("Select a category first");
            comboBoxSubCategories.ForeColor = SystemColors.GrayText;
            comboBoxSubCategories.SelectedIndex = 0;
        }

        private void DisplayErrorMessages(string errors)
        {
            string[] errorMessages = errors.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            // split the errors into sub-errors (separated using the new line character)
            // StringSplitOptions.RemoveEmptyEntries --> excludes any empty strings

            foreach (string errorMessage in errorMessages)
            {
                if (errorMessage.Contains("Please fill out all the fields"))
                {
                    lblRequiredFields.Visible = true;
                    lblItemNameRequired.Visible = true;
                    lblItemDescriptionRequired.Visible = true;
                    lblCategoryRequired.Visible = true;
                    lblSubcategoryRequired.Visible = true;
                    lblPriceRequired.Visible = true;
                    lblStockRequired.Visible = true;
                    lblImageRequired.Visible = true;
                }

                if (errorMessage.Contains("Please enter item name"))
                {
                    lblItemNameRequired.Visible = true;
                    lblRequiredFields.Visible = true;
                }

                if (errorMessage.Contains("Please enter item description"))
                {
                    lblItemDescriptionRequired.Visible = true;
                    lblRequiredFields.Visible = true;
                }

                if (errorMessage.Contains("Please select item type"))
                {
                    lblCategoryRequired.Visible = true;
                    lblRequiredFields.Visible = true;
                }

                if (errorMessage.Contains("Empty subcategory"))
                {
                    lblSubcategoryRequired.Visible = true;
                    lblRequiredFields.Visible = true;
                }

                if (errorMessage.Contains("Please enter item price") || errorMessage.Contains("Please enter a valid price"))
                {
                    if (errorMessage.Contains("Please enter item price"))
                    {
                        lblPriceRequired.Text = "*";
                        lblRequiredFields.Visible = true;
                    }
                    else if (errorMessage.Contains("Please enter a valid price"))
                    {
                        lblPriceRequired.Text = "Please enter a valid price";
                    }

                    lblPriceRequired.Visible = true;
                }

                if (errorMessage.Contains("Please enter item stock") || errorMessage.Contains("Please enter a valid stock"))
                {
                    if (errorMessage.Contains("Please enter item stock"))
                    {
                        lblStockRequired.Text = "*";
                        lblRequiredFields.Visible = true;
                    }
                    else if (errorMessage.Contains("Please enter a valid stock"))
                    {
                        lblStockRequired.Text = "Please enter a valid stock";
                    }

                    lblStockRequired.Visible = true;
                }

                if (errorMessage.Contains("Please upload item image"))
                {
                    lblImageRequired.Visible = true;
                    lblRequiredFields.Visible = true;
                }
            }
        }
        private void ClearErrorMessages()
        {
            lblSubcategoryRequired.Text = "*";
            lblPriceRequired.Text = "*";
            lblStockRequired.Text = "*";

            lblRequiredFields.Visible = false;
            lblItemNameRequired.Visible = false;
            lblItemDescriptionRequired.Visible = false;
            lblCategoryRequired.Visible = false;
            lblSubcategoryRequired.Visible = false;
            lblPriceRequired.Visible = false;
            lblStockRequired.Visible = false;
            lblImageRequired.Visible = false;
        }

        private bool IsFieldEmpty(TextBox textBox = null, RichTextBox rtb = null)
        {
            if (textBox == null)
            {
                if (rtb == rtbItemDescription)
                {
                    if (rtb.Text.Trim() == "Enter Item Description" || string.IsNullOrWhiteSpace(rtb.Text))
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (textBox == txtItemName)
                {
                    if (textBox.Text.Trim() == "Enter Item Name" || string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return true;
                    }
                }
                else if (textBox == txtPrice)
                {
                    if (textBox.Text.Trim() == "Enter Item Price" || string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return true;
                    }
                }
                else if (textBox == txtStock)
                {
                    if (textBox.Text.Trim() == "Enter Item Stock" || string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private bool IsValidPrice(TextBox textBox)
        {
            if (decimal.TryParse(textBox.Text, out decimal price))
            {
                if (price >= 0) // Price cannot be negative
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private bool IsValidStock(TextBox textBox)
        {
            string stock = textBox.Text.Trim();

            foreach (char character in stock)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }

            // Stock cannot be negative
            if (Convert.ToInt32(stock) < 0)
            {
                return false;
            }

            return true;
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxCategories.SelectedItem.ToString();

            if (comboBoxCategories.SelectedItem.ToString().Equals("Select category"))
            {
                isCategorySelected = false;

                isSubcategorySelected = false;
                ResetSubcategoriesComboBox();
            }
            else
            {
                isCategorySelected = true;

                comboBoxSubCategories.ForeColor = Color.Black;

                if (PopulateSubcategoriesComboBox(selectedCategory))
                {
                    comboBoxSubCategories.SelectedIndex = 0;
                    isSubcategorySelected = true;
                }
            }

            lblCategoryRequired.Visible = false;
        }
        private void comboBoxSubCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSubcategoryRequired.Visible = false;
        }

        private void pictureBoxIncrementStock_Click(object sender, EventArgs e)
        {
            if (IsFieldEmpty(txtStock))
            {
                incrementTimer.Stop();
                DisplayErrorMessages("Please enter item stock");
                return;
            }
            else if (!IsValidStock(txtStock))
            {
                incrementTimer.Stop();
                DisplayErrorMessages("Please enter a valid stock");
                return;
            }

            int stock = Convert.ToInt32(txtStock.Text);
            stock++;
            txtStock.Text = stock.ToString();
        }
        private void pictureBoxIncrementStock_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxIncrementStock.BackColor = Color.LightGray;
        }
        private void pictureBoxIncrementStock_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxIncrementStock.BackColor = SystemColors.Control;
        }
        private void pictureBoxIncrementStock_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxIncrementStock.BackColor = Color.Gray;
            incrementTimer.Start();
        }
        private void pictureBoxIncrementStock_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxIncrementStock.BackColor = Color.LightGray;
            incrementTimer.Stop();
        }

        private void pictureBoxDecrementStock_Click(object sender, EventArgs e)
        {
            if (IsFieldEmpty(txtStock))
            {
                decrementTimer.Stop();
                DisplayErrorMessages("Please enter item stock");
                return;
            }
            else if (!IsValidStock(txtStock))
            {
                decrementTimer.Stop();
                DisplayErrorMessages("Please enter a valid stock");
                return;
            }

            int stock = Convert.ToInt32(txtStock.Text);

            if (stock == 0)
            {
                decrementTimer.Stop();
                MessageBox.Show("Invalid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stock--;
            txtStock.Text = stock.ToString();
        }
        private void pictureBoxDecrementStock_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxDecrementStock.BackColor = Color.LightGray;
        }
        private void pictureBoxDecrementStock_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDecrementStock.BackColor = SystemColors.Control;
        }
        private void pictureBoxDecrementStock_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxDecrementStock.BackColor = Color.Gray;
            decrementTimer.Start();
        }
        private void pictureBoxDecrementStock_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxDecrementStock.BackColor = Color.LightGray;
            decrementTimer.Stop();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            if (!IsFieldEmpty(txtItemName))
            {
                lblItemNameRequired.Visible = false;
            }
        }
        private void rtbItemDescription_TextChanged(object sender, EventArgs e)
        {
            if (!IsFieldEmpty(null, rtbItemDescription))
            {
                lblItemDescriptionRequired.Visible = false;
            }
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!IsFieldEmpty(txtPrice))
            {
                lblPriceRequired.Visible = false;
            }
        }
        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            if (!IsFieldEmpty(txtStock))
            {
                lblStockRequired.Visible = false;
            }
        }

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                rtbItemDescription.Focus();
            }
        }
        private void rtbItemDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                comboBoxCategories.Focus();
            }
        }
        private void comboBoxCategories_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                comboBoxSubCategories.Focus();
            }
        }
        private void comboBoxSubCategories_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtPrice.Focus();
            }
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtStock.Focus();
            }
        }
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnChooseImage.Focus();
            }
        }
        private void btnChooseImage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnAdd.PerformClick();
            }
        }
    }
}
