using System;
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
    public partial class FGhiDanhGia : Form
    {
        private NguoiDung a;
        private DanhGiaDAO dg = new DanhGiaDAO();
        private List<string > st = new List<string>();
        public FGhiDanhGia(NguoiDung a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FGhiDanhGia_Load(object sender, EventArgs e)
        {
            st = dg.LayTTDonHang(Form1.matk);
            foreach(string s in st) 
            {
                cbMaDonHang.Items.Add(s);
            }
           
        }

        private void cbMaDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenSP.Text = dg.LayTTSanPham(cbMaDonHang.SelectedItem.ToString());
            txtTenNguoiBan.Text = dg.LayTTNguoiBan(cbMaDonHang.SelectedItem.ToString());
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            
            string anh = dg.LayTTDonHangDG(cbMaDonHang.SelectedItem.ToString());
            string ma = dg.LayMaNguoiBan(cbMaDonHang.SelectedItem.ToString());
            DanhGia d = new DanhGia
            (
                ma, txtTenNguoiBan.Text, txtTenSP.Text, cbMaDonHang.SelectedItem.ToString(),
                Form1.ten, txtNoiDungDG.Text, "Chua co phan hoi", anh
            );
            dg.ThemDanhGia(d);
        }
    }
}
