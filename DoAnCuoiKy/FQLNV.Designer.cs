namespace DoAnCuoiKy
{
    partial class FQLNV
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
            this.ucQuanLy1 = new DoAnCuoiKy.UCQuanLy();
            this.SuspendLayout();
            // 
            // ucQuanLy1
            // 
            this.ucQuanLy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQuanLy1.Location = new System.Drawing.Point(0, 0);
            this.ucQuanLy1.Name = "ucQuanLy1";
            this.ucQuanLy1.Size = new System.Drawing.Size(910, 537);
            this.ucQuanLy1.TabIndex = 0;
            this.ucQuanLy1.Load += new System.EventHandler(this.ucQuanLy1_Load);
            // 
            // FQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 537);
            this.Controls.Add(this.ucQuanLy1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FQLNV";
            this.Text = "FQLNV";
            this.ResumeLayout(false);

        }

        #endregion
        private UCQuanLy ucQuanLy1;
    }
}