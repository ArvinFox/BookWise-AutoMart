using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public class DisplayItemsPanel : Panel
    {
        // Import the HideCaret function
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public DisplayItemsPanel(int itemId, string itemName, string itemDescription, decimal price, int stock, Image image)
        {
            // TableLayoutPanel to align everything in the center
            TableLayoutPanel tableLayoutPanelDisplayItem = new TableLayoutPanel();
            tableLayoutPanelDisplayItem.Dock = DockStyle.Fill;
            tableLayoutPanelDisplayItem.ColumnCount = 1;
            tableLayoutPanelDisplayItem.RowCount = 2;
            tableLayoutPanelDisplayItem.RowStyles.Add(new RowStyle(SizeType.Percent, 40));
            tableLayoutPanelDisplayItem.RowStyles.Add(new RowStyle(SizeType.Percent, 40));
            tableLayoutPanelDisplayItem.AutoSize = true;

            // PictureBox for item image
            PictureBox picBoxItemImage = new PictureBox();
            picBoxItemImage.Anchor = AnchorStyles.None;
            picBoxItemImage.Image = image;
            picBoxItemImage.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxItemImage.Size = new Size(150, 200);
            tableLayoutPanelDisplayItem.Controls.Add(picBoxItemImage, 0, 0);    // First column, first row

            // Panel to store item details
            Panel pnlItemDetails = new Panel();
            pnlItemDetails.Dock = DockStyle.Fill;
            pnlItemDetails.AutoSize = true;

            // Textbox for Item Name
            TextBox txtItemName = CreateTextBox(itemName, new Font("Gadugi", 14, FontStyle.Bold), true);

            // Textbox for Item Description
            TextBox txtItemDescription = CreateTextBox(itemDescription, new Font("Gadugi", 12), true);

            // Textbox for Item Price
            TextBox txtItemPrice = CreateTextBox("Price: Rs. " + price.ToString(), new Font("Gadugi", 12), false);

            // Textbox for Item Stock
            TextBox txtItemStock = CreateTextBox("Stock: " + stock.ToString(), new Font("Gadugi", 12), false);


            // Edit Button
            Button btnEditItem = new Button();
            btnEditItem.Text = "Edit";
            btnEditItem.FlatStyle = FlatStyle.Flat;
            btnEditItem.FlatAppearance.BorderSize = 0;
            btnEditItem.Font = new Font("Gadugi", 14, FontStyle.Bold);
            btnEditItem.BackColor = Color.DarkCyan;
            btnEditItem.ForeColor = Color.White;
            btnEditItem.TabStop = true;
            btnEditItem.Dock = DockStyle.Bottom;
            btnEditItem.Height = 40;
            btnEditItem.Cursor = Cursors.Hand;

            btnEditItem.Click += (sender, e) =>
            {
                bool adminEditItemFormFound = false;

                foreach (Form form in Application.OpenForms)
                {
                    if (form is AdminEditItemForm)
                    {
                        form.ShowDialog();
                        adminEditItemFormFound = true;
                        break;
                    }
                }

                if (!adminEditItemFormFound)
                {
                    AdminEditItemForm adminEditItemForm = new AdminEditItemForm(itemId);
                    adminEditItemForm.ShowDialog();
                }
            };

            // Add labels and edit button to details panel
            pnlItemDetails.Controls.Add(btnEditItem);
            pnlItemDetails.Controls.Add(txtItemStock);
            pnlItemDetails.Controls.Add(txtItemPrice);
            pnlItemDetails.Controls.Add(txtItemDescription);
            pnlItemDetails.Controls.Add(txtItemName);

            // Add details panel to table layout panel
            tableLayoutPanelDisplayItem.Controls.Add(pnlItemDetails, 0, 1);

            // Add table layout panel to DisplayItemsPanel
            this.Controls.Add(tableLayoutPanelDisplayItem);

            this.MinimumSize = new Size(250, 310);
            this.Margin = new Padding(20, 20, 0, 0); // Set left margin
            this.BackColor = Color.White;
            this.AutoSize = true;
        }

        // Method to create and configure text boxes
        private TextBox CreateTextBox(string text, Font font, bool adjustHeightForMultipleLines)
        {
            TextBox textBox = new TextBox();
            textBox.Text = text;
            textBox.Font = font;
            textBox.Multiline = true;
            textBox.WordWrap = true;
            textBox.ReadOnly = true;
            textBox.BackColor = Color.White;
            textBox.Dock = DockStyle.Top;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.BorderStyle = BorderStyle.None;
            textBox.GotFocus += (sender, e) =>
            {
                HideCaret(((TextBox)sender).Handle);    // To disable the blinking character (cursor) on the textbox
            };

            // Calculate the height based on the text content
            int lineHeight = TextRenderer.MeasureText("A", font).Height;
            int lines = textBox.Lines.Length;

            if (adjustHeightForMultipleLines && lines > 0)
                lines += 2; // Add 2 to the lines count for ItemName and ItemDescription

            int newHeight = lineHeight * lines;
            textBox.Height = Math.Max(newHeight, 35); // Set minimum height

            return textBox;
        }
    }
}
