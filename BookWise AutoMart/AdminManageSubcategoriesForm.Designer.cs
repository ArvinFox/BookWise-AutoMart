namespace BookWise_AutoMart
{
    partial class AdminManageSubcategoriesForm
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
            this.lblSubcategoriesError = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblErrors = new System.Windows.Forms.Label();
            this.btnAddNewSubcategory = new System.Windows.Forms.Button();
            this.pnlSubcategories = new System.Windows.Forms.Panel();
            this.lblCategoryError = new System.Windows.Forms.Label();
            this.lblNewSubcategory = new System.Windows.Forms.Label();
            this.txtNewSubcategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
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
            this.tblBorder.Size = new System.Drawing.Size(709, 572);
            this.tblBorder.TabIndex = 3;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Controls.Add(this.lblSubcategoriesError);
            this.pnlContainer.Controls.Add(this.comboBoxCategories);
            this.pnlContainer.Controls.Add(this.btnCancel);
            this.pnlContainer.Controls.Add(this.btnSave);
            this.pnlContainer.Controls.Add(this.lblErrors);
            this.pnlContainer.Controls.Add(this.btnAddNewSubcategory);
            this.pnlContainer.Controls.Add(this.pnlSubcategories);
            this.pnlContainer.Controls.Add(this.lblCategoryError);
            this.pnlContainer.Controls.Add(this.lblNewSubcategory);
            this.pnlContainer.Controls.Add(this.txtNewSubcategory);
            this.pnlContainer.Controls.Add(this.lblCategory);
            this.pnlContainer.Controls.Add(this.tableLayoutPanelTitle);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(6, 6);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(697, 560);
            this.pnlContainer.TabIndex = 0;
            // 
            // lblSubcategoriesError
            // 
            this.lblSubcategoriesError.AutoSize = true;
            this.lblSubcategoriesError.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblSubcategoriesError.ForeColor = System.Drawing.Color.Red;
            this.lblSubcategoriesError.Location = new System.Drawing.Point(551, 218);
            this.lblSubcategoriesError.Name = "lblSubcategoriesError";
            this.lblSubcategoriesError.Size = new System.Drawing.Size(22, 28);
            this.lblSubcategoriesError.TabIndex = 99;
            this.lblSubcategoriesError.Text = "*";
            this.lblSubcategoriesError.Visible = false;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategories.Font = new System.Drawing.Font("Gadugi", 15F);
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(227, 107);
            this.comboBoxCategories.MaxDropDownItems = 20;
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(318, 37);
            this.comboBoxCategories.TabIndex = 98;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            this.comboBoxCategories.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCategories_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(563, 489);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 61);
            this.btnCancel.TabIndex = 95;
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
            this.btnSave.Location = new System.Drawing.Point(431, 489);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 61);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(23, 505);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(302, 28);
            this.lblErrors.TabIndex = 92;
            this.lblErrors.Text = "Enter a subcategory to Add";
            this.lblErrors.Visible = false;
            // 
            // btnAddNewSubcategory
            // 
            this.btnAddNewSubcategory.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAddNewSubcategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewSubcategory.FlatAppearance.BorderSize = 0;
            this.btnAddNewSubcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewSubcategory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSubcategory.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSubcategory.Location = new System.Drawing.Point(551, 163);
            this.btnAddNewSubcategory.Name = "btnAddNewSubcategory";
            this.btnAddNewSubcategory.Size = new System.Drawing.Size(78, 37);
            this.btnAddNewSubcategory.TabIndex = 91;
            this.btnAddNewSubcategory.Text = "Add";
            this.btnAddNewSubcategory.UseVisualStyleBackColor = false;
            this.btnAddNewSubcategory.Click += new System.EventHandler(this.btnAddNewSubcategory_Click);
            // 
            // pnlSubcategories
            // 
            this.pnlSubcategories.AutoScroll = true;
            this.pnlSubcategories.BackColor = System.Drawing.Color.White;
            this.pnlSubcategories.Location = new System.Drawing.Point(227, 218);
            this.pnlSubcategories.Name = "pnlSubcategories";
            this.pnlSubcategories.Size = new System.Drawing.Size(318, 239);
            this.pnlSubcategories.TabIndex = 90;
            // 
            // lblCategoryError
            // 
            this.lblCategoryError.AutoSize = true;
            this.lblCategoryError.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblCategoryError.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryError.Location = new System.Drawing.Point(551, 107);
            this.lblCategoryError.Name = "lblCategoryError";
            this.lblCategoryError.Size = new System.Drawing.Size(22, 28);
            this.lblCategoryError.TabIndex = 85;
            this.lblCategoryError.Text = "*";
            this.lblCategoryError.Visible = false;
            // 
            // lblNewSubcategory
            // 
            this.lblNewSubcategory.AutoSize = true;
            this.lblNewSubcategory.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblNewSubcategory.ForeColor = System.Drawing.Color.Black;
            this.lblNewSubcategory.Location = new System.Drawing.Point(33, 163);
            this.lblNewSubcategory.Name = "lblNewSubcategory";
            this.lblNewSubcategory.Size = new System.Drawing.Size(162, 28);
            this.lblNewSubcategory.TabIndex = 57;
            this.lblNewSubcategory.Text = "Subcategory:";
            // 
            // txtNewSubcategory
            // 
            this.txtNewSubcategory.BackColor = System.Drawing.Color.White;
            this.txtNewSubcategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewSubcategory.Font = new System.Drawing.Font("Gadugi", 15F);
            this.txtNewSubcategory.ForeColor = System.Drawing.Color.Black;
            this.txtNewSubcategory.Location = new System.Drawing.Point(227, 163);
            this.txtNewSubcategory.Multiline = true;
            this.txtNewSubcategory.Name = "txtNewSubcategory";
            this.txtNewSubcategory.Size = new System.Drawing.Size(318, 37);
            this.txtNewSubcategory.TabIndex = 56;
            this.txtNewSubcategory.TextChanged += new System.EventHandler(this.txtNewSubcategory_TextChanged);
            this.txtNewSubcategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewSubcategory_KeyPress);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(33, 107);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(122, 28);
            this.lblCategory.TabIndex = 54;
            this.lblCategory.Text = "Category:";
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
            this.tableLayoutPanelTitle.Size = new System.Drawing.Size(697, 72);
            this.tableLayoutPanelTitle.TabIndex = 47;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(141, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(415, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Subcategories";
            // 
            // AdminManageSubcategoriesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(709, 572);
            this.Controls.Add(this.tblBorder);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdminManageSubcategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManageSubcategoriesForm";
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Button btnAddNewSubcategory;
        private System.Windows.Forms.Panel pnlSubcategories;
        private System.Windows.Forms.Label lblCategoryError;
        private System.Windows.Forms.Label lblNewSubcategory;
        private System.Windows.Forms.TextBox txtNewSubcategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Label lblSubcategoriesError;
    }
}