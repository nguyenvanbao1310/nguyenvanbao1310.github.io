using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FTaiKhoan : Form
    {
        private Form current;
       
      
        public FTaiKhoan()
        {
            InitializeComponent();
        }

        private void OpenForm(Form child)
        {
            if (current != null)
            {
                current.Close();
            }
            current = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlTaiKhoan.Controls.Add(child);
            pnlTaiKhoan.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void lblTaoTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FTaoTaiKhoan f = new FTaoTaiKhoan();
            OpenForm(f);
        }

        private void lblDoiMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FMatKhau f = new FMatKhau();
            OpenForm(f);
        }

        private void lblDSTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FDanhSachTaiKhoan f = new FDanhSachTaiKhoan();
            OpenForm(f);
        }
    }
}
