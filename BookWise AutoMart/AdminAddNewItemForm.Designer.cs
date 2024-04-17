namespace BookWise_AutoMart
{
    partial class AdminAddNewItemForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.rtbItemDescription = new System.Windows.Forms.RichTextBox();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.lblImageRequired = new System.Windows.Forms.Label();
            this.lblStockRequired = new System.Windows.Forms.Label();
            this.lblPriceRequired = new System.Windows.Forms.Label();
            this.lblItemDescriptionRequired = new System.Windows.Forms.Label();
            this.lblItemNameRequired = new System.Windows.Forms.Label();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanelTitle = new System.Windows.Forms.TableLayoutPanel();
            this.tblBorder = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.comboBoxSubCategories = new System.Windows.Forms.ComboBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.lblSubcategoryRequired = new System.Windows.Forms.Label();
            this.lblCategoryRequired = new System.Windows.Forms.Label();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pictureBoxDecrementStock = new System.Windows.Forms.PictureBox();
            this.pictureBoxIncrementStock = new System.Windows.Forms.PictureBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelTitle.SuspendLayout();
            this.tblBorder.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecrementStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncrementStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(236, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Item";
            // 
            // rtbItemDescription
            // 
            this.rtbItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbItemDescription.Font = new System.Drawing.Font("Gadugi", 15F);
            this.rtbItemDescription.Location = new System.Drawing.Point(263, 162);
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
            this.lblRequiredFields.Location = new System.Drawing.Point(7, 702);
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
            this.lblImageRequired.Location = new System.Drawing.Point(428, 652);
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
            this.lblStockRequired.Location = new System.Drawing.Point(497, 413);
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
            this.lblPriceRequired.Location = new System.Drawing.Point(497, 363);
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
            this.lblItemDescriptionRequired.Location = new System.Drawing.Point(688, 162);
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
            this.lblItemNameRequired.Location = new System.Drawing.Point(688, 106);
            this.lblItemNameRequired.Name = "lblItemNameRequired";
            this.lblItemNameRequired.Size = new System.Drawing.Size(22, 28);
            this.lblItemNameRequired.TabIndex = 65;
            this.lblItemNameRequired.Text = "*";
            this.lblItemNameRequired.Visible = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.LightGray;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.Color.Black;
            this.btnChooseImage.Location = new System.Drawing.Point(263, 652);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(159, 42);
            this.btnChooseImage.TabIndex = 62;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblImage.ForeColor = System.Drawing.Color.Black;
            this.lblImage.Location = new System.Drawing.Point(33, 467);
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
            this.lblStock.Location = new System.Drawing.Point(33, 417);
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
            this.txtStock.Location = new System.Drawing.Point(263, 413);
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
            this.lblPrice.Location = new System.Drawing.Point(33, 367);
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
            this.txtPrice.Location = new System.Drawing.Point(263, 363);
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
            this.lblItemDescription.Location = new System.Drawing.Point(33, 163);
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
            this.lblItemName.Location = new System.Drawing.Point(33, 107);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(145, 28);
            this.lblItemName.TabIndex = 54;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemName.Font = new System.Drawing.Font("Gadugi", 15F);
            this.txtItemName.ForeColor = System.Drawing.Color.Black;
            this.txtItemName.Location = new System.Drawing.Point(263, 106);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(419, 37);
            this.txtItemName.TabIndex = 52;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(608, 738);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 61);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(145, 738);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 61);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(7, 738);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 61);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.tblBorder.Size = new System.Drawing.Size(754, 818);
            this.tblBorder.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Controls.Add(this.comboBoxSubCategories);
            this.pnlContainer.Controls.Add(this.comboBoxCategories);
            this.pnlContainer.Controls.Add(this.lblSubcategoryRequired);
            this.pnlContainer.Controls.Add(this.lblCategoryRequired);
            this.pnlContainer.Controls.Add(this.lblSubCategory);
            this.pnlContainer.Controls.Add(this.lblCategory);
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
            this.pnlContainer.Controls.Add(this.txtItemName);
            this.pnlContainer.Controls.Add(this.btnCancel);
            this.pnlContainer.Controls.Add(this.btnClear);
            this.pnlContainer.Controls.Add(this.btnAdd);
            this.pnlContainer.Controls.Add(this.tableLayoutPanelTitle);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(6, 6);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(742, 806);
            this.pnlContainer.TabIndex = 0;
            // 
            // comboBoxSubCategories
            // 
            this.comboBoxSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSubCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubCategories.Font = new System.Drawing.Font("Gadugi", 15F);
            this.comboBoxSubCategories.ForeColor = System.Drawing.SystemColors.GrayText;
            this.comboBoxSubCategories.FormattingEnabled = true;
            this.comboBoxSubCategories.Location = new System.Drawing.Point(263, 307);
            this.comboBoxSubCategories.MaxDropDownItems = 20;
            this.comboBoxSubCategories.Name = "comboBoxSubCategories";
            this.comboBoxSubCategories.Size = new System.Drawing.Size(228, 37);
            this.comboBoxSubCategories.TabIndex = 76;
            this.comboBoxSubCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubCategories_SelectedIndexChanged);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategories.Font = new System.Drawing.Font("Gadugi", 15F);
            this.comboBoxCategories.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(263, 253);
            this.comboBoxCategories.MaxDropDownItems = 20;
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(228, 37);
            this.comboBoxCategories.TabIndex = 77;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // lblSubcategoryRequired
            // 
            this.lblSubcategoryRequired.AutoSize = true;
            this.lblSubcategoryRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblSubcategoryRequired.ForeColor = System.Drawing.Color.Red;
            this.lblSubcategoryRequired.Location = new System.Drawing.Point(497, 307);
            this.lblSubcategoryRequired.Name = "lblSubcategoryRequired";
            this.lblSubcategoryRequired.Size = new System.Drawing.Size(22, 28);
            this.lblSubcategoryRequired.TabIndex = 74;
            this.lblSubcategoryRequired.Text = "*";
            this.lblSubcategoryRequired.Visible = false;
            // 
            // lblCategoryRequired
            // 
            this.lblCategoryRequired.AutoSize = true;
            this.lblCategoryRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblCategoryRequired.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryRequired.Location = new System.Drawing.Point(497, 253);
            this.lblCategoryRequired.Name = "lblCategoryRequired";
            this.lblCategoryRequired.Size = new System.Drawing.Size(22, 28);
            this.lblCategoryRequired.TabIndex = 74;
            this.lblCategoryRequired.Text = "*";
            this.lblCategoryRequired.Visible = false;
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblSubCategory.ForeColor = System.Drawing.Color.Black;
            this.lblSubCategory.Location = new System.Drawing.Point(33, 312);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(162, 28);
            this.lblSubCategory.TabIndex = 73;
            this.lblSubCategory.Text = "Subcategory:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(33, 258);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(122, 28);
            this.lblCategory.TabIndex = 73;
            this.lblCategory.Text = "Category:";
            // 
            // pictureBoxDecrementStock
            // 
            this.pictureBoxDecrementStock.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxDecrementStock.Image = global::BookWise_AutoMart.Properties.Resources.down;
            this.pictureBoxDecrementStock.Location = new System.Drawing.Point(470, 430);
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
            // pictureBoxIncrementStock
            // 
            this.pictureBoxIncrementStock.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxIncrementStock.Image = global::BookWise_AutoMart.Properties.Resources.up;
            this.pictureBoxIncrementStock.Location = new System.Drawing.Point(470, 416);
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
            this.pictureBoxImage.Image = global::BookWise_AutoMart.Properties.Resources.folder__gray_;
            this.pictureBoxImage.Location = new System.Drawing.Point(263, 467);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(206, 178);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 61;
            this.pictureBoxImage.TabStop = false;
            // 
            // AdminAddNewItemForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(754, 818);
            this.Controls.Add(this.tblBorder);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdminAddNewItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAddNewItemForm";
            this.tableLayoutPanelTitle.ResumeLayout(false);
            this.tableLayoutPanelTitle.PerformLayout();
            this.tblBorder.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecrementStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncrementStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
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
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTitle;
        private System.Windows.Forms.TableLayoutPanel tblBorder;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategoryRequired;
        private System.Windows.Forms.ComboBox comboBoxSubCategories;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Label lblSubcategoryRequired;
        private System.Windows.Forms.Label lblSubCategory;
    }
}