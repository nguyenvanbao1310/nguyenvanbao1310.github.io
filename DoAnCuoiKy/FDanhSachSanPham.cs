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
    public partial class FDanhSachSanPham : Form
    {
        DBConnection db = new DBConnection();
        SanPhamDAO sp = new SanPhamDAO();
        public FDanhSachSanPham()
        {
            InitializeComponent();
        }

        private void FDanhSachSanPham_Load(object sender, EventArgs e)
        {

            dgvDanhSach.DataSource = sp.LoadTT();
            dgvDanhSach.Columns["DANHMUC"].HeaderText = "Danh mục";
            dgvDanhSach.Columns["TENSP"].HeaderText = "Tên sản phẩm";
            dgvDanhSach.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgvDanhSach.Columns["MAU"].HeaderText = "Màu sắc";
            dgvDanhSach.Columns["GIAGOC"].HeaderText = "Giá gốc";
            dgvDanhSach.Columns["GIA"].HeaderText = "Giá bán";
            dgvDanhSach.Columns["TINHTRANG"].HeaderText = "Tình trạng sản phẩm";
            dgvDanhSach.Columns["KHUYENMAI"].HeaderText = "Khuyến mãi";
            dgvDanhSach.Columns["DANHGIA"].HeaderText = "Đánh giá";
            dgvDanhSach.Columns["LINHKIEN"].HeaderText = "Linh kiện";
            dgvDanhSach.Columns["BAOHANH"].HeaderText = "Bảo hành";
            dgvDanhSach.Columns["SOLUONG"].HeaderText = "Số lượng";
            dgvDanhSach.Columns["THONGTIN"].HeaderText = "Thông tin";
            dgvDanhSach.Columns["PHUKIEN"].HeaderText = "Phụ kiện";
            dgvDanhSach.Columns["NGAYTHEM"].HeaderText = "Ngày thêm";
            dgvDanhSach.Columns["FILEANH"].HeaderText = "File ảnh";

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dgvDanhSach.Columns[e.ColumnIndex].Name;
            if (name == "ColSua")
            {

                
                SanPham a = new SanPham
                (
                    dgvDanhSach.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    dgvDanhSach.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    dgvDanhSach.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    dgvDanhSach.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    int.Parse(dgvDanhSach.Rows[e.RowIndex].Cells[6].Value.ToString()),
                    int.Parse(dgvDanhSach.Rows[e.RowIndex].Cells[7].Value.ToString()),
                    dgvDanhSach.Rows[e.RowIndex].Cells[8].Value.ToString(),
                    dgvDanhSach.Rows[e.RowIndex].Cells[9].Value.ToString(),
                    double.Parse(dgvDanhSach.Rows[e.RowIndex].Cells[10].Value.ToString()),
                    dgvDanhSach.Rows[e.RowIndex].Cells[11].Value.ToString(),
                    dgvDanhSach.Rows[e.RowIndex].Cells[12].Value.ToString(),
                    int.Parse(dgvDanhSach.Rows[e.RowIndex].Cells[13].Value.ToString()),
                    dgvDanhSach.Rows[e.RowIndex].Cells[14].Value.ToString(),
                    dgvDanhSach.Rows[e.RowIndex].Cells[15].Value.ToString(),
                    DateTime.Parse(dgvDanhSach.Rows[e.RowIndex].Cells[16].Value.ToString()),
                    dgvDanhSach.Rows[e.RowIndex].Cells[17].Value.ToString()
                );
                FChinhSuaSP f = new FChinhSuaSP(a);
                f.Show();

            }
            else
            {
                if (name == "ColXoa")
                {
                    string a = dgvDanhSach.Rows[e.RowIndex].Cells[4].Value.ToString();
                    sp.XoaSanPham(a);
                    FDanhSachSanPham_Load(sender, e);
                }
            }    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FThemSanPham f = new FThemSanPham();
            f.Show();
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            FDanhSachSanPham_Load(sender, e);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = sp.LaySanPhamTheoTK(txtSearch.Text);
        }
    }
}
