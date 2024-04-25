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
    public partial class FQLDonHang : Form
    {
        private DonHangDAO dh = new DonHangDAO();
        public FQLDonHang()
        {
            InitializeComponent();
        }

        private void FQLDonHang_Load(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = dh.LoadDonHang();
            dgvDonHang.Columns["MaDH"].HeaderText = "Mã đơn hàng";
            dgvDonHang.Columns["MaND"].HeaderText = "Mã khách hàng";
            dgvDonHang.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgvDonHang.Columns["NgayMua"].HeaderText = "Ngày tạo đơn hàng";
            dgvDonHang.Columns["TrangThaiThanhToan"].HeaderText = "Trạng thái thanh toán";
            dgvDonHang.Columns["TrangThaiGiaoHang"].HeaderText = "Trạng thái giao hàng";
           
        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = dh.TimKiemTheoMDH(txtTimKiem.Text);
        }

        private void cboxNguoiMua_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = dh.Load();
        }
    }
}
