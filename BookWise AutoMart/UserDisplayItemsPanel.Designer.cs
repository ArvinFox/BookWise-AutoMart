namespace BookWise_AutoMart
{
    partial class UserDisplayItemsPanel
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
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.tblCategoryNameContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.flpItemCardsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.tblFilterSearchContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxFilterSubCategories = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.tblSearchContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tblCategoryNameContainer.SuspendLayout();
            this.tblFilterSearchContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblSearchContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(241, 24);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(349, 45);
            this.txtItemName.TabIndex = 6;
            this.txtItemName.TextChanged += new System.EventHandler(this.FilteringConditionsApplied);
            // 
            // tblCategoryNameContainer
            // 
            this.tblCategoryNameContainer.BackColor = System.Drawing.SystemColors.Control;
            this.tblCategoryNameContainer.ColumnCount = 1;
            this.tblCategoryNameContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCategoryNameContainer.Controls.Add(this.lblCategoryName, 0, 0);
            this.tblCategoryNameContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCategoryNameContainer.Location = new System.Drawing.Point(0, 0);
            this.tblCategoryNameContainer.Name = "tblCategoryNameContainer";
            this.tblCategoryNameContainer.RowCount = 1;
            this.tblCategoryNameContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCategoryNameContainer.Size = new System.Drawing.Size(1164, 100);
            this.tblCategoryNameContainer.TabIndex = 11;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(373, 15);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(418, 70);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "category Name";
            this.lblCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpItemCardsContainer
            // 
            this.flpItemCardsContainer.AutoScroll = true;
            this.flpItemCardsContainer.BackColor = System.Drawing.SystemColors.Control;
            this.flpItemCardsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItemCardsContainer.Location = new System.Drawing.Point(0, 200);
            this.flpItemCardsContainer.Name = "flpItemCardsContainer";
            this.flpItemCardsContainer.Size = new System.Drawing.Size(1164, 565);
            this.flpItemCardsContainer.TabIndex = 10;
            // 
            // tblFilterSearchContainer
            // 
            this.tblFilterSearchContainer.BackColor = System.Drawing.SystemColors.Control;
            this.tblFilterSearchContainer.ColumnCount = 2;
            this.tblFilterSearchContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilterSearchContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 641F));
            this.tblFilterSearchContainer.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblFilterSearchContainer.Controls.Add(this.tblSearchContainer, 1, 0);
            this.tblFilterSearchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblFilterSearchContainer.Location = new System.Drawing.Point(0, 100);
            this.tblFilterSearchContainer.Name = "tblFilterSearchContainer";
            this.tblFilterSearchContainer.RowCount = 1;
            this.tblFilterSearchContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilterSearchContainer.Size = new System.Drawing.Size(1164, 100);
            this.tblFilterSearchContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.63779F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.36221F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxFilterSubCategories, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFilter, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 94);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // comboBoxFilterSubCategories
            // 
            this.comboBoxFilterSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFilterSubCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterSubCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFilterSubCategories.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilterSubCategories.FormattingEnabled = true;
            this.comboBoxFilterSubCategories.Location = new System.Drawing.Point(197, 24);
            this.comboBoxFilterSubCategories.MaxDropDownItems = 20;
            this.comboBoxFilterSubCategories.Name = "comboBoxFilterSubCategories";
            this.comboBoxFilterSubCategories.Size = new System.Drawing.Size(317, 46);
            this.comboBoxFilterSubCategories.TabIndex = 8;
            this.comboBoxFilterSubCategories.SelectedIndexChanged += new System.EventHandler(this.FilteringConditionsApplied);
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.Black;
            this.lblFilter.Location = new System.Drawing.Point(50, 28);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(141, 38);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Filter by: ";
            // 
            // tblSearchContainer
            // 
            this.tblSearchContainer.ColumnCount = 2;
            this.tblSearchContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.63779F));
            this.tblSearchContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.36221F));
            this.tblSearchContainer.Controls.Add(this.txtItemName, 1, 0);
            this.tblSearchContainer.Controls.Add(this.lblSearch, 0, 0);
            this.tblSearchContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearchContainer.Location = new System.Drawing.Point(526, 3);
            this.tblSearchContainer.Name = "tblSearchContainer";
            this.tblSearchContainer.RowCount = 1;
            this.tblSearchContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSearchContainer.Size = new System.Drawing.Size(635, 94);
            this.tblSearchContainer.TabIndex = 8;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(115, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(120, 38);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search :";
            // 
            // UserDisplayItemsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpItemCardsContainer);
            this.Controls.Add(this.tblFilterSearchContainer);
            this.Controls.Add(this.tblCategoryNameContainer);
            this.Name = "UserDisplayItemsPanel";
            this.Size = new System.Drawing.Size(1164, 765);
            this.Load += new System.EventHandler(this.displayItem_load);
            this.tblCategoryNameContainer.ResumeLayout(false);
            this.tblCategoryNameContainer.PerformLayout();
            this.tblFilterSearchContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblSearchContainer.ResumeLayout(false);
            this.tblSearchContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TableLayoutPanel tblCategoryNameContainer;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.FlowLayoutPanel flpItemCardsContainer;
        private System.Windows.Forms.TableLayoutPanel tblFilterSearchContainer;
        private System.Windows.Forms.TableLayoutPanel tblSearchContainer;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox comboBoxFilterSubCategories;
    }
}
