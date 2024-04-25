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
    public partial class FXemTTNguoiBan : Form
    {
        private KhoHang kh;
        private TaiKhoanDAO tk = new TaiKhoanDAO();
        private KhoHangDAO khd= new KhoHangDAO();
        public FXemTTNguoiBan(KhoHang kh)
        {
            InitializeComponent();
            this.kh = kh;

        }

        private void FXemTTNguoiBan_Load(object sender, EventArgs e)
        {
            NguoiDung a = tk.LayTT(kh.MaTK);
            lblTenNguoiBan.Text = a.TenND.ToString();
            lblEmail.Text = a.Email.ToString();
            lblDiaChi.Text = a.DiaChi.ToString();
            lblSoDT.Text = a.SDT.ToString();
            dgvSanPhamBan.DataSource = khd.LoadKHTheoMaSP(kh.NguoiBan.ToString());
            lblSoLuong.Text = (dgvSanPhamBan.RowCount -1).ToString();

        }

        private void lblXemDanhGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FDanhGia f = new FDanhGia(tk.LayTT(kh.MaTK));
            f.ShowDialog();
        }
    }
}
