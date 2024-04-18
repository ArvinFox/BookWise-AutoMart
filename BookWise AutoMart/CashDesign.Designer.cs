namespace BookWise_AutoMart
{
    partial class CashDesign
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
            this.tableLayoutPanelCash = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMiddlePart = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butBack = new System.Windows.Forms.Button();
            this.butProceed = new System.Windows.Forms.Button();
            this.lblTopic = new System.Windows.Forms.Label();
            this.tableLayoutPanelCash.SuspendLayout();
            this.tableLayoutPanelMiddlePart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelCash
            // 
            this.tableLayoutPanelCash.ColumnCount = 3;
            this.tableLayoutPanelCash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelCash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelCash.Controls.Add(this.tableLayoutPanelMiddlePart, 1, 2);
            this.tableLayoutPanelCash.Controls.Add(this.lblTopic, 1, 1);
            this.tableLayoutPanelCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCash.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCash.Name = "tableLayoutPanelCash";
            this.tableLayoutPanelCash.RowCount = 4;
            this.tableLayoutPanelCash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelCash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelCash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelCash.Size = new System.Drawing.Size(1058, 633);
            this.tableLayoutPanelCash.TabIndex = 0;
            // 
            // tableLayoutPanelMiddlePart
            // 
            this.tableLayoutPanelMiddlePart.ColumnCount = 3;
            this.tableLayoutPanelMiddlePart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMiddlePart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMiddlePart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMiddlePart.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanelMiddlePart.Controls.Add(this.butBack, 1, 0);
            this.tableLayoutPanelMiddlePart.Controls.Add(this.butProceed, 2, 0);
            this.tableLayoutPanelMiddlePart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMiddlePart.Location = new System.Drawing.Point(53, 191);
            this.tableLayoutPanelMiddlePart.Name = "tableLayoutPanelMiddlePart";
            this.tableLayoutPanelMiddlePart.RowCount = 1;
            this.tableLayoutPanelMiddlePart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMiddlePart.Size = new System.Drawing.Size(952, 378);
            this.tableLayoutPanelMiddlePart.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BookWise_AutoMart.Properties.Resources.Checkout_img;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butBack
            // 
            this.butBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.butBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBack.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBack.ForeColor = System.Drawing.Color.White;
            this.butBack.Location = new System.Drawing.Point(469, 100);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(230, 125);
            this.butBack.TabIndex = 52;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butProceed
            // 
            this.butProceed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butProceed.BackColor = System.Drawing.Color.White;
            this.butProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butProceed.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butProceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.butProceed.Location = new System.Drawing.Point(702, 100);
            this.butProceed.Name = "butProceed";
            this.butProceed.Size = new System.Drawing.Size(230, 125);
            this.butProceed.TabIndex = 53;
            this.butProceed.Text = "Proceed";
            this.butProceed.UseVisualStyleBackColor = false;
            this.butProceed.Click += new System.EventHandler(this.butProceed_Click);
            // 
            // lblTopic
            // 
            this.lblTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblTopic.Location = new System.Drawing.Point(112, 60);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(833, 128);
            this.lblTopic.TabIndex = 5;
            this.lblTopic.Text = "Pay at the counter and\r\n    collect your order";
            this.lblTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.Controls.Add(this.tableLayoutPanelCash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashDesign";
            this.Text = "CheckoutFormcs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanelCash.ResumeLayout(false);
            this.tableLayoutPanelCash.PerformLayout();
            this.tableLayoutPanelMiddlePart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCash;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMiddlePart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butProceed;
        private System.Windows.Forms.Label lblTopic;
    }
}