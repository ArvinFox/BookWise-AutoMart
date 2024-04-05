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
            this.pnlFilterSearch = new System.Windows.Forms.Panel();
            this.flowLayoutPanelDisplayItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCategoriesMenu.SuspendLayout();
            this.pnlAddNewCategory.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.tableLayoutPanelCategories.SuspendLayout();
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
            this.lblCategories.ForeColor = System.Drawing.Color.White;
            this.lblCategories.Location = new System.Drawing.Point(39, 16);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(209, 38);
            this.lblCategories.TabIndex = 1;
            this.lblCategories.Text = "CATEGORIES";
            // 
            // pnlFilterSearch
            // 
            this.pnlFilterSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlFilterSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterSearch.Location = new System.Drawing.Point(287, 0);
            this.pnlFilterSearch.Name = "pnlFilterSearch";
            this.pnlFilterSearch.Size = new System.Drawing.Size(993, 70);
            this.pnlFilterSearch.TabIndex = 5;
            // 
            // flowLayoutPanelDisplayItems
            // 
            this.flowLayoutPanelDisplayItems.AutoScroll = true;
            this.flowLayoutPanelDisplayItems.AutoSize = true;
            this.flowLayoutPanelDisplayItems.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanelDisplayItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDisplayItems.Location = new System.Drawing.Point(287, 70);
            this.flowLayoutPanelDisplayItems.Name = "flowLayoutPanelDisplayItems";
            this.flowLayoutPanelDisplayItems.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanelDisplayItems.Size = new System.Drawing.Size(993, 620);
            this.flowLayoutPanelDisplayItems.TabIndex = 6;
            // 
            // UserControlInventoryManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanelDisplayItems);
            this.Controls.Add(this.pnlFilterSearch);
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
        private System.Windows.Forms.Panel pnlFilterSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDisplayItems;
    }
}
