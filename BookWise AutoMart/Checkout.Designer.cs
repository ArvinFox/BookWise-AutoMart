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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTopic1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.butCard = new System.Windows.Forms.Button();
            this.butCash = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.lblTopic1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 635);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblTopic1
            // 
            this.lblTopic1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTopic1.AutoSize = true;
            this.lblTopic1.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblTopic1.Location = new System.Drawing.Point(113, 100);
            this.lblTopic1.Name = "lblTopic1";
            this.lblTopic1.Size = new System.Drawing.Size(779, 205);
            this.lblTopic1.TabIndex = 50;
            this.lblTopic1.Text = "Select Your Payment Method";
            this.lblTopic1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTopic1.Click += new System.EventHandler(this.lblTopic1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.butCard, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.butCash, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(93, 309);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(820, 197);
            this.tableLayoutPanel2.TabIndex = 51;
            // 
            // butCard
            // 
            this.butCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butCard.BackColor = System.Drawing.Color.White;
            this.butCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCard.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.butCard.Location = new System.Drawing.Point(413, 4);
            this.butCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butCard.Name = "butCard";
            this.butCard.Size = new System.Drawing.Size(403, 189);
            this.butCard.TabIndex = 52;
            this.butCard.Text = "CARD";
            this.butCard.UseVisualStyleBackColor = false;
            this.butCard.Click += new System.EventHandler(this.butCard_Click);
            // 
            // butCash
            // 
            this.butCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.butCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCash.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCash.ForeColor = System.Drawing.Color.White;
            this.butCash.Location = new System.Drawing.Point(11, 4);
            this.butCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butCash.Name = "butCash";
            this.butCash.Size = new System.Drawing.Size(388, 189);
            this.butCash.TabIndex = 51;
            this.butCash.Text = "CASH";
            this.butCash.UseVisualStyleBackColor = false;
            this.butCash.Click += new System.EventHandler(this.butCash_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 635);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTopic1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button butCard;
        private System.Windows.Forms.Button butCash;
    }
}