namespace BookWise_AutoMart
{
    partial class Checkout
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
            this.tlpCheckoutContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPaymentMethod = new System.Windows.Forms.Panel();
            this.tlpPaymentType = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelect = new System.Windows.Forms.Label();
            this.butCash = new System.Windows.Forms.Button();
            this.butCard = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanelCart = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.tblTotalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRs = new System.Windows.Forms.Label();
            this.tblBillHeading = new System.Windows.Forms.TableLayoutPanel();
            this.lblCart = new System.Windows.Forms.Label();
            this.tblUserName = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlBillCheckout = new System.Windows.Forms.Panel();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.tblCartHeading = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.tlpCheckoutContainer.SuspendLayout();
            this.pnlPaymentMethod.SuspendLayout();
            this.tlpPaymentType.SuspendLayout();
            this.tableLayoutPanelCart.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.tblTotalLayout.SuspendLayout();
            this.tblBillHeading.SuspendLayout();
            this.tblUserName.SuspendLayout();
            this.pnlBillCheckout.SuspendLayout();
            this.tblCartHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpCheckoutContainer
            // 
            this.tlpCheckoutContainer.ColumnCount = 5;
            this.tlpCheckoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpCheckoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.68993F));
            this.tlpCheckoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCheckoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.31007F));
            this.tlpCheckoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tlpCheckoutContainer.Controls.Add(this.pnlPaymentMethod, 3, 1);
            this.tlpCheckoutContainer.Controls.Add(this.tableLayoutPanelCart, 1, 1);
            this.tlpCheckoutContainer.Controls.Add(this.pictureBoxBack, 0, 1);
            this.tlpCheckoutContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCheckoutContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpCheckoutContainer.Name = "tlpCheckoutContainer";
            this.tlpCheckoutContainer.RowCount = 3;
            this.tlpCheckoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCheckoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCheckoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCheckoutContainer.Size = new System.Drawing.Size(1302, 1102);
            this.tlpCheckoutContainer.TabIndex = 0;
            // 
            // pnlPaymentMethod
            // 
            this.pnlPaymentMethod.Controls.Add(this.tlpPaymentType);
            this.pnlPaymentMethod.Controls.Add(this.lblMessage);
            this.pnlPaymentMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaymentMethod.Location = new System.Drawing.Point(713, 23);
            this.pnlPaymentMethod.Name = "pnlPaymentMethod";
            this.pnlPaymentMethod.Size = new System.Drawing.Size(494, 1056);
            this.pnlPaymentMethod.TabIndex = 2;
            // 
            // tlpPaymentType
            // 
            this.tlpPaymentType.ColumnCount = 1;
            this.tlpPaymentType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPaymentType.Controls.Add(this.lblSelect, 0, 1);
            this.tlpPaymentType.Controls.Add(this.butCash, 0, 2);
            this.tlpPaymentType.Controls.Add(this.butCard, 0, 3);
            this.tlpPaymentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentType.Location = new System.Drawing.Point(0, 0);
            this.tlpPaymentType.Name = "tlpPaymentType";
            this.tlpPaymentType.RowCount = 5;
            this.tlpPaymentType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpPaymentType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPaymentType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPaymentType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPaymentType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpPaymentType.Size = new System.Drawing.Size(494, 1056);
            this.tlpPaymentType.TabIndex = 0;
            // 
            // lblSelect
            // 
            this.lblSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("MS UI Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSelect.Location = new System.Drawing.Point(59, 70);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(375, 305);
            this.lblSelect.TabIndex = 51;
            this.lblSelect.Text = "Select Your Payment Method";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butCash
            // 
            this.butCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.butCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCash.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCash.ForeColor = System.Drawing.Color.White;
            this.butCash.Location = new System.Drawing.Point(79, 465);
            this.butCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butCash.Name = "butCash";
            this.butCash.Size = new System.Drawing.Size(336, 124);
            this.butCash.TabIndex = 52;
            this.butCash.Text = "CASH";
            this.butCash.UseVisualStyleBackColor = false;
            this.butCash.Click += new System.EventHandler(this.butCash_Click);
            // 
            // butCard
            // 
            this.butCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butCard.BackColor = System.Drawing.Color.White;
            this.butCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCard.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.butCard.Location = new System.Drawing.Point(79, 770);
            this.butCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butCard.Name = "butCard";
            this.butCard.Size = new System.Drawing.Size(336, 124);
            this.butCard.TabIndex = 53;
            this.butCard.Text = "CARD";
            this.butCard.UseVisualStyleBackColor = false;
            this.butCard.Click += new System.EventHandler(this.butCard_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblMessage.Location = new System.Drawing.Point(76, 459);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(397, 80);
            this.lblMessage.TabIndex = 52;
            this.lblMessage.Text = "Thank You";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // tableLayoutPanelCart
            // 
            this.tableLayoutPanelCart.ColumnCount = 1;
            this.tableLayoutPanelCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCart.Controls.Add(this.pnlTotal, 0, 2);
            this.tableLayoutPanelCart.Controls.Add(this.tblBillHeading, 0, 0);
            this.tableLayoutPanelCart.Controls.Add(this.pnlBillCheckout, 0, 1);
            this.tableLayoutPanelCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCart.Location = new System.Drawing.Point(93, 22);
            this.tableLayoutPanelCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelCart.Name = "tableLayoutPanelCart";
            this.tableLayoutPanelCart.RowCount = 3;
            this.tableLayoutPanelCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.29679F));
            this.tableLayoutPanelCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.58034F));
            this.tableLayoutPanelCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.02836F));
            this.tableLayoutPanelCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCart.Size = new System.Drawing.Size(574, 1058);
            this.tableLayoutPanelCart.TabIndex = 3;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.tblTotalLayout);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(3, 900);
            this.pnlTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(568, 156);
            this.pnlTotal.TabIndex = 2;
            // 
            // tblTotalLayout
            // 
            this.tblTotalLayout.BackColor = System.Drawing.Color.White;
            this.tblTotalLayout.ColumnCount = 3;
            this.tblTotalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblTotalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.93578F));
            this.tblTotalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.06422F));
            this.tblTotalLayout.Controls.Add(this.lblTotal, 0, 0);
            this.tblTotalLayout.Controls.Add(this.lblAmount, 2, 0);
            this.tblTotalLayout.Controls.Add(this.lblRs, 1, 0);
            this.tblTotalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTotalLayout.Location = new System.Drawing.Point(0, 0);
            this.tblTotalLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblTotalLayout.Name = "tblTotalLayout";
            this.tblTotalLayout.RowCount = 1;
            this.tblTotalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTotalLayout.Size = new System.Drawing.Size(568, 156);
            this.tblTotalLayout.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 37);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(188, 81);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semilight", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(361, 37);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(99, 81);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "00";
            // 
            // lblRs
            // 
            this.lblRs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRs.AutoSize = true;
            this.lblRs.Font = new System.Drawing.Font("Segoe UI Semilight", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRs.Location = new System.Drawing.Point(248, 37);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(107, 81);
            this.lblRs.TabIndex = 4;
            this.lblRs.Text = "Rs.";
            this.lblRs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblBillHeading
            // 
            this.tblBillHeading.ColumnCount = 1;
            this.tblBillHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBillHeading.Controls.Add(this.lblCart, 0, 0);
            this.tblBillHeading.Controls.Add(this.tblUserName, 0, 1);
            this.tblBillHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBillHeading.Location = new System.Drawing.Point(3, 3);
            this.tblBillHeading.Name = "tblBillHeading";
            this.tblBillHeading.RowCount = 3;
            this.tblBillHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.88024F));
            this.tblBillHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.11976F));
            this.tblBillHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tblBillHeading.Size = new System.Drawing.Size(568, 177);
            this.tblBillHeading.TabIndex = 3;
            // 
            // lblCart
            // 
            this.lblCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Segoe UI Black", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCart.Location = new System.Drawing.Point(92, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(383, 100);
            this.lblCart.TabIndex = 0;
            this.lblCart.Text = "BookWise AutoMart";
            // 
            // tblUserName
            // 
            this.tblUserName.ColumnCount = 2;
            this.tblUserName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tblUserName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUserName.Controls.Add(this.lblUserName, 1, 0);
            this.tblUserName.Controls.Add(this.lblName, 0, 0);
            this.tblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUserName.Location = new System.Drawing.Point(3, 103);
            this.tblUserName.Name = "tblUserName";
            this.tblUserName.RowCount = 1;
            this.tblUserName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUserName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tblUserName.Size = new System.Drawing.Size(562, 61);
            this.tblUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(218, 6);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(202, 48);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "(Username)";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(202, 48);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Customer :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBillCheckout
            // 
            this.pnlBillCheckout.Controls.Add(this.pnlBill);
            this.pnlBillCheckout.Controls.Add(this.tblCartHeading);
            this.pnlBillCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBillCheckout.Location = new System.Drawing.Point(3, 186);
            this.pnlBillCheckout.Name = "pnlBillCheckout";
            this.pnlBillCheckout.Size = new System.Drawing.Size(568, 709);
            this.pnlBillCheckout.TabIndex = 4;
            // 
            // pnlBill
            // 
            this.pnlBill.AutoScroll = true;
            this.pnlBill.BackColor = System.Drawing.Color.White;
            this.pnlBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBill.Location = new System.Drawing.Point(0, 78);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(568, 631);
            this.pnlBill.TabIndex = 6;
            // 
            // tblCartHeading
            // 
            this.tblCartHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tblCartHeading.ColumnCount = 4;
            this.tblCartHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.16695F));
            this.tblCartHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.29258F));
            this.tblCartHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.08692F));
            this.tblCartHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.58943F));
            this.tblCartHeading.Controls.Add(this.lblPrice, 3, 0);
            this.tblCartHeading.Controls.Add(this.lblUnitPrice, 2, 0);
            this.tblCartHeading.Controls.Add(this.lblItemName, 1, 0);
            this.tblCartHeading.Controls.Add(this.lblQty, 0, 0);
            this.tblCartHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCartHeading.Location = new System.Drawing.Point(0, 0);
            this.tblCartHeading.Name = "tblCartHeading";
            this.tblCartHeading.RowCount = 1;
            this.tblCartHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCartHeading.Size = new System.Drawing.Size(568, 78);
            this.tblCartHeading.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(436, 20);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(125, 38);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Amount";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(323, 1);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(81, 76);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(145, 20);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(78, 38);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQty
            // 
            this.lblQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(3, 20);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(64, 38);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "Qty";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxBack.Image = global::BookWise_AutoMart.Properties.Resources.Back_Arrow1;
            this.pictureBoxBack.Location = new System.Drawing.Point(3, 23);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(84, 102);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 4;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 1102);
            this.Controls.Add(this.tlpCheckoutContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Checkout";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpCheckoutContainer.ResumeLayout(false);
            this.pnlPaymentMethod.ResumeLayout(false);
            this.pnlPaymentMethod.PerformLayout();
            this.tlpPaymentType.ResumeLayout(false);
            this.tlpPaymentType.PerformLayout();
            this.tableLayoutPanelCart.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.tblTotalLayout.ResumeLayout(false);
            this.tblTotalLayout.PerformLayout();
            this.tblBillHeading.ResumeLayout(false);
            this.tblBillHeading.PerformLayout();
            this.tblUserName.ResumeLayout(false);
            this.tblUserName.PerformLayout();
            this.pnlBillCheckout.ResumeLayout(false);
            this.tblCartHeading.ResumeLayout(false);
            this.tblCartHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCheckoutContainer;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentType;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button butCash;
        private System.Windows.Forms.Button butCard;
        private System.Windows.Forms.Panel pnlPaymentMethod;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCart;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.TableLayoutPanel tblTotalLayout;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.TableLayoutPanel tblBillHeading;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlBillCheckout;
        private System.Windows.Forms.TableLayoutPanel tblCartHeading;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.TableLayoutPanel tblUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}