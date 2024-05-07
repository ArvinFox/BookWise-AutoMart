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
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAddNewButtons = new System.Windows.Forms.TableLayoutPanel();
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
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.pnlButtonsContainer = new System.Windows.Forms.Panel();
            this.tblButtonsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.flowLayoutPanelDisplayItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCategoriesMenu.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.tableLayoutPanelAddNewButtons.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.tableLayoutPanelCategories.SuspendLayout();
            this.tableLayoutPanelFunctionalities.SuspendLayout();
            this.tableLayoutPanelFilterSearch.SuspendLayout();
            this.pnlButtonsContainer.SuspendLayout();
            this.tblButtonsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategoriesMenu
            // 
            this.pnlCategoriesMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlCategoriesMenu.Controls.Add(this.pnlDisplayCategories);
            this.pnlCategoriesMenu.Controls.Add(this.pnlAdd);
            this.pnlCategoriesMenu.Controls.Add(this.pnlCategories);
            this.pnlCategoriesMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCategoriesMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlCategoriesMenu.Name = "pnlCategoriesMenu";
            this.pnlCategoriesMenu.Size = new System.Drawing.Size(287, 684);
            this.pnlCategoriesMenu.TabIndex = 10;
            // 
            // pnlDisplayCategories
            // 
            this.pnlDisplayCategories.AutoScroll = true;
            this.pnlDisplayCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplayCategories.Location = new System.Drawing.Point(0, 70);
            this.pnlDisplayCategories.Name = "pnlDisplayCategories";
            this.pnlDisplayCategories.Size = new System.Drawing.Size(287, 474);
            this.pnlDisplayCategories.TabIndex = 1;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.tableLayoutPanelAddNewButtons);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdd.Location = new System.Drawing.Point(0, 544);
            this.pnlAdd.MaximumSize = new System.Drawing.Size(0, 140);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(287, 140);
            this.pnlAdd.TabIndex = 1;
            // 
            // tableLayoutPanelAddNewButtons
            // 
            this.tableLayoutPanelAddNewButtons.ColumnCount = 1;
            this.tableLayoutPanelAddNewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddNewButtons.Controls.Add(this.btnAddNewCategory, 0, 1);
            this.tableLayoutPanelAddNewButtons.Controls.Add(this.btnAddNewItem, 0, 0);
            this.tableLayoutPanelAddNewButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAddNewButtons.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAddNewButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelAddNewButtons.Name = "tableLayoutPanelAddNewButtons";
            this.tableLayoutPanelAddNewButtons.RowCount = 2;
            this.tableLayoutPanelAddNewButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddNewButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddNewButtons.Size = new System.Drawing.Size(287, 140);
            this.tableLayoutPanelAddNewButtons.TabIndex = 0;
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
            this.tableLayoutPanelFunctionalities.Size = new System.Drawing.Size(970, 70);
            this.tableLayoutPanelFunctionalities.TabIndex = 14;
            // 
            // lblSelectedCategory
            // 
            this.lblSelectedCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectedCategory.AutoSize = true;
            this.lblSelectedCategory.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold);
            this.lblSelectedCategory.ForeColor = System.Drawing.Color.White;
            this.lblSelectedCategory.Location = new System.Drawing.Point(17, 19);
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
            this.tableLayoutPanelFilterSearch.Location = new System.Drawing.Point(197, 3);
            this.tableLayoutPanelFilterSearch.Name = "tableLayoutPanelFilterSearch";
            this.tableLayoutPanelFilterSearch.RowCount = 1;
            this.tableLayoutPanelFilterSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFilterSearch.Size = new System.Drawing.Size(770, 64);
            this.tableLayoutPanelFilterSearch.TabIndex = 1;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBar.Font = new System.Drawing.Font("Gadugi", 14F);
            this.txtSearchBar.Location = new System.Drawing.Point(489, 15);
            this.txtSearchBar.MaximumSize = new System.Drawing.Size(280, 0);
            this.txtSearchBar.Multiline = true;
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(278, 34);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.FilteringConditionsApplied);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSearch.Location = new System.Drawing.Point(388, 18);
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
            this.lblFilter.Location = new System.Drawing.Point(51, 18);
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
            this.comboBoxFilterCategories.Location = new System.Drawing.Point(169, 16);
            this.comboBoxFilterCategories.MaxDropDownItems = 20;
            this.comboBoxFilterCategories.Name = "comboBoxFilterCategories";
            this.comboBoxFilterCategories.Size = new System.Drawing.Size(189, 32);
            this.comboBoxFilterCategories.TabIndex = 1;
            this.comboBoxFilterCategories.SelectedIndexChanged += new System.EventHandler(this.FilteringConditionsApplied);
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAddNewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewCategory.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddNewCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddNewCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCategory.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCategory.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddNewCategory.Image = global::BookWise_AutoMart.Properties.Resources.add_new_item__blue_;
            this.btnAddNewCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCategory.Location = new System.Drawing.Point(3, 73);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(281, 64);
            this.btnAddNewCategory.TabIndex = 1;
            this.btnAddNewCategory.Text = "Add Category";
            this.btnAddNewCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddNewCategory.UseVisualStyleBackColor = false;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            this.btnAddNewCategory.MouseEnter += new System.EventHandler(this.btnAddNewCategory_MouseEnter);
            this.btnAddNewCategory.MouseLeave += new System.EventHandler(this.btnAddNewCategory_MouseLeave);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddNewItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewItem.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnAddNewItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddNewItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewItem.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewItem.ForeColor = System.Drawing.Color.Navy;
            this.btnAddNewItem.Image = global::BookWise_AutoMart.Properties.Resources.add_new_item__navy_;
            this.btnAddNewItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewItem.Location = new System.Drawing.Point(3, 3);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(281, 64);
            this.btnAddNewItem.TabIndex = 2;
            this.btnAddNewItem.Text = "Add Item";
            this.btnAddNewItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddNewItem.UseVisualStyleBackColor = false;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            this.btnAddNewItem.MouseEnter += new System.EventHandler(this.btnAddNewItem_MouseEnter);
            this.btnAddNewItem.MouseLeave += new System.EventHandler(this.btnAddNewItem_MouseLeave);
            // 
            // pnlButtonsContainer
            // 
            this.pnlButtonsContainer.Controls.Add(this.tblButtonsContainer);
            this.pnlButtonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonsContainer.Location = new System.Drawing.Point(287, 605);
            this.pnlButtonsContainer.Name = "pnlButtonsContainer";
            this.pnlButtonsContainer.Size = new System.Drawing.Size(970, 79);
            this.pnlButtonsContainer.TabIndex = 16;
            // 
            // tblButtonsContainer
            // 
            this.tblButtonsContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.tblButtonsContainer.ColumnCount = 1;
            this.tblButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButtonsContainer.Controls.Add(this.btnAdminLogout, 0, 0);
            this.tblButtonsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtonsContainer.Location = new System.Drawing.Point(0, 0);
            this.tblButtonsContainer.Name = "tblButtonsContainer";
            this.tblButtonsContainer.RowCount = 1;
            this.tblButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtonsContainer.Size = new System.Drawing.Size(970, 79);
            this.tblButtonsContainer.TabIndex = 0;
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdminLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnAdminLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminLogout.FlatAppearance.BorderSize = 0;
            this.btnAdminLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogout.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btnAdminLogout.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogout.Location = new System.Drawing.Point(735, 5);
            this.btnAdminLogout.Margin = new System.Windows.Forms.Padding(3, 2, 10, 2);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(225, 68);
            this.btnAdminLogout.TabIndex = 21;
            this.btnAdminLogout.TabStop = false;
            this.btnAdminLogout.Text = "LOGOUT";
            this.btnAdminLogout.UseVisualStyleBackColor = false;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDivider.Location = new System.Drawing.Point(287, 581);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(970, 24);
            this.pnlDivider.TabIndex = 0;
            // 
            // flowLayoutPanelDisplayItems
            // 
            this.flowLayoutPanelDisplayItems.AutoScroll = true;
            this.flowLayoutPanelDisplayItems.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanelDisplayItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDisplayItems.Location = new System.Drawing.Point(287, 70);
            this.flowLayoutPanelDisplayItems.Name = "flowLayoutPanelDisplayItems";
            this.flowLayoutPanelDisplayItems.Size = new System.Drawing.Size(970, 511);
            this.flowLayoutPanelDisplayItems.TabIndex = 17;
            // 
            // UserControlInventoryManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanelDisplayItems);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.pnlButtonsContainer);
            this.Controls.Add(this.tableLayoutPanelFunctionalities);
            this.Controls.Add(this.pnlCategoriesMenu);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlInventoryManagement";
            this.Size = new System.Drawing.Size(1257, 684);
            this.ParentChanged += new System.EventHandler(this.UserControlInventoryManagement_ParentChanged);
            this.pnlCategoriesMenu.ResumeLayout(false);
            this.pnlAdd.ResumeLayout(false);
            this.tableLayoutPanelAddNewButtons.ResumeLayout(false);
            this.pnlCategories.ResumeLayout(false);
            this.tableLayoutPanelCategories.ResumeLayout(false);
            this.tableLayoutPanelCategories.PerformLayout();
            this.tableLayoutPanelFunctionalities.ResumeLayout(false);
            this.tableLayoutPanelFunctionalities.PerformLayout();
            this.tableLayoutPanelFilterSearch.ResumeLayout(false);
            this.tableLayoutPanelFilterSearch.PerformLayout();
            this.pnlButtonsContainer.ResumeLayout(false);
            this.tblButtonsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCategoriesMenu;
        private System.Windows.Forms.Panel pnlDisplayCategories;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddNewButtons;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFunctionalities;
        private System.Windows.Forms.Label lblSelectedCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilterSearch;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox comboBoxFilterCategories;
        private System.Windows.Forms.Panel pnlButtonsContainer;
        private System.Windows.Forms.TableLayoutPanel tblButtonsContainer;
        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDisplayItems;
    }
}
