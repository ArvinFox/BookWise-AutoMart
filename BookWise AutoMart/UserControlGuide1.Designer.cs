namespace BookWise_AutoMart
{
    partial class UserControlGuide1
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
            this.tblGuideBorder = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGuideContainer = new System.Windows.Forms.Panel();
            this.pictureBoxGuide1 = new System.Windows.Forms.PictureBox();
            this.tblGuideBorder.SuspendLayout();
            this.pnlGuideContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuide1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblGuideBorder
            // 
            this.tblGuideBorder.BackColor = System.Drawing.Color.DodgerBlue;
            this.tblGuideBorder.ColumnCount = 3;
            this.tblGuideBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tblGuideBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGuideBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tblGuideBorder.Controls.Add(this.pnlGuideContainer, 1, 1);
            this.tblGuideBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGuideBorder.Location = new System.Drawing.Point(0, 0);
            this.tblGuideBorder.Name = "tblGuideBorder";
            this.tblGuideBorder.RowCount = 3;
            this.tblGuideBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tblGuideBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGuideBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tblGuideBorder.Size = new System.Drawing.Size(532, 676);
            this.tblGuideBorder.TabIndex = 0;
            // 
            // pnlGuideContainer
            // 
            this.pnlGuideContainer.BackColor = System.Drawing.Color.White;
            this.pnlGuideContainer.Controls.Add(this.pictureBoxGuide1);
            this.pnlGuideContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGuideContainer.Location = new System.Drawing.Point(7, 7);
            this.pnlGuideContainer.Name = "pnlGuideContainer";
            this.pnlGuideContainer.Size = new System.Drawing.Size(518, 662);
            this.pnlGuideContainer.TabIndex = 0;
            // 
            // pictureBoxGuide1
            // 
            this.pictureBoxGuide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGuide1.Image = global::BookWise_AutoMart.Properties.Resources.Guide_Categories;
            this.pictureBoxGuide1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGuide1.Name = "pictureBoxGuide1";
            this.pictureBoxGuide1.Size = new System.Drawing.Size(518, 662);
            this.pictureBoxGuide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGuide1.TabIndex = 0;
            this.pictureBoxGuide1.TabStop = false;
            // 
            // UserControlGuide1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblGuideBorder);
            this.Name = "UserControlGuide1";
            this.Size = new System.Drawing.Size(532, 676);
            this.ParentChanged += new System.EventHandler(this.UserControlGuide1_ParentChanged);
            this.tblGuideBorder.ResumeLayout(false);
            this.pnlGuideContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuide1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblGuideBorder;
        private System.Windows.Forms.Panel pnlGuideContainer;
        private System.Windows.Forms.PictureBox pictureBoxGuide1;
    }
}
