namespace BookWise_AutoMart
{
    partial class UserControlInventoryManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCategoriesMenu = new System.Windows.Forms.Panel();
            this.pnlDisplayCategories = new System.Windows.Forms.Panel();
            this.pnlAddNewCategory = new System.Windows.Forms.Panel();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.tableLayoutPanelCategories = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategories = new System.Windows.Forms.Label();
            this.tableLayoutPanelFunctionalities = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectedCategory = new System.Windows.Forms.Label();
            this.tableLayoutPanelFilterSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.comboBoxFilterCategories = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelDisplayItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCategoriesMenu.SuspendLayout();
            this.pnlAddNewCategory.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.tableLayoutPanelCategories.SuspendLayout();
            this.tableLayoutPanelFunctionalities.SuspendLayout();
            this.tableLayoutPanelFilterSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategoriesMenu
            // 
            this.pnlCategoriesMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlCategoriesMenu.Controls.Add(this.pnlDisplayCategories);
            this.pnlCategoriesMenu.Controls.Add(this.pnlAddNewCategory);
            this.pnlCategoriesMenu.Controls.Add(this.pnlCategories);
            this.pnlCategoriesMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCategoriesMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlCategoriesMenu.Name = "pnlCategoriesMenu";
            this.pnlCategoriesMenu.Size = new System.Drawing.Size(287, 690);
            this.pnlCategoriesMenu.TabIndex = 4;
            // 
            // pnlDisplayCategories
            // 
            this.pnlDisplayCategories.AutoScroll = true;
            this.pnlDisplayCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplayCategories.Location = new System.Drawing.Point(0, 70);
            this.pnlDisplayCategories.Name = "pnlDisplayCategories";
            this.pnlDisplayCategories.Size = new System.Drawing.Size(287, 550);
            this.pnlDisplayCategories.TabIndex = 1;
            // 
            // pnlAddNewCategory
            // 
            this.pnlAddNewCategory.Controls.Add(this.btnAddNewCategory);
            this.pnlAddNewCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddNewCategory.Location = new System.Drawing.Point(0, 620);
            this.pnlAddNewCategory.Name = "pnlAddNewCategory";
            this.pnlAddNewCategory.Size = new System.Drawing.Size(287, 70);
            this.pnlAddNewCategory.TabIndex = 1;
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddNewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewCategory.FlatAppearance.BorderSize = 0;
            this.btnAddNewCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCategory.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCategory.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddNewCategory.Image = global::BookWise_AutoMart.Properties.Resources.add_new_item__blue_;
            this.btnAddNewCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCategory.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(287, 70);
            this.btnAddNewCategory.TabIndex = 1;
            this.btnAddNewCategory.Text = "Add Category";
            this.btnAddNewCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddNewCategory.UseVisualStyleBackColor = false;
            this.btnAddNewCategory.MouseEnter += new System.EventHandler(this.btnAddNewCategory_MouseEnter);
            this.btnAddNewCategory.MouseLeave += new System.EventHandler(this.btnAddNewCategory_MouseLeave);
            // 
            // pnlCategories
            // 
            this.pnlCategories.Controls.Add(this.tableLayoutPanelCategories);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategories.Location = new System.Drawing.Point(0, 0);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(287, 70);
            this.pnlCategories.TabIndex = 0;
            // 
            // tableLayoutPanelCategories
            // 
            this.tableLayoutPanelCategories.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanelCategories.ColumnCount = 1;
            this.tableLayoutPanelCategories.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCategories.Controls.Add(this.lblCategories, 0, 0);
            this.tableLayoutPanelCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCategories.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCategories.Name = "tableLayoutPanelCategories";
            this.tableLayoutPanelCategories.RowCount = 1;
            this.tableLayoutPanelCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCategories.Size = new System.Drawing.Size(287, 70);
            this.tableLayoutPanelCategories.TabIndex = 0;
            // 
            // lblCategories
            // 
            this.lblCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Gadugi", 19F, System.Drawing.FontStyle.Bold);
            this.lblCategories.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategories.Location = new System.Drawing.Point(39, 16);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(209, 38);
            this.lblCategories.TabIndex = 1;
            this.lblCategories.Text = "CATEGORIES";
            // 
            // tableLayoutPanelFunctionalities
            // 
            this.tableLayoutPanelFunctionalities.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanelFunctionalities.ColumnCount = 2;
            this.tableLayoutPanelFunctionalities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelFunctionalities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelFunctionalities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFunctionalities.Controls.Add(this.lblSelectedCategory, 0, 0);
            this.tableLayoutPanelFunctionalities.Controls.Add(this.tableLayoutPanelFilterSearch, 1, 0);
            this.tableLayoutPanelFunctionalities.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelFunctionalities.Location = new System.Drawing.Point(287, 0);
            this.tableLayoutPanelFunctionalities.Name = "tableLayoutPanelFunctionalities";
            this.tableLayoutPanelFunctionalities.RowCount = 1;
            this.tableLayoutPanelFunctionalities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFunctionalities.Size = new System.Drawing.Size(993, 70);
            this.tableLayoutPanelFunctionalities.TabIndex = 5;
            // 
            // lblSelectedCategory
            // 
            this.lblSelectedCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectedCategory.AutoSize = true;
            this.lblSelectedCategory.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold);
            this.lblSelectedCategory.ForeColor = System.Drawing.Color.White;
            this.lblSelectedCategory.Location = new System.Drawing.Point(19, 19);
            this.lblSelectedCategory.Name = "lblSelectedCategory";
            this.lblSelectedCategory.Size = new System.Drawing.Size(159, 32);
            this.lblSelectedCategory.TabIndex = 0;
            this.lblSelectedCategory.Text = " (Category)";
            this.lblSelectedCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelFilterSearch
            // 
            this.tableLayoutPanelFilterSearch.ColumnCount = 4;
            this.tableLayoutPanelFilterSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.54626F));
            this.tableLayoutPanelFilterSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.34854F));
            this.tableLayoutPanelFilterSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.22307F));
            this.tableLayoutPanelFilterSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.75539F));
            this.tableLayoutPanelFilterSearch.Controls.Add(this.txtSearchBar, 3, 0);
            this.tableLayoutPanelFilterSearch.Controls.Add(this.lblSearch, 2, 0);
            this.tableLayoutPanelFilterSearch.Controls.Add(this.lblFilter, 0, 0);
            this.tableLayoutPanelFilterSearch.Controls.Add(this.comboBoxFilterCategories, 1, 0);
            this.tableLayoutPanelFilterSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFilterSearch.Location = new System.Drawing.Point(201, 3);
            this.tableLayoutPanelFilterSearch.Name = "tableLayoutPanelFilterSearch";
            this.tableLayoutPanelFilterSearch.RowCount = 1;
            this.tableLayoutPanelFilterSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFilterSearch.Size = new System.Drawing.Size(789, 64);
            this.tableLayoutPanelFilterSearch.TabIndex = 1;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBar.Font = new System.Drawing.Font("Gadugi", 14F);
            this.txtSearchBar.Location = new System.Drawing.Point(501, 15);
            this.txtSearchBar.MaximumSize = new System.Drawing.Size(280, 0);
            this.txtSearchBar.Multiline = true;
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(280, 34);
            this.txtSearchBar.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSearch.Location = new System.Drawing.Point(400, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(95, 27);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search: ";
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFilter.Location = new System.Drawing.Point(55, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(112, 27);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter by: ";
            // 
            // comboBoxFilterCategories
            // 
            this.comboBoxFilterCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFilterCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFilterCategories.FormattingEnabled = true;
            this.comboBoxFilterCategories.Location = new System.Drawing.Point(173, 20);
            this.comboBoxFilterCategories.MaxDropDownItems = 20;
            this.comboBoxFilterCategories.Name = "comboBoxFilterCategories";
            this.comboBoxFilterCategories.Size = new System.Drawing.Size(194, 32);
            this.comboBoxFilterCategories.TabIndex = 1;
            this.comboBoxFilterCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterCategories_SelectedIndexChanged);
            // 
            // flowLayoutPanelDisplayItems
            // 
            this.flowLayoutPanelDisplayItems.AutoScroll = true;
            this.flowLayoutPanelDisplayItems.AutoSize = true;
            this.flowLayoutPanelDisplayItems.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanelDisplayItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDisplayItems.Location = new System.Drawing.Point(287, 70);
            this.flowLayoutPanelDisplayItems.Name = "flowLayoutPanelDisplayItems";
            this.flowLayoutPanelDisplayItems.Size = new System.Drawing.Size(993, 620);
            this.flowLayoutPanelDisplayItems.TabIndex = 6;
            // 
            // UserControlInventoryManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanelDisplayItems);
            this.Controls.Add(this.tableLayoutPanelFunctionalities);
            this.Controls.Add(this.pnlCategoriesMenu);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlInventoryManagement";
            this.Size = new System.Drawing.Size(1280, 690);
            this.ParentChanged += new System.EventHandler(this.UserControlInventoryManagement_ParentChanged);
            this.pnlCategoriesMenu.ResumeLayout(false);
            this.pnlAddNewCategory.ResumeLayout(false);
            this.pnlCategories.ResumeLayout(false);
            this.tableLayoutPanelCategories.ResumeLayout(false);
            this.tableLayoutPanelCategories.PerformLayout();
            this.tableLayoutPanelFunctionalities.ResumeLayout(false);
            this.tableLayoutPanelFunctionalities.PerformLayout();
            this.tableLayoutPanelFilterSearch.ResumeLayout(false);
            this.tableLayoutPanelFilterSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategoriesMenu;
        private System.Windows.Forms.Panel pnlDisplayCategories;
        private System.Windows.Forms.Panel pnlAddNewCategory;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFunctionalities;
        private System.Windows.Forms.Label lblSelectedCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDisplayItems;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox comboBoxFilterCategories;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilterSearch;
    }
}
