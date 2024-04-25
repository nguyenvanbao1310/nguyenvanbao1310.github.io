namespace DoAnCuoiKy
{
    partial class FThongTin
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblShop = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDoiMK = new System.Windows.Forms.LinkLabel();
            this.lblThongTinLH = new System.Windows.Forms.LinkLabel();
            this.pnlHienThi = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblDoiMK);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblThongTinLH);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(180, 639);
            this.guna2CustomGradientPanel1.TabIndex = 20;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.Controls.Add(this.lblShop);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(180, 127);
            this.guna2Panel1.TabIndex = 24;
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShop.Location = new System.Drawing.Point(40, 80);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(83, 34);
            this.lblShop.TabIndex = 1;
            this.lblShop.Text = "SHOP";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::DoAnCuoiKy.Properties.Resources.Shop_Location;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(22, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(127, 62);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblDoiMK
            // 
            this.lblDoiMK.AutoSize = true;
            this.lblDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMK.Location = new System.Drawing.Point(-4, 209);
            this.lblDoiMK.Name = "lblDoiMK";
            this.lblDoiMK.Size = new System.Drawing.Size(119, 20);
            this.lblDoiMK.TabIndex = 23;
            this.lblDoiMK.TabStop = true;
            this.lblDoiMK.Text = "Đổi mật khẩu";
            this.lblDoiMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDoiMK_LinkClicked);
            // 
            // lblThongTinLH
            // 
            this.lblThongTinLH.AutoSize = true;
            this.lblThongTinLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinLH.Location = new System.Drawing.Point(-4, 162);
            this.lblThongTinLH.Name = "lblThongTinLH";
            this.lblThongTinLH.Size = new System.Drawing.Size(167, 20);
            this.lblThongTinLH.TabIndex = 22;
            this.lblThongTinLH.TabStop = true;
            this.lblThongTinLH.Text = "Thông tin && liên hệ";
            // 
            // pnlHienThi
            // 
            this.pnlHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHienThi.Location = new System.Drawing.Point(180, 0);
            this.pnlHienThi.Name = "pnlHienThi";
            this.pnlHienThi.Size = new System.Drawing.Size(996, 639);
            this.pnlHienThi.TabIndex = 21;
            // 
            // FThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1176, 639);
            this.Controls.Add(this.pnlHienThi);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FThongTin";
            this.Text = "FThongTin";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.LinkLabel lblThongTinLH;
        private System.Windows.Forms.LinkLabel lblDoiMK;
        private Guna.UI2.WinForms.Guna2Panel pnlHienThi;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblShop;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}