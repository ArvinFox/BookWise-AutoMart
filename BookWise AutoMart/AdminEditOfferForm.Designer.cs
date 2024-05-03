namespace BookWise_AutoMart
{
    partial class AdminEditOfferForm
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
            this.lblApplicableItemsError = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.pnlSelectedItems = new System.Windows.Forms.Panel();
            this.comboBoxApplicableItems = new System.Windows.Forms.ComboBox();
            this.lblOfferStatusError = new System.Windows.Forms.Label();
            this.radInactive = new System.Windows.Forms.RadioButton();
            this.radActive = new System.Windows.Forms.RadioButton();
            this.lblDisplaySelectedItemsError = new System.Windows.Forms.Label();
            this.lblEndDateError = new System.Windows.Forms.Label();
            this.lblStartDateError = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblApplicableItems = new System.Windows.Forms.Label();
            this.lblFieldsError = new System.Windows.Forms.Label();
            this.lblDiscountPercentageError = new System.Windows.Forms.Label();
            this.lblOfferNameError = new System.Windows.Forms.Label();
            this.lblDiscountPercentage = new System.Windows.Forms.Label();
            this.txtDiscountPercentage = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblOfferStartDate = new System.Windows.Forms.Label();
            this.lblOfferStatus = new System.Windows.Forms.Label();
            this.lblOfferName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtOfferName = new System.Windows.Forms.TextBox();
            this.lblOfferId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanelTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tblBorder.SuspendLayout();
            this.pnlContainer.SuspendLayout();
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
            this.tblBorder.Size = new System.Drawing.Size(754, 746);
            this.tblBorder.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Controls.Add(this.lblApplicableItemsError);
            this.pnlContainer.Controls.Add(this.btnAddItem);
            this.pnlContainer.Controls.Add(this.pnlSelectedItems);
            this.pnlContainer.Controls.Add(this.comboBoxApplicableItems);
            this.pnlContainer.Controls.Add(this.lblOfferStatusError);
            this.pnlContainer.Controls.Add(this.radInactive);
            this.pnlContainer.Controls.Add(this.radActive);
            this.pnlContainer.Controls.Add(this.lblDisplaySelectedItemsError);
            this.pnlContainer.Controls.Add(this.lblEndDateError);
            this.pnlContainer.Controls.Add(this.lblStartDateError);
            this.pnlContainer.Controls.Add(this.dtpEndDate);
            this.pnlContainer.Controls.Add(this.dtpStartDate);
            this.pnlContainer.Controls.Add(this.lblApplicableItems);
            this.pnlContainer.Controls.Add(this.lblFieldsError);
            this.pnlContainer.Controls.Add(this.lblDiscountPercentageError);
            this.pnlContainer.Controls.Add(this.lblOfferNameError);
            this.pnlContainer.Controls.Add(this.lblDiscountPercentage);
            this.pnlContainer.Controls.Add(this.txtDiscountPercentage);
            this.pnlContainer.Controls.Add(this.lblEndDate);
            this.pnlContainer.Controls.Add(this.lblOfferStartDate);
            this.pnlContainer.Controls.Add(this.lblOfferStatus);
            this.pnlContainer.Controls.Add(this.lblOfferName);
            this.pnlContainer.Controls.Add(this.lblId);
            this.pnlContainer.Controls.Add(this.txtOfferName);
            this.pnlContainer.Controls.Add(this.lblOfferId);
            this.pnlContainer.Controls.Add(this.btnCancel);
            this.pnlContainer.Controls.Add(this.btnSave);
            this.pnlContainer.Controls.Add(this.tableLayoutPanelTitle);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(6, 6);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(742, 734);
            this.pnlContainer.TabIndex = 0;
            // 
            // lblApplicableItemsError
            // 
            this.lblApplicableItemsError.AutoSize = true;
            this.lblApplicableItemsError.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblApplicableItemsError.ForeColor = System.Drawing.Color.Red;
            this.lblApplicableItemsError.Location = new System.Drawing.Point(33, 416);
            this.lblApplicableItemsError.Name = "lblApplicableItemsError";
            this.lblApplicableItemsError.Size = new System.Drawing.Size(243, 28);
            this.lblApplicableItemsError.TabIndex = 92;
            this.lblApplicableItemsError.Text = "Select an item to Add";
            this.lblApplicableItemsError.Visible = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(510, 376);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(78, 37);
            this.btnAddItem.TabIndex = 91;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // pnlSelectedItems
            // 
            this.pnlSelectedItems.AutoScroll = true;
            this.pnlSelectedItems.BackColor = System.Drawing.Color.White;
            this.pnlSelectedItems.Location = new System.Drawing.Point(271, 431);
            this.pnlSelectedItems.Name = "pnlSelectedItems";
            this.pnlSelectedItems.Size = new System.Drawing.Size(281, 145);
            this.pnlSelectedItems.TabIndex = 90;
            // 
            // comboBoxApplicableItems
            // 
            this.comboBoxApplicableItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxApplicableItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApplicableItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxApplicableItems.Font = new System.Drawing.Font("Gadugi", 15F);
            this.comboBoxApplicableItems.FormattingEnabled = true;
            this.comboBoxApplicableItems.Location = new System.Drawing.Point(271, 376);
            this.comboBoxApplicableItems.MaxDropDownItems = 20;
            this.comboBoxApplicableItems.Name = "comboBoxApplicableItems";
            this.comboBoxApplicableItems.Size = new System.Drawing.Size(228, 37);
            this.comboBoxApplicableItems.TabIndex = 89;
            this.comboBoxApplicableItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxApplicableItems_SelectedIndexChanged);
            this.comboBoxApplicableItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxApplicableItems_KeyPress);
            // 
            // lblOfferStatusError
            // 
            this.lblOfferStatusError.AutoSize = true;
            this.lblOfferStatusError.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblOfferStatusError.ForeColor = System.Drawing.Color.Red;
            this.lblOfferStatusError.Location = new System.Drawing.Point(505, 600);
            this.lblOfferStatusError.Name = "lblOfferStatusError";
            this.lblOfferStatusError.Size = new System.Drawing.Size(22, 28);
            this.lblOfferStatusError.TabIndex = 88;
            this.lblOfferStatusError.Text = "*";
            this.lblOfferStatusError.Visible = false;
            // 
            // radInactive
            // 
            this.radInactive.AutoSize = true;
            this.radInactive.Location = new System.Drawing.Point(383, 600);
            this.radInactive.Name = "radInactive";
            this.radInactive.Size = new System.Drawing.Size(98, 28);
            this.radInactive.TabIndex = 87;
            this.radInactive.TabStop = true;
            this.radInactive.Text = "Inactive";
            this.radInactive.UseVisualStyleBackColor = true;
            this.radInactive.CheckedChanged += new System.EventHandler(this.radInactive_CheckedChanged);
            this.radInactive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radInactive_KeyPress);
            // 
            // radActive
            // 
            this.radActive.AutoSize = true;
            this.radActive.Location = new System.Drawing.Point(271, 600);
            this.radActive.Name = "radActive";
            this.radActive.Size = new System.Drawing.Size(85, 28);
            this.radActive.TabIndex = 86;
            this.radActive.TabStop = true;
            this.radActive.Text = "Active";
            this.radActive.UseVisualStyleBackColor = true;
            this.radActive.CheckedChanged += new System.EventHandler(this.radActive_CheckedChanged);
            this.radActive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radActive_KeyPress);
            // 
            // lblDisplaySelectedItemsError
            // 
            this.lblDisplaySelectedItemsError.AutoSize = true;
            this.lblDisplaySelectedItemsError.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblDisplaySelectedItemsError.ForeColor = System.Drawing.Color.Red;
            this.lblDisplaySelectedItemsError.Location = new System.Drawing.Point(558, 431);
            this.lblDisplaySelectedItemsError.Name = "lblDisplaySelectedItemsError";
            this.lblDisplaySelectedItemsError.Size = new System.Drawing.Size(22, 28);
            this.lblDisplaySelectedItemsError.TabIndex = 85;
            this.lblDisplaySelectedItemsError.Text = "*";
            this.lblDisplaySelectedItemsError.Visible = false;
            // 
            // lblEndDateError
            // 
            this.lblEndDateError.AutoSize = true;
            this.lblEndDateError.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblEndDateError.ForeColor = System.Drawing.Color.Red;
            this.lblEndDateError.Location = new System.Drawing.Point(582, 303);
            this.lblEndDateError.Name = "lblEndDateError";
            this.lblEndDateError.Size = new System.Drawing.Size(136, 28);
            this.lblEndDateError.TabIndex = 84;
            this.lblEndDateError.Text = "Invalid date";
            this.lblEndDateError.Visible = false;
            // 
            // lblStartDateError
            // 
            this.lblStartDateError.AutoSize = true;
            this.lblStartDateError.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblStartDateError.ForeColor = System.Drawing.Color.Red;
            this.lblStartDateError.Location = new System.Drawing.Point(696, 207);
            this.lblStartDateError.Name = "lblStartDateError";
            this.lblStartDateError.Size = new System.Drawing.Size(22, 28);
            this.lblStartDateError.TabIndex = 83;
            this.lblStartDateError.Text = "*";
            this.lblStartDateError.Visible = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Gadugi", 13F);
            this.dtpEndDate.Location = new System.Drawing.Point(271, 264);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(419, 36);
            this.dtpEndDate.TabIndex = 82;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            this.dtpEndDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpEndDate_KeyPress);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Gadugi", 13F);
            this.dtpStartDate.Location = new System.Drawing.Point(271, 208);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(419, 36);
            this.dtpStartDate.TabIndex = 82;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            this.dtpStartDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpStartDate_KeyPress);
            // 
            // lblApplicableItems
            // 
            this.lblApplicableItems.AutoSize = true;
            this.lblApplicableItems.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblApplicableItems.ForeColor = System.Drawing.Color.Black;
            this.lblApplicableItems.Location = new System.Drawing.Point(33, 376);
            this.lblApplicableItems.Name = "lblApplicableItems";
            this.lblApplicableItems.Size = new System.Drawing.Size(210, 28);
            this.lblApplicableItems.TabIndex = 77;
            this.lblApplicableItems.Text = "Applicable Items:";
            // 
            // lblFieldsError
            // 
            this.lblFieldsError.AutoSize = true;
            this.lblFieldsError.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblFieldsError.ForeColor = System.Drawing.Color.Red;
            this.lblFieldsError.Location = new System.Drawing.Point(7, 681);
            this.lblFieldsError.Name = "lblFieldsError";
            this.lblFieldsError.Size = new System.Drawing.Size(302, 28);
            this.lblFieldsError.TabIndex = 70;
            this.lblFieldsError.Text = "*Please fill out all the fields";
            this.lblFieldsError.Visible = false;
            // 
            // lblDiscountPercentageError
            // 
            this.lblDiscountPercentageError.AutoSize = true;
            this.lblDiscountPercentageError.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblDiscountPercentageError.ForeColor = System.Drawing.Color.Red;
            this.lblDiscountPercentageError.Location = new System.Drawing.Point(505, 319);
            this.lblDiscountPercentageError.Name = "lblDiscountPercentageError";
            this.lblDiscountPercentageError.Size = new System.Drawing.Size(22, 28);
            this.lblDiscountPercentageError.TabIndex = 67;
            this.lblDiscountPercentageError.Text = "*";
            this.lblDiscountPercentageError.Visible = false;
            // 
            // lblOfferNameError
            // 
            this.lblOfferNameError.AutoSize = true;
            this.lblOfferNameError.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblOfferNameError.ForeColor = System.Drawing.Color.Red;
            this.lblOfferNameError.Location = new System.Drawing.Point(696, 151);
            this.lblOfferNameError.Name = "lblOfferNameError";
            this.lblOfferNameError.Size = new System.Drawing.Size(22, 28);
            this.lblOfferNameError.TabIndex = 65;
            this.lblOfferNameError.Text = "*";
            this.lblOfferNameError.Visible = false;
            // 
            // lblDiscountPercentage
            // 
            this.lblDiscountPercentage.AutoSize = true;
            this.lblDiscountPercentage.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblDiscountPercentage.ForeColor = System.Drawing.Color.Black;
            this.lblDiscountPercentage.Location = new System.Drawing.Point(33, 320);
            this.lblDiscountPercentage.Name = "lblDiscountPercentage";
            this.lblDiscountPercentage.Size = new System.Drawing.Size(167, 28);
            this.lblDiscountPercentage.TabIndex = 57;
            this.lblDiscountPercentage.Text = "Discount (%):";
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.BackColor = System.Drawing.Color.White;
            this.txtDiscountPercentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscountPercentage.Font = new System.Drawing.Font("Gadugi", 15F);
            this.txtDiscountPercentage.ForeColor = System.Drawing.Color.Black;
            this.txtDiscountPercentage.Location = new System.Drawing.Point(271, 320);
            this.txtDiscountPercentage.Multiline = true;
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.Size = new System.Drawing.Size(228, 37);
            this.txtDiscountPercentage.TabIndex = 56;
            this.txtDiscountPercentage.TextChanged += new System.EventHandler(this.txtDiscountPercentage_TextChanged);
            this.txtDiscountPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountPercentage_KeyPress);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.ForeColor = System.Drawing.Color.Black;
            this.lblEndDate.Location = new System.Drawing.Point(33, 264);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(122, 28);
            this.lblEndDate.TabIndex = 55;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblOfferStartDate
            // 
            this.lblOfferStartDate.AutoSize = true;
            this.lblOfferStartDate.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblOfferStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblOfferStartDate.Location = new System.Drawing.Point(33, 208);
            this.lblOfferStartDate.Name = "lblOfferStartDate";
            this.lblOfferStartDate.Size = new System.Drawing.Size(133, 28);
            this.lblOfferStartDate.TabIndex = 55;
            this.lblOfferStartDate.Text = "Start Date:";
            // 
            // lblOfferStatus
            // 
            this.lblOfferStatus.AutoSize = true;
            this.lblOfferStatus.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblOfferStatus.ForeColor = System.Drawing.Color.Black;
            this.lblOfferStatus.Location = new System.Drawing.Point(33, 600);
            this.lblOfferStatus.Name = "lblOfferStatus";
            this.lblOfferStatus.Size = new System.Drawing.Size(155, 28);
            this.lblOfferStatus.TabIndex = 54;
            this.lblOfferStatus.Text = "Offer Status:";
            // 
            // lblOfferName
            // 
            this.lblOfferName.AutoSize = true;
            this.lblOfferName.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblOfferName.ForeColor = System.Drawing.Color.Black;
            this.lblOfferName.Location = new System.Drawing.Point(33, 152);
            this.lblOfferName.Name = "lblOfferName";
            this.lblOfferName.Size = new System.Drawing.Size(152, 28);
            this.lblOfferName.TabIndex = 54;
            this.lblOfferName.Text = "Offer Name:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblId.ForeColor = System.Drawing.Color.Gray;
            this.lblId.Location = new System.Drawing.Point(266, 98);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 28);
            this.lblId.TabIndex = 53;
            this.lblId.Text = "(ID)";
            // 
            // txtOfferName
            // 
            this.txtOfferName.BackColor = System.Drawing.Color.White;
            this.txtOfferName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOfferName.Font = new System.Drawing.Font("Gadugi", 15F);
            this.txtOfferName.ForeColor = System.Drawing.Color.Black;
            this.txtOfferName.Location = new System.Drawing.Point(271, 151);
            this.txtOfferName.Multiline = true;
            this.txtOfferName.Name = "txtOfferName";
            this.txtOfferName.Size = new System.Drawing.Size(419, 37);
            this.txtOfferName.TabIndex = 52;
            this.txtOfferName.TextChanged += new System.EventHandler(this.txtOfferName_TextChanged);
            this.txtOfferName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOfferName_KeyPress);
            // 
            // lblOfferId
            // 
            this.lblOfferId.AutoSize = true;
            this.lblOfferId.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblOfferId.ForeColor = System.Drawing.Color.Black;
            this.lblOfferId.Location = new System.Drawing.Point(33, 98);
            this.lblOfferId.Name = "lblOfferId";
            this.lblOfferId.Size = new System.Drawing.Size(111, 28);
            this.lblOfferId.TabIndex = 51;
            this.lblOfferId.Text = "Offer ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(608, 665);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 61);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(476, 665);
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
            this.lblTitle.Location = new System.Drawing.Point(212, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Offer Details";
            // 
            // AdminEditOfferForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(754, 746);
            this.Controls.Add(this.tblBorder);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdminEditOfferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEditOfferForm";
            this.Load += new System.EventHandler(this.AdminEditOfferForm_Load);
            this.tblBorder.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.tableLayoutPanelTitle.ResumeLayout(false);
            this.tableLayoutPanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblBorder;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblApplicableItems;
        private System.Windows.Forms.Label lblFieldsError;
        private System.Windows.Forms.Label lblOfferNameError;
        private System.Windows.Forms.Label lblOfferStartDate;
        private System.Windows.Forms.Label lblOfferName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtOfferName;
        private System.Windows.Forms.Label lblOfferId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblDiscountPercentageError;
        private System.Windows.Forms.Label lblDiscountPercentage;
        private System.Windows.Forms.TextBox txtDiscountPercentage;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblEndDateError;
        private System.Windows.Forms.Label lblStartDateError;
        private System.Windows.Forms.Label lblDisplaySelectedItemsError;
        private System.Windows.Forms.Label lblOfferStatus;
        private System.Windows.Forms.RadioButton radInactive;
        private System.Windows.Forms.RadioButton radActive;
        private System.Windows.Forms.Label lblOfferStatusError;
        private System.Windows.Forms.ComboBox comboBoxApplicableItems;
        private System.Windows.Forms.Panel pnlSelectedItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblApplicableItemsError;
    }
}