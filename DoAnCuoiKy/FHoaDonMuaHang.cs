using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FHoaDonMuaHang : Form
    {
       private DonHangDAO dh = new DonHangDAO();

        public FHoaDonMuaHang()
        {

            InitializeComponent();


        }

        private void FHoaDonMuaHang_Load(object sender, EventArgs e)
        {
            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.HeaderText = "Mã đơn hàng";
            linkColumn.Name = "MaDH"; 
            linkColumn.DataPropertyName = "MaDH";
            dgvDonHang.Columns.Add(linkColumn);
            dgvDonHang.DataSource = dh.LoadDonHang();
            dgvDonHang.Columns["MaDH"].HeaderText = "Mã đơn hàng";
            dgvDonHang.Columns["MaND"].HeaderText = "Mã khách hàng";
            dgvDonHang.Columns["TenNguoiBan"].HeaderText = "Tên người bán";
            dgvDonHang.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgvDonHang.Columns["NgayMua"].HeaderText = "Ngày tạo đơn hàng";
            dgvDonHang.Columns["TrangThaiThanhToan"].HeaderText = "Trạng thái thanh toán";
            dgvDonHang.Columns["TrangThaiGiaoHang"].HeaderText = "Trạng thái giao hàng";

        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDonHang.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                string maDonHang = dgvDonHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
               

                DonHang a = dh.LayDonHang(maDonHang);

                FHoaDonChiTiet f = new FHoaDonChiTiet(a);
                f.ShowDialog();

            }
        }
    }
}
