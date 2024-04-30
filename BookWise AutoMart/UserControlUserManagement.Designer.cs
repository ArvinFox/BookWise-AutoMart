namespace BookWise_AutoMart
{
    partial class UserControlUserManagement
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
            this.tableLayoutPanelFunctionalities = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFilterSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.comboBoxFilterUsers = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlUserDetails = new System.Windows.Forms.Panel();
            this.tableLayoutPanelFunctionalities.SuspendLayout();
            this.tableLayoutPanelFilterSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelFunctionalities
            // 
            this.tableLayoutPanelFunctionalities.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanelFunctionalities.ColumnCount = 3;
            this.tableLayoutPanelFunctionalities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFunctionalities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 743F));
            this.tableLayoutPanelFunctionalities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFunctionalities.Controls.Add(this.tableLayoutPanelFilterSearch, 1, 0);
            this.tableLayoutPanelFunctionalities.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelFunctionalities.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFunctionalities.Name = "tableLayoutPanelFunctionalities";
            this.tableLayoutPanelFunctionalities.RowCount = 1;
            this.tableLayoutPanelFunctionalities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFunctionalities.Size = new System.Drawing.Size(913, 70);
            this.tableLayoutPanelFunctionalities.TabIndex = 6;
            // 
            // tableLayoutPanelFilterSearch
            // 
            this.tableLayoutPanelFilterSearch.ColumnCount = 4;
            this.tableLayoutPanelFilterSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.36543F));
            this.tableLayoutPanelFilterSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.26348F));
            this.tableLayoutPanelFilterSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanelFilterSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.97403F));
            this.tableLayoutPanelFilterSearch.Controls.Add(this.txtSearchBar, 3, 0);
            this.tableLayoutPanelFilterSearch.Controls.Add(this.lblSearch, 2, 0);
            this.tableLayoutPanelFilterSearch.Controls.Add(this.comboBoxFilterUsers, 1, 0);
            this.tableLayoutPanelFilterSearch.Controls.Add(this.lblFilter, 0, 0);
            this.tableLayoutPanelFilterSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFilterSearch.Location = new System.Drawing.Point(153, 3);
            this.tableLayoutPanelFilterSearch.Name = "tableLayoutPanelFilterSearch";
            this.tableLayoutPanelFilterSearch.RowCount = 1;
            this.tableLayoutPanelFilterSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFilterSearch.Size = new System.Drawing.Size(737, 64);
            this.tableLayoutPanelFilterSearch.TabIndex = 1;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.Location = new System.Drawing.Point(474, 15);
            this.txtSearchBar.MaximumSize = new System.Drawing.Size(280, 0);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(260, 34);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.FilteringUsers);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSearch.Location = new System.Drawing.Point(379, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 27);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search: ";
            // 
            // comboBoxFilterUsers
            // 
            this.comboBoxFilterUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFilterUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFilterUsers.FormattingEnabled = true;
            this.comboBoxFilterUsers.Location = new System.Drawing.Point(130, 20);
            this.comboBoxFilterUsers.MaxDropDownItems = 20;
            this.comboBoxFilterUsers.Name = "comboBoxFilterUsers";
            this.comboBoxFilterUsers.Size = new System.Drawing.Size(238, 24);
            this.comboBoxFilterUsers.TabIndex = 1;
            this.comboBoxFilterUsers.SelectedIndexChanged += new System.EventHandler(this.FilteringUsers);
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFilter.Location = new System.Drawing.Point(12, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(112, 27);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter by: ";
            // 
            // pnlUserDetails
            // 
            this.pnlUserDetails.AutoScroll = true;
            this.pnlUserDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserDetails.Location = new System.Drawing.Point(0, 70);
            this.pnlUserDetails.Name = "pnlUserDetails";
            this.pnlUserDetails.Padding = new System.Windows.Forms.Padding(10);
            this.pnlUserDetails.Size = new System.Drawing.Size(913, 465);
            this.pnlUserDetails.TabIndex = 7;
            // 
            // UserControlUserManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlUserDetails);
            this.Controls.Add(this.tableLayoutPanelFunctionalities);
            this.Name = "UserControlUserManagement";
            this.Size = new System.Drawing.Size(913, 535);
            this.ParentChanged += new System.EventHandler(this.UserControlUserManagement_ParentChanged);
            this.tableLayoutPanelFunctionalities.ResumeLayout(false);
            this.tableLayoutPanelFilterSearch.ResumeLayout(false);
            this.tableLayoutPanelFilterSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFunctionalities;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilterSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox comboBoxFilterUsers;
        private System.Windows.Forms.Panel pnlUserDetails;
        private System.Windows.Forms.TextBox txtSearchBar;
    }
}
