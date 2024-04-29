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
            this.tblBorder = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.comboBoxSubcategories = new System.Windows.Forms.ComboBox();
            this.lblSubcategoryRequired = new System.Windows.Forms.Label();
            this.lblSubcategory = new System.Windows.Forms.Label();
            this.rtbItemDescription = new System.Windows.Forms.RichTextBox();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.lblImageRequired = new System.Windows.Forms.Label();
            this.lblStockRequired = new System.Windows.Forms.Label();
            this.lblPriceRequired = new System.Windows.Forms.Label();
            this.lblItemDescriptionRequired = new System.Windows.Forms.Label();
            this.lblItemNameRequired = new System.Windows.Forms.Label();
            this.pictureBoxDecrementStock = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.pictureBoxIncrementStock = new System.Windows.Forms.PictureBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanelTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tblBorder.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecrementStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncrementStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.tableLayoutPanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblBorder
            // 
            this.tblBorder.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tblBorder.ColumnCount = 3;
            this.tblBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblBorder.Controls.Add(this.pnlContainer, 1, 1);
            this.tblBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBorder.Location = new System.Drawing.Point(0, 0);
            this.tblBorder.Name = "tblBorder";
            this.tblBorder.RowCount = 3;
            this.tblBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblBorder.Size = new System.Drawing.Size(754, 804);
            this.tblBorder.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Controls.Add(this.comboBoxSubcategories);
            this.pnlContainer.Controls.Add(this.lblSubcategoryRequired);
            this.pnlContainer.Controls.Add(this.lblSubcategory);
            this.pnlContainer.Controls.Add(this.rtbItemDescription);
            this.pnlContainer.Controls.Add(this.lblRequiredFields);
            this.pnlContainer.Controls.Add(this.lblImageRequired);
            this.pnlContainer.Controls.Add(this.lblStockRequired);
            this.pnlContainer.Controls.Add(this.lblPriceRequired);
            this.pnlContainer.Controls.Add(this.lblItemDescriptionRequired);
            this.pnlContainer.Controls.Add(this.lblItemNameRequired);
            this.pnlContainer.Controls.Add(this.pictureBoxDecrementStock);
            this.pnlContainer.Controls.Add(this.btnChooseImage);
            this.pnlContainer.Controls.Add(this.pictureBoxIncrementStock);
            this.pnlContainer.Controls.Add(this.pictureBoxImage);
            this.pnlContainer.Controls.Add(this.lblImage);
            this.pnlContainer.Controls.Add(this.lblStock);
            this.pnlContainer.Controls.Add(this.txtStock);
            this.pnlContainer.Controls.Add(this.lblPrice);
            this.pnlContainer.Controls.Add(this.txtPrice);
            this.pnlContainer.Controls.Add(this.lblItemDescription);
            this.pnlContainer.Controls.Add(this.lblItemName);
            this.pnlContainer.Controls.Add(this.lblId);
            this.pnlContainer.Controls.Add(this.txtItemName);
            this.pnlContainer.Controls.Add(this.lblItemId);
            this.pnlContainer.Controls.Add(this.btnCancel);
            this.pnlContainer.Controls.Add(this.btnDelete);
            this.pnlContainer.Controls.Add(this.btnSave);
            this.pnlContainer.Controls.Add(this.tableLayoutPanelTitle);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(6, 6);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(742, 792);
            this.pnlContainer.TabIndex = 0;
            // 
            // comboBoxSubcategories
            // 
            this.comboBoxSubcategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSubcategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubcategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubcategories.Font = new System.Drawing.Font("Gadugi", 15F);
            this.comboBoxSubcategories.FormattingEnabled = true;
            this.comboBoxSubcategories.Location = new System.Drawing.Point(263, 298);
            this.comboBoxSubcategories.MaxDropDownItems = 20;
            this.comboBoxSubcategories.Name = "comboBoxSubcategories";
            this.comboBoxSubcategories.Size = new System.Drawing.Size(228, 37);
            this.comboBoxSubcategories.TabIndex = 81;
            // 
            // lblSubcategoryRequired
            // 
            this.lblSubcategoryRequired.AutoSize = true;
            this.lblSubcategoryRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblSubcategoryRequired.ForeColor = System.Drawing.Color.Red;
            this.lblSubcategoryRequired.Location = new System.Drawing.Point(497, 298);
            this.lblSubcategoryRequired.Name = "lblSubcategoryRequired";
            this.lblSubcategoryRequired.Size = new System.Drawing.Size(22, 28);
            this.lblSubcategoryRequired.TabIndex = 78;
            this.lblSubcategoryRequired.Text = "*";
            this.lblSubcategoryRequired.Visible = false;
            // 
            // lblSubcategory
            // 
            this.lblSubcategory.AutoSize = true;
            this.lblSubcategory.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblSubcategory.ForeColor = System.Drawing.Color.Black;
            this.lblSubcategory.Location = new System.Drawing.Point(33, 303);
            this.lblSubcategory.Name = "lblSubcategory";
            this.lblSubcategory.Size = new System.Drawing.Size(162, 28);
            this.lblSubcategory.TabIndex = 77;
            this.lblSubcategory.Text = "Subcategory:";
            // 
            // rtbItemDescription
            // 
            this.rtbItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbItemDescription.Font = new System.Drawing.Font("Gadugi", 15F);
            this.rtbItemDescription.Location = new System.Drawing.Point(263, 207);
            this.rtbItemDescription.Name = "rtbItemDescription";
            this.rtbItemDescription.Size = new System.Drawing.Size(419, 73);
            this.rtbItemDescription.TabIndex = 71;
            this.rtbItemDescription.Text = "";
            this.rtbItemDescription.TextChanged += new System.EventHandler(this.rtbItemDescription_TextChanged);
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(7, 688);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(302, 28);
            this.lblRequiredFields.TabIndex = 70;
            this.lblRequiredFields.Text = "*Please fill out all the fields";
            this.lblRequiredFields.Visible = false;
            // 
            // lblImageRequired
            // 
            this.lblImageRequired.AutoSize = true;
            this.lblImageRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblImageRequired.ForeColor = System.Drawing.Color.Red;
            this.lblImageRequired.Location = new System.Drawing.Point(428, 640);
            this.lblImageRequired.Name = "lblImageRequired";
            this.lblImageRequired.Size = new System.Drawing.Size(22, 28);
            this.lblImageRequired.TabIndex = 69;
            this.lblImageRequired.Text = "*";
            this.lblImageRequired.Visible = false;
            // 
            // lblStockRequired
            // 
            this.lblStockRequired.AutoSize = true;
            this.lblStockRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblStockRequired.ForeColor = System.Drawing.Color.Red;
            this.lblStockRequired.Location = new System.Drawing.Point(497, 401);
            this.lblStockRequired.Name = "lblStockRequired";
            this.lblStockRequired.Size = new System.Drawing.Size(22, 28);
            this.lblStockRequired.TabIndex = 68;
            this.lblStockRequired.Text = "*";
            this.lblStockRequired.Visible = false;
            // 
            // lblPriceRequired
            // 
            this.lblPriceRequired.AutoSize = true;
            this.lblPriceRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblPriceRequired.ForeColor = System.Drawing.Color.Red;
            this.lblPriceRequired.Location = new System.Drawing.Point(497, 351);
            this.lblPriceRequired.Name = "lblPriceRequired";
            this.lblPriceRequired.Size = new System.Drawing.Size(22, 28);
            this.lblPriceRequired.TabIndex = 67;
            this.lblPriceRequired.Text = "*";
            this.lblPriceRequired.Visible = false;
            // 
            // lblItemDescriptionRequired
            // 
            this.lblItemDescriptionRequired.AutoSize = true;
            this.lblItemDescriptionRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblItemDescriptionRequired.ForeColor = System.Drawing.Color.Red;
            this.lblItemDescriptionRequired.Location = new System.Drawing.Point(688, 207);
            this.lblItemDescriptionRequired.Name = "lblItemDescriptionRequired";
            this.lblItemDescriptionRequired.Size = new System.Drawing.Size(22, 28);
            this.lblItemDescriptionRequired.TabIndex = 66;
            this.lblItemDescriptionRequired.Text = "*";
            this.lblItemDescriptionRequired.Visible = false;
            // 
            // lblItemNameRequired
            // 
            this.lblItemNameRequired.AutoSize = true;
            this.lblItemNameRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblItemNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblItemNameRequired.Location = new System.Drawing.Point(688, 151);
            this.lblItemNameRequired.Name = "lblItemNameRequired";
            this.lblItemNameRequired.Size = new System.Drawing.Size(22, 28);
            this.lblItemNameRequired.TabIndex = 65;
            this.lblItemNameRequired.Text = "*";
            this.lblItemNameRequired.Visible = false;
            // 
            // pictureBoxDecrementStock
            // 
            this.pictureBoxDecrementStock.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxDecrementStock.Image = global::BookWise_AutoMart.Properties.Resources.down;
            this.pictureBoxDecrementStock.Location = new System.Drawing.Point(470, 418);
            this.pictureBoxDecrementStock.Name = "pictureBoxDecrementStock";
            this.pictureBoxDecrementStock.Size = new System.Drawing.Size(18, 15);
            this.pictureBoxDecrementStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDecrementStock.TabIndex = 64;
            this.pictureBoxDecrementStock.TabStop = false;
            this.pictureBoxDecrementStock.Click += new System.EventHandler(this.pictureBoxDecrementStock_Click);
            this.pictureBoxDecrementStock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDecrementStock_MouseDown);
            this.pictureBoxDecrementStock.MouseEnter += new System.EventHandler(this.pictureBoxDecrementStock_MouseEnter);
            this.pictureBoxDecrementStock.MouseLeave += new System.EventHandler(this.pictureBoxDecrementStock_MouseLeave);
            this.pictureBoxDecrementStock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDecrementStock_MouseUp);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.LightGray;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.Color.Black;
            this.btnChooseImage.Location = new System.Drawing.Point(263, 640);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(159, 42);
            this.btnChooseImage.TabIndex = 62;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // pictureBoxIncrementStock
            // 
            this.pictureBoxIncrementStock.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxIncrementStock.Image = global::BookWise_AutoMart.Properties.Resources.up;
            this.pictureBoxIncrementStock.Location = new System.Drawing.Point(470, 404);
            this.pictureBoxIncrementStock.Name = "pictureBoxIncrementStock";
            this.pictureBoxIncrementStock.Size = new System.Drawing.Size(18, 15);
            this.pictureBoxIncrementStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIncrementStock.TabIndex = 63;
            this.pictureBoxIncrementStock.TabStop = false;
            this.pictureBoxIncrementStock.Click += new System.EventHandler(this.pictureBoxIncrementStock_Click);
            this.pictureBoxIncrementStock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxIncrementStock_MouseDown);
            this.pictureBoxIncrementStock.MouseEnter += new System.EventHandler(this.pictureBoxIncrementStock_MouseEnter);
            this.pictureBoxIncrementStock.MouseLeave += new System.EventHandler(this.pictureBoxIncrementStock_MouseLeave);
            this.pictureBoxIncrementStock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxIncrementStock_MouseUp);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(263, 455);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(206, 178);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 61;
            this.pictureBoxImage.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblImage.ForeColor = System.Drawing.Color.Black;
            this.lblImage.Location = new System.Drawing.Point(33, 455);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(90, 28);
            this.lblImage.TabIndex = 60;
            this.lblImage.Text = "Image:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblStock.ForeColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(33, 405);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(81, 28);
            this.lblStock.TabIndex = 59;
            this.lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Font = new System.Drawing.Font("Gadugi", 15F);
            this.txtStock.ForeColor = System.Drawing.Color.Black;
            this.txtStock.Location = new System.Drawing.Point(263, 401);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(228, 37);
            this.txtStock.TabIndex = 58;
            this.txtStock.Text = "0";
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(33, 355);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 28);
            this.lblPrice.TabIndex = 57;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Gadugi", 15F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(263, 351);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(228, 37);
            this.txtPrice.TabIndex = 56;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblItemDescription.ForeColor = System.Drawing.Color.Black;
            this.lblItemDescription.Location = new System.Drawing.Point(33, 208);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(210, 28);
            this.lblItemDescription.TabIndex = 55;
            this.lblItemDescription.Text = "Item Description:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.Black;
            this.lblItemName.Location = new System.Drawing.Point(33, 152);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(145, 28);
            this.lblItemName.TabIndex = 54;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblId.ForeColor = System.Drawing.Color.Gray;
            this.lblId.Location = new System.Drawing.Point(258, 98);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 28);
            this.lblId.TabIndex = 53;
            this.lblId.Text = "(ID)";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemName.Font = new System.Drawing.Font("Gadugi", 15F);
            this.txtItemName.ForeColor = System.Drawing.Color.Black;
            this.txtItemName.Location = new System.Drawing.Point(263, 151);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(419, 37);
            this.txtItemName.TabIndex = 52;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblItemId.ForeColor = System.Drawing.Color.Black;
            this.lblItemId.Location = new System.Drawing.Point(33, 98);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(104, 28);
            this.lblItemId.TabIndex = 51;
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
            this.btnCancel.Location = new System.Drawing.Point(608, 724);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 61);
            this.btnCancel.TabIndex = 50;
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
            this.btnDelete.Location = new System.Drawing.Point(145, 724);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 61);
            this.btnDelete.TabIndex = 49;
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
            this.btnSave.Location = new System.Drawing.Point(7, 724);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 61);
            this.btnSave.TabIndex = 48;
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
            this.tableLayoutPanelTitle.Size = new System.Drawing.Size(742, 72);
            this.tableLayoutPanelTitle.TabIndex = 47;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(218, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Item Details";
            // 
            // AdminEditItemForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(754, 804);
            this.Controls.Add(this.tblBorder);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdminEditItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEditItemForm";
            this.Load += new System.EventHandler(this.AdminEditItemForm_Load);
            this.tblBorder.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecrementStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncrementStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.tableLayoutPanelTitle.ResumeLayout(false);
            this.tableLayoutPanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblBorder;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.RichTextBox rtbItemDescription;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lblImageRequired;
        private System.Windows.Forms.Label lblStockRequired;
        private System.Windows.Forms.Label lblPriceRequired;
        private System.Windows.Forms.Label lblItemDescriptionRequired;
        private System.Windows.Forms.Label lblItemNameRequired;
        private System.Windows.Forms.PictureBox pictureBoxDecrementStock;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox pictureBoxIncrementStock;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubcategoryRequired;
        private System.Windows.Forms.Label lblSubcategory;
        private System.Windows.Forms.ComboBox comboBoxSubcategories;
    }
}