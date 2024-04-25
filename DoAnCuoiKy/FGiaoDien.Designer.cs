namespace DoAnCuoiKy
{
    partial class FGiaoDien
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ucGiaoDien1 = new DoAnCuoiKy.UCGiaoDien();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ucGiaoDien1
            // 
            this.ucGiaoDien1.AutoScroll = true;
            this.ucGiaoDien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGiaoDien1.Location = new System.Drawing.Point(0, 0);
            this.ucGiaoDien1.Name = "ucGiaoDien1";
            this.ucGiaoDien1.Size = new System.Drawing.Size(1275, 458);
            this.ucGiaoDien1.TabIndex = 0;
            this.ucGiaoDien1.Load += new System.EventHandler(this.ucGiaoDien1_Load);
            // 
            // FGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1275, 458);
            this.Controls.Add(this.ucGiaoDien1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FGiaoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FGiaoDien";
            this.ResumeLayout(false);

        }

        #endregion

        private UCGiaoDien ucGiaoDien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}