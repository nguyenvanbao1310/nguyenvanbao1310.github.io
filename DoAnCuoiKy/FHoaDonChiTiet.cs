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
    public partial class FHoaDonChiTiet : Form
    {
        private DonHang dhang;
        private DonHangDAO dh = new DonHangDAO();
        public FHoaDonChiTiet(DonHang dhang)
        {
            InitializeComponent();
            this.dhang = dhang;
        }

        private void FHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            LayTTKhachHang();
            LayTTSP();
        }

        private void LayTTSP()
        {
            SanPham a = dh.LayTTSanPham(dhang.MaSP);
            lblTenSP.Text = a.TenSP;
            lblGiaTien.Text = (a.GiaTien*1000).ToString();
            picAnh.Image = Image.FromFile(a.FileAnh);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void LayTTKhachHang()
        {
            NguoiDung a = dh.LayTTKH(Form1.matk);
            lblDiaChi.Text = a.DiaChi;
            lblEmail.Text = a.Email;
            lblTenKH.Text = a.TenND;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            SanPham a = dh.LayTTSanPham(dhang.MaSP);
            NguoiDung b = dh.LayTTKH(Form1.matk);
            FNhapThongTinThanhToan f = new FNhapThongTinThanhToan(a, b, dhang);
            f.ShowDialog();
        }
    }
}
