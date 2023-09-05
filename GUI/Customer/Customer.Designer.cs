namespace MSMSGUI.GUI.Main
{
    partial class Customer
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHistory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnCart = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnBestSelling = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnProducts = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnPersonalInfo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ControlBoxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(827, 538);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.ControlBoxMinimize);
            this.pnlRight.Controls.Add(this.ControlBoxClose);
            this.pnlRight.Location = new System.Drawing.Point(221, -1);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(606, 539);
            this.pnlRight.TabIndex = 20;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.btnLogOut);
            this.pnlLeft.Controls.Add(this.btnHistory);
            this.pnlLeft.Controls.Add(this.BtnCart);
            this.pnlLeft.Controls.Add(this.BtnBestSelling);
            this.pnlLeft.Controls.Add(this.BtnProducts);
            this.pnlLeft.Controls.Add(this.BtnPersonalInfo);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Location = new System.Drawing.Point(0, -1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(223, 541);
            this.pnlLeft.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Animated = true;
            this.btnLogOut.AnimatedGIF = true;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.Empty;
            this.btnLogOut.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.btnLogOut.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = global::MSMSGUI.Properties.Resources.logOut;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(22, 28);
            this.btnLogOut.Location = new System.Drawing.Point(3, 423);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(219, 47);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "  Logout";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.FillColor = System.Drawing.Color.Empty;
            this.btnHistory.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.btnHistory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Image = global::MSMSGUI.Properties.Resources.history;
            this.btnHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.ImageSize = new System.Drawing.Size(23, 28);
            this.btnHistory.Location = new System.Drawing.Point(3, 380);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(219, 47);
            this.btnHistory.TabIndex = 7;
            this.btnHistory.Text = "  History";
            this.btnHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // BtnCart
            // 
            this.BtnCart.BackColor = System.Drawing.Color.Transparent;
            this.BtnCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCart.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCart.FillColor = System.Drawing.Color.Empty;
            this.BtnCart.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.BtnCart.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.BtnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCart.ForeColor = System.Drawing.Color.Black;
            this.BtnCart.Image = global::MSMSGUI.Properties.Resources.cart;
            this.BtnCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCart.ImageSize = new System.Drawing.Size(25, 30);
            this.BtnCart.Location = new System.Drawing.Point(3, 337);
            this.BtnCart.Name = "BtnCart";
            this.BtnCart.Size = new System.Drawing.Size(219, 47);
            this.BtnCart.TabIndex = 5;
            this.BtnCart.Text = "  Cart";
            this.BtnCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCart.Click += new System.EventHandler(this.BtnCart_Click);
            // 
            // BtnBestSelling
            // 
            this.BtnBestSelling.BackColor = System.Drawing.Color.Transparent;
            this.BtnBestSelling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBestSelling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBestSelling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBestSelling.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBestSelling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBestSelling.FillColor = System.Drawing.Color.Empty;
            this.BtnBestSelling.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.BtnBestSelling.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.BtnBestSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBestSelling.ForeColor = System.Drawing.Color.Black;
            this.BtnBestSelling.Image = global::MSMSGUI.Properties.Resources.bestSelling;
            this.BtnBestSelling.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnBestSelling.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnBestSelling.Location = new System.Drawing.Point(3, 295);
            this.BtnBestSelling.Name = "BtnBestSelling";
            this.BtnBestSelling.Size = new System.Drawing.Size(219, 47);
            this.BtnBestSelling.TabIndex = 4;
            this.BtnBestSelling.Text = "  BestSelling";
            this.BtnBestSelling.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnBestSelling.Click += new System.EventHandler(this.BtnBestSelling_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.BackColor = System.Drawing.Color.Transparent;
            this.BtnProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnProducts.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnProducts.FillColor = System.Drawing.Color.Empty;
            this.BtnProducts.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.BtnProducts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.BtnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducts.ForeColor = System.Drawing.Color.Black;
            this.BtnProducts.Image = global::MSMSGUI.Properties.Resources.products;
            this.BtnProducts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnProducts.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnProducts.Location = new System.Drawing.Point(3, 252);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(219, 47);
            this.BtnProducts.TabIndex = 3;
            this.BtnProducts.Text = "  Products";
            this.BtnProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnPersonalInfo
            // 
            this.BtnPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.BtnPersonalInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPersonalInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPersonalInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPersonalInfo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPersonalInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPersonalInfo.FillColor = System.Drawing.Color.Empty;
            this.BtnPersonalInfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.BtnPersonalInfo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(71)))), ((int)(((byte)(146)))));
            this.BtnPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonalInfo.ForeColor = System.Drawing.Color.Black;
            this.BtnPersonalInfo.Image = global::MSMSGUI.Properties.Resources.personalInfo;
            this.BtnPersonalInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPersonalInfo.Location = new System.Drawing.Point(3, 209);
            this.BtnPersonalInfo.Name = "BtnPersonalInfo";
            this.BtnPersonalInfo.Size = new System.Drawing.Size(219, 47);
            this.BtnPersonalInfo.TabIndex = 2;
            this.BtnPersonalInfo.Text = "Personal Info";
            this.BtnPersonalInfo.Click += new System.EventHandler(this.BtnPersonalInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MSMSGUI.Properties.Resources.singleCustomer;
            this.pictureBox1.Location = new System.Drawing.Point(46, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ControlBoxMinimize
            // 
            this.ControlBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ControlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlBoxMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ControlBoxMinimize.IconColor = System.Drawing.Color.White;
            this.ControlBoxMinimize.Location = new System.Drawing.Point(517, 0);
            this.ControlBoxMinimize.Name = "ControlBoxMinimize";
            this.ControlBoxMinimize.PressedColor = System.Drawing.Color.Red;
            this.ControlBoxMinimize.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxMinimize.TabIndex = 71;
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ControlBoxClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ControlBoxClose.IconColor = System.Drawing.Color.White;
            this.ControlBoxClose.Location = new System.Drawing.Point(561, 0);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.PressedColor = System.Drawing.Color.Red;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 70;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(827, 538);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogOut;
        private Guna.UI2.WinForms.Guna2GradientButton btnHistory;
        private Guna.UI2.WinForms.Guna2GradientButton BtnCart;
        private Guna.UI2.WinForms.Guna2GradientButton BtnBestSelling;
        private Guna.UI2.WinForms.Guna2GradientButton BtnProducts;
        private Guna.UI2.WinForms.Guna2GradientButton BtnPersonalInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlRight;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
    }
}