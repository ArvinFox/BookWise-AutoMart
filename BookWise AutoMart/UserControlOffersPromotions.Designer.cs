namespace BookWise_AutoMart
{
    partial class UserControlOffersPromotions
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
            this.pnlDisplayOffers = new System.Windows.Forms.Panel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.pnlButtonsContainer = new System.Windows.Forms.Panel();
            this.tblButtonsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.btnAddNewOffer = new System.Windows.Forms.Button();
            this.pnlDisplayOffers.SuspendLayout();
            this.pnlButtonsContainer.SuspendLayout();
            this.tblButtonsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisplayOffers
            // 
            this.pnlDisplayOffers.AutoScroll = true;
            this.pnlDisplayOffers.Controls.Add(this.pnlDivider);
            this.pnlDisplayOffers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplayOffers.Location = new System.Drawing.Point(0, 0);
            this.pnlDisplayOffers.Name = "pnlDisplayOffers";
            this.pnlDisplayOffers.Size = new System.Drawing.Size(1257, 684);
            this.pnlDisplayOffers.TabIndex = 0;
            // 
            // pnlDivider
            // 
            this.pnlDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDivider.Location = new System.Drawing.Point(0, 592);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(1257, 92);
            this.pnlDivider.TabIndex = 0;
            // 
            // pnlButtonsContainer
            // 
            this.pnlButtonsContainer.Controls.Add(this.tblButtonsContainer);
            this.pnlButtonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonsContainer.Location = new System.Drawing.Point(0, 612);
            this.pnlButtonsContainer.Name = "pnlButtonsContainer";
            this.pnlButtonsContainer.Size = new System.Drawing.Size(1257, 72);
            this.pnlButtonsContainer.TabIndex = 4;
            // 
            // tblButtonsContainer
            // 
            this.tblButtonsContainer.ColumnCount = 2;
            this.tblButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tblButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtonsContainer.Controls.Add(this.btnAdminLogout, 1, 0);
            this.tblButtonsContainer.Controls.Add(this.btnAddNewOffer, 0, 0);
            this.tblButtonsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtonsContainer.Location = new System.Drawing.Point(0, 0);
            this.tblButtonsContainer.Name = "tblButtonsContainer";
            this.tblButtonsContainer.RowCount = 1;
            this.tblButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtonsContainer.Size = new System.Drawing.Size(1257, 72);
            this.tblButtonsContainer.TabIndex = 0;
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnAdminLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminLogout.FlatAppearance.BorderSize = 0;
            this.btnAdminLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogout.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btnAdminLogout.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogout.Location = new System.Drawing.Point(1024, 2);
            this.btnAdminLogout.Margin = new System.Windows.Forms.Padding(3, 2, 8, 2);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(225, 68);
            this.btnAdminLogout.TabIndex = 21;
            this.btnAdminLogout.TabStop = false;
            this.btnAdminLogout.Text = "LOGOUT";
            this.btnAdminLogout.UseVisualStyleBackColor = false;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // btnAddNewOffer
            // 
            this.btnAddNewOffer.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddNewOffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewOffer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewOffer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewOffer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnAddNewOffer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnAddNewOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewOffer.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewOffer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewOffer.Image = global::BookWise_AutoMart.Properties.Resources.add_new_item__white_;
            this.btnAddNewOffer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewOffer.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewOffer.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewOffer.Name = "btnAddNewOffer";
            this.btnAddNewOffer.Size = new System.Drawing.Size(281, 66);
            this.btnAddNewOffer.TabIndex = 3;
            this.btnAddNewOffer.Text = "Add Offer";
            this.btnAddNewOffer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewOffer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddNewOffer.UseVisualStyleBackColor = false;
            this.btnAddNewOffer.Click += new System.EventHandler(this.btnAddNewOffer_Click);
            // 
            // UserControlOffersPromotions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlButtonsContainer);
            this.Controls.Add(this.pnlDisplayOffers);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlOffersPromotions";
            this.Size = new System.Drawing.Size(1257, 684);
            this.Load += new System.EventHandler(this.UserControlOffersPromotions_Load);
            this.ParentChanged += new System.EventHandler(this.UserControlOffersPromotions_ParentChanged);
            this.pnlDisplayOffers.ResumeLayout(false);
            this.pnlButtonsContainer.ResumeLayout(false);
            this.tblButtonsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplayOffers;
        private System.Windows.Forms.Button btnAddNewOffer;
        private System.Windows.Forms.Panel pnlButtonsContainer;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.TableLayoutPanel tblButtonsContainer;
        private System.Windows.Forms.Button btnAdminLogout;
    }
}
