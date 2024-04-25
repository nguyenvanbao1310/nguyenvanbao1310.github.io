using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FGiaoDienQL : Form
    {
        private Form current;
        public FGiaoDienQL()
        {
            InitializeComponent();
            pnlSanPham.Visible = false;
           
            pnlCaiDat.Visible = false;
        }

        private void OpenMenu()
        {
            if (pnlSanPham.Visible == true)
                pnlSanPham.Visible = false;
            
            if (pnlCaiDat.Visible == true)
                pnlCaiDat.Visible = false;
            
        }

        private void btnDanhSachSP_Click(object sender, EventArgs e)
        {
            OpenMenu();
            pnlSanPham.Visible=true;
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            OpenMenu();
           
        }

        private void OpenForm(Form child)
        {
            if (current != null)
            {
                current.Close();
            }  
            current = child;
            child.TopLevel = false;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            pnlManHinh.Controls.Add(child);
            pnlManHinh.Tag = child;
            child.Show();
        }


        private void btnNhanVien_Click(object sender, EventArgs e)
        {
           
            FQLNV f = new FQLNV();
            OpenForm(f);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            OpenMenu();
            pnlCaiDat.Visible = true;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FDanhSachTaiKhoan f = new FDanhSachTaiKhoan();
            OpenForm(f);
        }

        private void btnDSSP_Click(object sender, EventArgs e)
        {
            FDanhSachSanPham f = new FDanhSachSanPham();
            OpenForm(f);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void btnDonDuyet_Click(object sender, EventArgs e)
        {
            FQLDonHang f = new FQLDonHang();
            OpenForm(f);
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            FKhuyenMai f = new FKhuyenMai();
            OpenForm(f);
        }

        private void btnDanhSachTaiKhoan_Click(object sender, EventArgs e)
        {
            FDanhSachTaiKhoan f = new FDanhSachTaiKhoan();
            OpenForm(f);
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            FMatKhau f = new FMatKhau();
            OpenForm(f);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            FKhoHang f = new FKhoHang();
            OpenForm(f);
        }
    }
}
