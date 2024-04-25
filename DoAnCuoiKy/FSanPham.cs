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
    public partial class FSanPham : Form
    {
        
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        private Form current;
        public FSanPham()
        {
            InitializeComponent();
        }

        private void OpenForm(Form child)
        {
            if (current != null)
            {
                current.Close();
            }
            current = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlChuyenTiep.Controls.Add(child);
            pnlChuyenTiep.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void btnLoa_Click(object sender, EventArgs e)
        {
            List<SanPham> a = LayDuLieu("Loa");
            FShopDo f = new FShopDo(a);
            OpenForm(f);
        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            List<SanPham> a = LayDuLieu("Laptop");
            FShopDo f = new FShopDo(a);
            OpenForm(f);
        }

        private void btnDienThoai_Click(object sender, EventArgs e)
        {
            List<SanPham> a= LayDuLieu("Điện thoại");
            FShopDo f = new FShopDo(a);
            OpenForm(f);
        }

        private List<SanPham> LayDuLieu(string mau)
        {
            List<SanPham> sp = new List<SanPham>();
            conn.Open();
            string query = "SELECT * FROM SANPHAM";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((string)reader["DANHMUC"] == mau)
                {
                    SanPham a = new SanPham
                    (
                        (string)reader["DANHMUC"], (string)reader["TENSP"], (string)reader["MASP"],
                        (string)reader["MAU"], (int)reader["GIAGOC"], (int)reader["GIA"], (string)reader["TINHTRANG"],
                        (string)reader["KHUYENMAI"],(double)reader["DANHGIA"], (string)reader["LINHKIEN"],
                        (string)reader["BAOHANH"], (int)reader["SOLUONG"], (string)reader["THONGTIN"],
                        (string)reader["PHUKIEN"], (DateTime)reader["NGAYTHEM"], (string)reader["FILEANH"]
                    );
                    sp.Add(a);
                }

            }
            reader.Close();
            conn.Close();
            return sp;
        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            
            List<SanPham> tk= new List<SanPham>();
            string tu = txtSearch.Text;
            conn.Open();
            string sql = "SELECT * FROM SANPHAM WHERE TENSP LIKE @tu";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                
                command.Parameters.AddWithValue("@tu", "%" + tu + "%");

                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SanPham a = new SanPham
                        (
                            (string)reader["DANHMUC"], (string)reader["TENSP"], (string)reader["MASP"],
                            (string)reader["MAU"], (int)reader["GIAGOC"], (int)reader["GIA"], (string)reader["TINHTRANG"],
                            (string)reader["KHUYENMAI"], (double)reader["DANHGIA"], (string)reader["LINHKIEN"],
                            (string)reader["BAOHANH"], (int)reader["SOLUONG"], (string)reader["THONGTIN"],
                            (string)reader["PHUKIEN"], (DateTime)reader["NGAYTHEM"],  (string)reader["FILEANH"]
                        );
                        tk.Add(a);
                    }
                }

            }
            conn.Close();
            FShopDo f = new FShopDo(tk);
            OpenForm(f);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FSanPham_Load(sender, e);
        }

        private void FSanPham_Load(object sender, EventArgs e)
        {
            List<SanPham> sp = new List<SanPham>();
            conn.Open();
            string query = "SELECT * FROM SANPHAM";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                SanPham a = new SanPham
                (
                    (string)reader["DANHMUC"], (string)reader["TENSP"], (string)reader["MASP"],
                    (string)reader["MAU"], (int)reader["GIAGOC"], (int)reader["GIA"], (string)reader["TINHTRANG"],
                    (string)reader["KHUYENMAI"], (double)reader["DANHGIA"], (string)reader["LINHKIEN"],
                    (string)reader["BAOHANH"], (int)reader["SOLUONG"], (string)reader["THONGTIN"],
                    (string)reader["PHUKIEN"], (DateTime)reader["NGAYTHEM"], (string)reader["FILEANH"]
                );
                sp.Add(a);


            }
            reader.Close();
            conn.Close();
            FShopDo f = new FShopDo(sp);
            OpenForm(f);
        }
    }
}
