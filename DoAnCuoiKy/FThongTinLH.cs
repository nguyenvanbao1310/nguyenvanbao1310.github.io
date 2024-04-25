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
    public partial class FThongTinLH : Form
    {
        private string ma;
        private TaiKhoanDAO tk=  new TaiKhoanDAO();
        public FThongTinLH(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            
        }

        private void picSua_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = true;
            txtEmail.Enabled = true;
            txtSoDT.Enabled = true;
            txtDiaChi.Enabled = true;
            dtpNgaySinh.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void FThongTinLH_Load(object sender, EventArgs e)
        {
            NguoiDung a = tk.LayTT(ma);
            lblTenKH.Text = a.TenND.ToString();
            txtHoTen.Text = a.TenND.ToString();
            txtDiaChi.Text = a.DiaChi.ToString();
            txtEmail.Text = a.Email.ToString();
            txtSoDT.Text = a.SDT.ToString();
            dtpNgaySinh.Value = a.NgayTao;
            txtHoTen.Enabled = false;
            txtEmail.Enabled = false;
            txtSoDT.Enabled = false;
            txtDiaChi.Enabled = false;
            dtpNgaySinh.Enabled = false;
            btnLuu.Enabled = false;
        }
    }
}
