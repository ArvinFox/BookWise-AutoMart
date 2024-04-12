namespace BookWise_AutoMart
{
    partial class UserPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWindow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnOffers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelCart = new System.Windows.Forms.Panel();
            this.tableLayoutPanelCart = new System.Windows.Forms.TableLayoutPanel();
            this.lblCart = new System.Windows.Forms.Label();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.ColumnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblRs = new System.Windows.Forms.Label();
            this.butPay = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelItemDisplay = new System.Windows.Forms.Panel();
            this.pnlUserButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlCategoryScroll = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelCart.SuspendLayout();
            this.tableLayoutPanelCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.pnlUserButtons.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWindow
            // 
            this.lblWindow.AutoSize = true;
            this.lblWindow.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindow.Location = new System.Drawing.Point(204, 6);
            this.lblWindow.Name = "lblWindow";
            this.lblWindow.Size = new System.Drawing.Size(378, 54);
            this.lblWindow.TabIndex = 1;
            this.lblWindow.Text = "BookWise AutoMart";
            this.lblWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblWindow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 66);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 4);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(357, 136);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(0, 0);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(357, 144);
            this.btnCategories.TabIndex = 2;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnOffers
            // 
            this.btnOffers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOffers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOffers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnOffers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOffers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffers.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOffers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffers.Location = new System.Drawing.Point(3, 733);
            this.btnOffers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOffers.Name = "btnOffers";
            this.btnOffers.Size = new System.Drawing.Size(357, 136);
            this.btnOffers.TabIndex = 2;
            this.btnOffers.Text = "Offers && Discounts";
            this.btnOffers.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 877);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(357, 136);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // panelCart
            // 
            this.panelCart.BackColor = System.Drawing.Color.White;
            this.panelCart.Controls.Add(this.tableLayoutPanelCart);
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCart.Location = new System.Drawing.Point(822, 66);
            this.panelCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(480, 1036);
            this.panelCart.TabIndex = 2;
            // 
            // tableLayoutPanelCart
            // 
            this.tableLayoutPanelCart.ColumnCount = 1;
            this.tableLayoutPanelCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCart.Controls.Add(this.lblCart, 0, 0);
            this.tableLayoutPanelCart.Controls.Add(this.dataGridViewCart, 0, 1);
            this.tableLayoutPanelCart.Controls.Add(this.pnlTotal, 0, 2);
            this.tableLayoutPanelCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCart.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCart.Name = "tableLayoutPanelCart";
            this.tableLayoutPanelCart.RowCount = 3;
            this.tableLayoutPanelCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.91892F));
            this.tableLayoutPanelCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.139F));
            this.tableLayoutPanelCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCart.Size = new System.Drawing.Size(480, 1036);
            this.tableLayoutPanelCart.TabIndex = 1;
            // 
            // lblCart
            // 
            this.lblCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(193, 27);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(94, 48);
            this.lblCart.TabIndex = 0;
            this.lblCart.Text = "Cart";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCart.ColumnHeadersHeight = 40;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnQty,
            this.ColumnId,
            this.ColumnItemName,
            this.ColumnUnitPrice,
            this.ColumnAmount});
            this.dataGridViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCart.Location = new System.Drawing.Point(3, 106);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewCart.RowTemplate.Height = 28;
            this.dataGridViewCart.Size = new System.Drawing.Size(474, 707);
            this.dataGridViewCart.TabIndex = 1;
            // 
            // ColumnQty
            // 
            this.ColumnQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnQty.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnQty.HeaderText = "Qty";
            this.ColumnQty.MinimumWidth = 8;
            this.ColumnQty.Name = "ColumnQty";
            this.ColumnQty.ReadOnly = true;
            this.ColumnQty.Width = 69;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "itemId";
            this.ColumnId.MinimumWidth = 8;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 150;
            // 
            // ColumnItemName
            // 
            this.ColumnItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColumnItemName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnItemName.HeaderText = "Item Name";
            this.ColumnItemName.MinimumWidth = 8;
            this.ColumnItemName.Name = "ColumnItemName";
            this.ColumnItemName.ReadOnly = true;
            // 
            // ColumnUnitPrice
            // 
            this.ColumnUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnUnitPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnUnitPrice.HeaderText = "Unit Price";
            this.ColumnUnitPrice.MinimumWidth = 8;
            this.ColumnUnitPrice.Name = "ColumnUnitPrice";
            this.ColumnUnitPrice.ReadOnly = true;
            this.ColumnUnitPrice.Width = 113;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnAmount.HeaderText = "Amount";
            this.ColumnAmount.MinimumWidth = 8;
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.ReadOnly = true;
            this.ColumnAmount.Width = 101;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblRs);
            this.pnlTotal.Controls.Add(this.butPay);
            this.pnlTotal.Controls.Add(this.lblAmount);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotal.Location = new System.Drawing.Point(3, 819);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(474, 214);
            this.pnlTotal.TabIndex = 2;
            // 
            // lblRs
            // 
            this.lblRs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRs.AutoSize = true;
            this.lblRs.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRs.Location = new System.Drawing.Point(251, 39);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(64, 48);
            this.lblRs.TabIndex = 4;
            this.lblRs.Text = "Rs.";
            // 
            // butPay
            // 
            this.butPay.BackColor = System.Drawing.Color.RoyalBlue;
            this.butPay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.butPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.butPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPay.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPay.ForeColor = System.Drawing.SystemColors.Control;
            this.butPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPay.Location = new System.Drawing.Point(125, 124);
            this.butPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butPay.Name = "butPay";
            this.butPay.Size = new System.Drawing.Size(253, 67);
            this.butPay.TabIndex = 3;
            this.butPay.Text = "Pay Now";
            this.butPay.UseVisualStyleBackColor = false;
            this.butPay.Click += new System.EventHandler(this.butPay_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(320, 39);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(58, 48);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "00";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(39, 39);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(112, 48);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // panelItemDisplay
            // 
            this.panelItemDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelItemDisplay.Location = new System.Drawing.Point(363, 66);
            this.panelItemDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelItemDisplay.Name = "panelItemDisplay";
            this.panelItemDisplay.Size = new System.Drawing.Size(459, 1036);
            this.panelItemDisplay.TabIndex = 3;
            // 
            // pnlUserButtons
            // 
            this.pnlUserButtons.AutoScroll = true;
            this.pnlUserButtons.Controls.Add(this.tableLayoutPanel2);
            this.pnlUserButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUserButtons.Location = new System.Drawing.Point(0, 66);
            this.pnlUserButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUserButtons.Name = "pnlUserButtons";
            this.pnlUserButtons.Padding = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.pnlUserButtons.Size = new System.Drawing.Size(363, 1036);
            this.pnlUserButtons.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnLogout, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnOffers, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnHome, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(363, 1017);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlCategoryScroll);
            this.panel3.Controls.Add(this.btnCategories);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 148);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 577);
            this.panel3.TabIndex = 0;
            // 
            // pnlCategoryScroll
            // 
            this.pnlCategoryScroll.AutoScroll = true;
            this.pnlCategoryScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategoryScroll.Location = new System.Drawing.Point(0, 144);
            this.pnlCategoryScroll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCategoryScroll.Name = "pnlCategoryScroll";
            this.pnlCategoryScroll.Size = new System.Drawing.Size(357, 433);
            this.pnlCategoryScroll.TabIndex = 3;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 1102);
            this.Controls.Add(this.panelItemDisplay);
            this.Controls.Add(this.pnlUserButtons);
            this.Controls.Add(this.panelCart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCart.ResumeLayout(false);
            this.tableLayoutPanelCart.ResumeLayout(false);
            this.tableLayoutPanelCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlUserButtons.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnOffers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelItemDisplay;
        private System.Windows.Forms.Panel pnlUserButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlCategoryScroll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCart;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.Button butPay;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
    }
}