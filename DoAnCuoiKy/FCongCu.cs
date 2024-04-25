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
    public partial class FCongCu : Form
    {
        public FCongCu()
        {
            InitializeComponent();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            FSanPham f = new FSanPham();
            f.ShowDialog();
        }

        private void btnSoDu_Click(object sender, EventArgs e)
        {
            FTienTaiKhoan f = new FTienTaiKhoan();
            f.ShowDialog();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            FHoaDonMuaHang f = new FHoaDonMuaHang();
            f.ShowDialog();
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            FGioHang f = new FGioHang();
            f.ShowDialog();
        }
    }
}
