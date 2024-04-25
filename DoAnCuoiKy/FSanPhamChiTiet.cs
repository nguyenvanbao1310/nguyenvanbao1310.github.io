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
    public partial class FSanPhamChiTiet : Form
    {
        private SanPham a;
        private KhoHangDAO kh = new KhoHangDAO();
        private DonHangDAO dh = new DonHangDAO();
        private GioHangDAO gh = new GioHangDAO();


        public FSanPhamChiTiet(SanPham a)
        {
            this.a = a;
            InitializeComponent();
        }

        private void FSanPhamChiTiet_Load(object sender, EventArgs e)
        {
            lblTenSP.Text = a.TenSP.ToString();
            lblMaSP.Text = a.MaSP.ToString();
            lblMauSac.Text = a.Mau.ToString();
            lblGiaTien.Text = (a.GiaTien*1000).ToString();
            lblTinhTrang.Text = a.TinhTrang.ToString();
            lblKhuyenMai.Text = a.KhuyenMai.ToString();
            lblDanhGia.Text = a.DanhGia.ToString();
            lblSoLuong.Text = a.SoLuong.ToString();
            lblBaoHanh.Text = a.BaoHanh.ToString();
            picAnhSP.Image = Image.FromFile(a.FileAnh);
            picAnhSP.SizeMode = PictureBoxSizeMode.Zoom;
            lblNgayMua.Text = a.NgayThem.ToString();
            lblGiaGoc.Text  = (a.GiaGoc*1000).ToString();
            grbThongTin.Text = "Thông tin";
            lblThongTin.Text = a.ThongTin.ToString();
            lblLinhKien.Text = a.LinhKien.ToString();
            lblPhuKien.Text = a.PhuKien.ToString();
            lblLoaiSP.Text = a.DanhMuc.ToString();
            lblNguoiBan.Text = kh.LayTTNguoiBan(a.MaSP).NguoiBan.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn với sự lựa chọn này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                ThemVaoGioHang();
                MessageBox.Show("Thêm thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ThemVaoGioHang()
        {
            GioHang them = new GioHang
            (
                Form1.matk, a.MaSP, a.TenSP, a.GiaTien, a.FileAnh
            );
            gh.ThemGioHang(them);
        }    

       

        


        private void picQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void llblXemTT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FXemTTNguoiBan f = new FXemTTNguoiBan(kh.LayTTNguoiBan(lblMaSP.Text));
            f.ShowDialog();
        }
    }
}
