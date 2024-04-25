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
    public partial class FThanhToan : Form
    {
        private KhuyenMaiDAO km = new KhuyenMaiDAO();
        private string soTien;
        public FThanhToan(string soTien)
        {
            InitializeComponent();
            this.soTien = soTien;
        }

        private void FThanhToan_Load(object sender, EventArgs e)
        {
            txtSoTien.Text= soTien;
        }

        private void txtVoucher_TextChanged(object sender, EventArgs e)
        {
            int so = km.MaVouCher(txtVoucher.Text);
            int goc = int.Parse(soTien);
            soTien= (goc - (so * goc / 100)).ToString();
            FThanhToan_Load(sender, e);
        }
    }
}
