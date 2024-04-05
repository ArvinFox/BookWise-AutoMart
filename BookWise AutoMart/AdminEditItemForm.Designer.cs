namespace BookWise_AutoMart
{
    partial class AdminEditItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxDecrementStock = new System.Windows.Forms.PictureBox();
            this.pictureBoxIncrementStock = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanelTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecrementStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncrementStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.tableLayoutPanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDecrementStock
            // 
            this.pictureBoxDecrementStock.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxDecrementStock.Image = global::BookWise_AutoMart.Properties.Resources.down;
            this.pictureBoxDecrementStock.Location = new System.Drawing.Point(475, 372);
            this.pictureBoxDecrementStock.Name = "pictureBoxDecrementStock";
            this.pictureBoxDecrementStock.Size = new System.Drawing.Size(18, 15);
            this.pictureBoxDecrementStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDecrementStock.TabIndex = 39;
            this.pictureBoxDecrementStock.TabStop = false;
            this.pictureBoxDecrementStock.Click += new System.EventHandler(this.pictureBoxDecrementStock_Click);
            this.pictureBoxDecrementStock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDecrementStock_MouseDown);
            this.pictureBoxDecrementStock.MouseEnter += new System.EventHandler(this.pictureBoxDecrementStock_MouseEnter);
            this.pictureBoxDecrementStock.MouseLeave += new System.EventHandler(this.pictureBoxDecrementStock_MouseLeave);
            this.pictureBoxDecrementStock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDecrementStock_MouseUp);
            // 
            // pictureBoxIncrementStock
            // 
            this.pictureBoxIncrementStock.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxIncrementStock.Image = global::BookWise_AutoMart.Properties.Resources.up;
            this.pictureBoxIncrementStock.Location = new System.Drawing.Point(475, 358);
            this.pictureBoxIncrementStock.Name = "pictureBoxIncrementStock";
            this.pictureBoxIncrementStock.Size = new System.Drawing.Size(18, 15);
            this.pictureBoxIncrementStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIncrementStock.TabIndex = 38;
            this.pictureBoxIncrementStock.TabStop = false;
            this.pictureBoxIncrementStock.Click += new System.EventHandler(this.pictureBoxIncrementStock_Click);
            this.pictureBoxIncrementStock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxIncrementStock_MouseDown);
            this.pictureBoxIncrementStock.MouseEnter += new System.EventHandler(this.pictureBoxIncrementStock_MouseEnter);
            this.pictureBoxIncrementStock.MouseLeave += new System.EventHandler(this.pictureBoxIncrementStock_MouseLeave);
            this.pictureBoxIncrementStock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxIncrementStock_MouseUp);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.LightGray;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.Color.Black;
            this.btnChooseImage.Location = new System.Drawing.Point(268, 594);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(159, 42);
            this.btnChooseImage.TabIndex = 37;
            this.btnChooseImage.TabStop = false;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(268, 409);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(206, 178);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 36;
            this.pictureBoxImage.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblImage.ForeColor = System.Drawing.Color.Black;
            this.lblImage.Location = new System.Drawing.Point(38, 409);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(90, 28);
            this.lblImage.TabIndex = 35;
            this.lblImage.Text = "Image:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblStock.ForeColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(38, 359);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(81, 28);
            this.lblStock.TabIndex = 34;
            this.lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.Font = new System.Drawing.Font("Gadugi", 16F);
            this.txtStock.ForeColor = System.Drawing.Color.Black;
            this.txtStock.Location = new System.Drawing.Point(268, 355);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(228, 37);
            this.txtStock.TabIndex = 33;
            this.txtStock.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(38, 309);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 28);
            this.lblPrice.TabIndex = 32;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Gadugi", 16F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(268, 305);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(228, 37);
            this.txtPrice.TabIndex = 31;
            this.txtPrice.TabStop = false;
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblItemDescription.ForeColor = System.Drawing.Color.Black;
            this.lblItemDescription.Location = new System.Drawing.Point(38, 216);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(210, 28);
            this.lblItemDescription.TabIndex = 30;
            this.lblItemDescription.Text = "Item Description:";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.BackColor = System.Drawing.Color.White;
            this.txtItemDescription.Font = new System.Drawing.Font("Gadugi", 16F);
            this.txtItemDescription.ForeColor = System.Drawing.Color.Black;
            this.txtItemDescription.Location = new System.Drawing.Point(268, 215);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(419, 73);
            this.txtItemDescription.TabIndex = 29;
            this.txtItemDescription.TabStop = false;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.Black;
            this.lblItemName.Location = new System.Drawing.Point(38, 160);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(145, 28);
            this.lblItemName.TabIndex = 28;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblId.ForeColor = System.Drawing.Color.Gray;
            this.lblId.Location = new System.Drawing.Point(263, 106);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 28);
            this.lblId.TabIndex = 27;
            this.lblId.Text = "(ID)";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.Font = new System.Drawing.Font("Gadugi", 16F);
            this.txtItemName.ForeColor = System.Drawing.Color.Black;
            this.txtItemName.Location = new System.Drawing.Point(268, 159);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(419, 37);
            this.txtItemName.TabIndex = 26;
            this.txtItemName.TabStop = false;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblItemId.ForeColor = System.Drawing.Color.Black;
            this.lblItemId.Location = new System.Drawing.Point(38, 106);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(104, 28);
            this.lblItemId.TabIndex = 25;
            this.lblItemId.Text = "Item ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(613, 678);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 61);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(150, 678);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 61);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 678);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 61);
            this.btnSave.TabIndex = 22;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanelTitle
            // 
            this.tableLayoutPanelTitle.BackColor = System.Drawing.Color.IndianRed;
            this.tableLayoutPanelTitle.ColumnCount = 1;
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTitle.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTitle.Name = "tableLayoutPanelTitle";
            this.tableLayoutPanelTitle.RowCount = 1;
            this.tableLayoutPanelTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTitle.Size = new System.Drawing.Size(754, 72);
            this.tableLayoutPanelTitle.TabIndex = 21;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(224, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Item Details";
            // 
            // AdminEditItemForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(754, 748);
            this.Controls.Add(this.pictureBoxDecrementStock);
            this.Controls.Add(this.pictureBoxIncrementStock);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tableLayoutPanelTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdminEditItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEditItemForm";
            this.Load += new System.EventHandler(this.AdminEditItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecrementStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncrementStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.tableLayoutPanelTitle.ResumeLayout(false);
            this.tableLayoutPanelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDecrementStock;
        private System.Windows.Forms.PictureBox pictureBoxIncrementStock;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}