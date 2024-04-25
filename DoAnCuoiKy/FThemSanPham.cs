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
    public partial class FThemSanPham : Form
    {
        DBConnection db = new DBConnection();
        SanPhamDAO sp = new SanPhamDAO();
        public FThemSanPham()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham them = new SanPham
            (
                cbDanhMuc.Text, txtTenSP.Text, txtMaSP.Text, 
                txtMau.Text, int.Parse(txtGiaGoc.Text), int.Parse(txtGiaBan.Text), txtTinhTrang.Text,
                txtKhuyenMai.Text, double.Parse(txtDanhGia.Text), txtLinhKien.Text,
                txtBaoHanh.Text, int.Parse(NumericSL.Value.ToString()), txtThongTin.Text,
                txtPhuKien.Text, dtpNgayMua.Value, txtFileAnh.Text
            ) ;
            sp.ThemSanPham(them);
            
        }

        private void lblThemAnh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FThemSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
