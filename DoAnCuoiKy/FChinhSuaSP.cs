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
    public partial class FChinhSuaSP : Form
    {
        private DBConnection db = new DBConnection();
        private SanPhamDAO sp = new SanPhamDAO();
        private SanPham a;
        public FChinhSuaSP(SanPham a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SanPham sua = new SanPham
            ( 
                cbDanhMuc.Text, txtTenSP.Text, txtMaSP.Text, 
                txtMau.Text, int.Parse(txtGiaGoc.Text), int.Parse(txtGiaBan.Text), txtTinhTrang.Text,
                txtKhuyenMai.Text, double.Parse(txtDanhGia.Text), txtLinhKien.Text,
                txtBaoHanh.Text, int.Parse(NumericSL.Value.ToString()), txtThongTin.Text,
                txtPhuKien.Text, dtpNgayMua.Value, txtFileAnh.Text
            );
            sp.SuaSanPham( sua );
            
        }

        private void FChinhSuaSP_Load(object sender, EventArgs e)
        {
            cbDanhMuc.SelectedItem = a.DanhMuc;
            txtTenSP.Text = a.TenSP;
            txtMaSP.Text = a.MaSP;
            txtMau.Text = a.Mau;
            txtGiaGoc.Text = a.GiaGoc.ToString();
            txtGiaBan.Text = a.GiaTien.ToString();
            txtTinhTrang.Text = a.TinhTrang.ToString();
            txtKhuyenMai.Text = a.KhuyenMai.ToString();
            txtDanhGia.Text = a.DanhGia.ToString();
            txtLinhKien.Text = a.LinhKien.ToString();
            txtBaoHanh.Text = a.BaoHanh.ToString();
            NumericSL.Value = a.SoLuong;
            txtThongTin.Text = a.ThongTin.ToString();
            txtPhuKien.Text = a.PhuKien.ToString();
            dtpNgayMua.Value = a.NgayThem;
            txtFileAnh.Text = a.FileAnh.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
