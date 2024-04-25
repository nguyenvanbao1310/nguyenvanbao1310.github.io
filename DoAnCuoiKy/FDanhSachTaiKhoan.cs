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
    public partial class FDanhSachTaiKhoan : Form
    {
        private TaiKhoanDAO tk = new TaiKhoanDAO();
        public FDanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        private void FDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.HeaderText = "Mã tài khoản";
            linkColumn.Name = "MaTK";
            linkColumn.DataPropertyName = "MaTK";
            dgvDanhSach.Columns.Add(linkColumn);
            dgvDanhSach.DataSource = tk.LoadDSTK();

            dgvDanhSach.Columns["TaiKhoan"].HeaderText = "Tài khoản";
            dgvDanhSach.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dgvDanhSach.Columns["MaTK"].HeaderText = "Mã tài khoản";
            dgvDanhSach.Columns["Email"].HeaderText = "Email";
            dgvDanhSach.Columns["TenND"].HeaderText = "Tên người dùng";
            dgvDanhSach.Columns["Phone"].HeaderText = "Số điện thoại";

            dgvDanhSach.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvDanhSach.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvDanhSach.Columns["NgayTao"].HeaderText = "Ngày tạo";
            dgvDanhSach.Columns["VaiTro"].HeaderText = "Vai trò";
            
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            FThemTaiKhoanNV f = new FThemTaiKhoanNV(dgvDanhSach.ColumnCount);
            f.ShowDialog();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvDanhSach.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {

                string ma = dgvDanhSach.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                FThongTinLH f = new FThongTinLH(ma);
                f.ShowDialog();
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = tk.LayTaiKhoanTheoTK(txtSearch.Text);
            
        }
    }
}
