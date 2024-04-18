namespace BookWise_AutoMart
{
    partial class FinalProceedFormCard
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
            this.tableLayoutPanelCard = new System.Windows.Forms.TableLayoutPanel();
            this.lblTopic1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelCard
            // 
            this.tableLayoutPanelCard.ColumnCount = 3;
            this.tableLayoutPanelCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelCard.Controls.Add(this.lblTopic1, 1, 0);
            this.tableLayoutPanelCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCard.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCard.Name = "tableLayoutPanelCard";
            this.tableLayoutPanelCard.RowCount = 1;
            this.tableLayoutPanelCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCard.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelCard.TabIndex = 0;
            // 
            // lblTopic1
            // 
            this.lblTopic1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTopic1.AutoSize = true;
            this.lblTopic1.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.lblTopic1.Location = new System.Drawing.Point(167, 105);
            this.lblTopic1.Name = "lblTopic1";
            this.lblTopic1.Size = new System.Drawing.Size(466, 240);
            this.lblTopic1.TabIndex = 52;
            this.lblTopic1.Text = "THANK YOU";
            // 
            // FinalProceedFormCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelCard);
            this.Name = "FinalProceedFormCard";
            this.Text = "FinalProceedFormCard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanelCard.ResumeLayout(false);
            this.tableLayoutPanelCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCard;
        private System.Windows.Forms.Label lblTopic1;
    }
}