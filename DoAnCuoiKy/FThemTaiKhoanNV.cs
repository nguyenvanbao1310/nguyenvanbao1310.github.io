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
    public partial class FThemTaiKhoanNV : Form
    {
        private TaiKhoanDAO tk = new TaiKhoanDAO();
        private int so;

        public FThemTaiKhoanNV( int so)
        {
            InitializeComponent();
            this.so = so;
        }

        private void FThemTaiKhoanNV_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NguoiDung a = new NguoiDung
            (
                txtTaiKhoan.Text, txtMatKhau.Text, "TK0" + (so + 1).ToString(),
                txtEmail.Text, txtTenNguoiDung.Text, txtSoDT.Text,
                txtDiaChi.Text, dtpNgaySinh.Value, dtpNgayTaoTK.Value, cboxVaiTro.Text
            );

            tk.ThemTaiKhoan(a);
        }
    }
}
