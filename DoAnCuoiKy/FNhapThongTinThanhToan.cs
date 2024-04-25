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
    public partial class FNhapThongTinThanhToan : Form
    {
        private SanPham a; 
        private NguoiDung b;
        private DonHang c;

        public FNhapThongTinThanhToan(SanPham a, NguoiDung b, DonHang c)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            pnlVanChuyen.Visible = false;
        }

        private void FNhapThongTinThanhToan_Load(object sender, EventArgs e)
        {
            
            lblTenSP.Text = a.TenSP;
            lblMaSP.Text = a.MaSP;
            lblMaDonHang.Text = c.MaDH;
            lblTenNguoiBan.Text = c.TenNguoiBan;
            lblGiaTien.Text = c.TongTien.ToString();
            lblTrangThaiTT.Text = c.TangThaiTT;
            lblTrangThaiGH.Text = c.TangThaiGH;
            lblTienSP.Text = c.TongTien.ToString();
            
           
        }

        private void rbtnNhanTT_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rbtnNhanTT.Checked)
            {
                lblPhiVC.Text = "0";
                lblTongTien.Text = (int.Parse(lblTienSP.Text) + int.Parse(lblPhiVC.Text)).ToString();
                pnlVanChuyen.Visible = false;
                FNhapThongTinThanhToan_Load(sender, e);
            }
        }

        private void rbtnVanChuyen_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rbtnVanChuyen.Checked)
            {
                lblPhiVC.Text = "50000";
                lblTongTien.Text = (int.Parse(lblTienSP.Text) + int.Parse(lblPhiVC.Text)).ToString();
                pnlVanChuyen.Visible = true;
                FNhapThongTinThanhToan_Load(sender, e);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            FThanhToan f = new FThanhToan(lblTongTien.Text);
            f.ShowDialog();
        }
    }
}
