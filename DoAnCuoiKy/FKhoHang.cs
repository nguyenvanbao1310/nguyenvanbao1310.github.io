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
    public partial class FKhoHang : Form
    {
        private KhoHangDAO kh= new KhoHangDAO();

        public FKhoHang()
        {
            InitializeComponent();
        }

        private void FKhoHang_Load(object sender, EventArgs e)
        {
            dgvKhoHang.DataSource = kh.LoadKhoHang();

            dgvKhoHang.Columns["MASP"].HeaderText = "Mã sản phẩm";
            dgvKhoHang.Columns["TENSP"].HeaderText = "Tên sản phẩm";
            dgvKhoHang.Columns["NGUOIBAN"].HeaderText = "Người bán";
            dgvKhoHang.Columns["MATK"].HeaderText = "Mã tài khoản";
            dgvKhoHang.Columns["NGAYDANG"].HeaderText = "Ngày đăng bán";
            dgvKhoHang.Columns["NGAYHETHAN"].HeaderText = "Ngày hết hạn";
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            dgvKhoHang.DataSource = kh.LaySanPhamTK(txtTimKiem.Text);
        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cbSanPham.SelectedItem as string;
            dgvKhoHang.DataSource = kh.LayKhoHangTheoCB(a);
        }

        private void dtpNgayDang_ValueChanged(object sender, EventArgs e)
        {
            string a = dtpNgayDang.Value.ToString();
            dgvKhoHang.DataSource = kh.LayKhoHangTheoDTP(a);
        }
    }
}
