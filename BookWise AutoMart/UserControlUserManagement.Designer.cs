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
            this.pnlLogoutButtonContainer = new System.Windows.Forms.Panel();
            this.tblButtonsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.pnlFilterSearch = new System.Windows.Forms.Panel();
            this.tableLayoutPanelFunctionalities = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFilterSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.comboBoxFilterUsers = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlUserDetails = new System.Windows.Forms.Panel();
            this.pnlLogoutButtonContainer.SuspendLayout();
            this.tblButtonsContainer.SuspendLayout();
            this.pnlFilterSearch.SuspendLayout();
            this.tableLayoutPanelFunctionalities.SuspendLayout();
            this.tableLayoutPanelFilterSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogoutButtonContainer
            // 
            this.pnlLogoutButtonContainer.Controls.Add(this.tblButtonsContainer);
            this.pnlLogoutButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLogoutButtonContainer.Location = new System.Drawing.Point(0, 542);
            this.pnlLogoutButtonContainer.Name = "pnlLogoutButtonContainer";
            this.pnlLogoutButtonContainer.Size = new System.Drawing.Size(1018, 94);
            this.pnlLogoutButtonContainer.TabIndex = 6;
            // 
            // tblButtonsContainer
            // 
            this.tblButtonsContainer.ColumnCount = 1;
            this.tblButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButtonsContainer.Controls.Add(this.btnAdminLogout, 0, 0);
            this.tblButtonsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtonsContainer.Location = new System.Drawing.Point(0, 0);
            this.tblButtonsContainer.Name = "tblButtonsContainer";
            this.tblButtonsContainer.RowCount = 1;
            this.tblButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtonsContainer.Size = new System.Drawing.Size(1018, 94);
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
            this.btnAdminLogout.Location = new System.Drawing.Point(783, 13);
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
            this.pnlDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDivider.Location = new System.Drawing.Point(0, 514);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(1018, 28);
            this.pnlDivider.TabIndex = 7;
            // 
            // pnlFilterSearch
            // 
            this.pnlFilterSearch.Controls.Add(this.tableLayoutPanelFunctionalities);
            this.pnlFilterSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterSearch.Name = "pnlFilterSearch";
            this.pnlFilterSearch.Size = new System.Drawing.Size(1018, 70);
            this.pnlFilterSearch.TabIndex = 8;
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
            this.tableLayoutPanelFunctionalities.Size = new System.Drawing.Size(1018, 70);
            this.tableLayoutPanelFunctionalities.TabIndex = 9;
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
            this.tableLayoutPanelFilterSearch.Location = new System.Drawing.Point(258, 3);
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
            this.pnlUserDetails.Size = new System.Drawing.Size(1018, 444);
            this.pnlUserDetails.TabIndex = 9;
            // 
            // UserControlUserManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlUserDetails);
            this.Controls.Add(this.pnlFilterSearch);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.pnlLogoutButtonContainer);
            this.Name = "UserControlUserManagement";
            this.Size = new System.Drawing.Size(1018, 636);
            this.ParentChanged += new System.EventHandler(this.UserControlUserManagement_ParentChanged);
            this.pnlLogoutButtonContainer.ResumeLayout(false);
            this.tblButtonsContainer.ResumeLayout(false);
            this.pnlFilterSearch.ResumeLayout(false);
            this.tableLayoutPanelFunctionalities.ResumeLayout(false);
            this.tableLayoutPanelFilterSearch.ResumeLayout(false);
            this.tableLayoutPanelFilterSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogoutButtonContainer;
        private System.Windows.Forms.TableLayoutPanel tblButtonsContainer;
        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Panel pnlFilterSearch;
        private System.Windows.Forms.Panel pnlUserDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFunctionalities;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilterSearch;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox comboBoxFilterUsers;
        private System.Windows.Forms.Label lblFilter;
    }
}
