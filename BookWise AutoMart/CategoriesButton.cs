using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public class CategoriesButton : Button
    {
        private static CategoriesButton currentlyClickedButton = null;  // track the currently selected button
        private PictureBox picDeleteCategory;
        private bool isAdminView = false;
        private bool isDeleteIconWhite = false;

        private string connectionString = DatabaseString.GetUserDatabase();

        public CategoriesButton(int categoryId, string category, bool isAdmin = false)
        {
            isAdminView = isAdmin;

            this.Text = category;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Blue;
            this.Dock = DockStyle.Top;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Font = new Font("Gadugi", 15, FontStyle.Bold);
            this.Height = 60;
            this.Cursor = Cursors.Hand;
            this.TabStop = true;

            if (isAdminView)
            {
                this.TextAlign = ContentAlignment.MiddleLeft;
                this.Padding = new Padding(10, 0, 0, 0);

                // Create the delete icon
                picDeleteCategory = new PictureBox();
                picDeleteCategory.Image = Properties.Resources.delete__blue_;
                picDeleteCategory.Size = new Size(19, 19);
                picDeleteCategory.SizeMode = PictureBoxSizeMode.Zoom;
                picDeleteCategory.Cursor = Cursors.Hand;
                picDeleteCategory.Visible = true;
                picDeleteCategory.Click += (sender, e) =>
                {
                    DialogResult result = MessageBox.Show($"[Category ID: {categoryId}]\nAre you sure you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DeleteItems(categoryId);
                        DeleteSubcategories(categoryId);
                        DeleteCategory(categoryId);
                    }
                };
                picDeleteCategory.MouseEnter += (sender, e) =>
                {
                    btnMouseEnter(sender, e);

                    picDeleteCategory.Image = Properties.Resources.delete__gray_;
                };
                picDeleteCategory.MouseLeave += btnMouseLeave;

                // add the delete icon to the button
                this.Controls.Add(picDeleteCategory);

                UpdateDeleteIconPosition();  // position the delete icon

                this.Resize += (sender, e) =>
                {
                    UpdateDeleteIconPosition();  // when the button is resized, reposition the delete icon
                };
            }

            this.MouseEnter += btnMouseEnter;
            this.MouseLeave += btnMouseLeave;
            this.Click += btnMouseClick;
        }

        private void UpdateDeleteIconPosition()
        {
            // Position the delete icon at the right corner of the button
            int deleteIconX = this.ClientSize.Width - picDeleteCategory.Width - 15;
            int deleteIconY = (this.ClientSize.Height - picDeleteCategory.Height) / 2;
            picDeleteCategory.Location = new Point(deleteIconX, deleteIconY);

            // deleteIconX = button width - icon width - (constant) 15 (15 --> padding right 15 pixels)
            // deleteIconY = (button height - icon height) / 2 (divide by 2 --> to center icon vertically)
        }
        private void DeleteCategory(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Categories WHERE category_id = @CategoryId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@CategoryId", id);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category deleted successfully.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AdminControlForm.btnReloadInventoryManagementForm.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Unable to delete category.", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void DeleteSubcategories(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM SubCategories WHERE subcategory_category_id = @CategoryId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@CategoryId", id);

                        connection.Open();

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting subcategories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteItems(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Items WHERE item_category_id = @CategoryId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@CategoryId", id);

                        connection.Open();

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            if (this != currentlyClickedButton)
            {
                this.BackColor = Color.Blue;
                this.ForeColor = Color.White;
            }

            if (isAdminView)
            {
                isDeleteIconWhite = true;
                picDeleteCategory.Image = Properties.Resources.delete__white_;
            }
        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
            if (this != currentlyClickedButton)
            {
                this.BackColor = Color.Transparent;
                this.ForeColor = Color.Blue;
            }

            if (isAdminView)
            {
                if (!isDeleteIconWhite || (this == currentlyClickedButton && currentlyClickedButton != null))
                {
                    isDeleteIconWhite = true;
                    picDeleteCategory.Image = Properties.Resources.delete__white_;
                }
                else
                {
                    isDeleteIconWhite = false;
                    picDeleteCategory.Image = Properties.Resources.delete__blue_;
                }
            }
        }
        private void btnMouseClick(object sender, EventArgs e)
        {
            if (currentlyClickedButton != null)
            {
                // reset the styles of the currently selected button
                currentlyClickedButton.BackColor = Color.Transparent;
                currentlyClickedButton.ForeColor = Color.Blue;
            }

            currentlyClickedButton = this;  // make the selected button as the currently selected button
            this.BackColor = Color.DodgerBlue;
            this.ForeColor = Color.White;

            if (isAdminView)
            {
                isDeleteIconWhite = true;
                picDeleteCategory.Image = Properties.Resources.delete__white_;

                // Iterate through all buttons in the form
                foreach (Control control in this.Parent.Controls)
                {
                    if (control is CategoriesButton button)
                    {
                        // Set the delete icon to blue for all buttons except the clicked button
                        if (button != this)
                        {
                            button.isDeleteIconWhite = false;
                            button.picDeleteCategory.Image = Properties.Resources.delete__blue_;
                        }
                    }
                }
            }
        }
    }
}
