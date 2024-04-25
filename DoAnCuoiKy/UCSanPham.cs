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
    public partial class UCSanPham : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection db = new DBConnection();
        public UCSanPham()
        {
            InitializeComponent();
        }

        private void picMua_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SQL = "SELECT * FROM SanPham WHERE TenSP = @TenSP"; 
            SqlCommand command = new SqlCommand(SQL, conn);
            command.Parameters.AddWithValue("@TenSP", lblTenSP.Text); 
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((string)reader["TenSP"] == lblTenSP.Text)
                {
                    SanPham a = new SanPham
                    (
                        (string)reader["DANHMUC"], (string)reader["TENSP"], (string)reader["MASP"],
                        (string)reader["MAU"], (int)reader["GIAGOC"], (int)reader["GIA"], (string)reader["TINHTRANG"],
                        (string)reader["KHUYENMAI"], (double)reader["DANHGIA"], (string)reader["LINHKIEN"],
                        (string)reader["BAOHANH"], (int)reader["SOLUONG"], (string)reader["THONGTIN"],
                        (string)reader["PHUKIEN"], (DateTime)reader["NGAYTHEM"], (string)reader["FILEANH"]
                    );
                    FSanPhamChiTiet f = new FSanPhamChiTiet(a);
                    f.ShowDialog();
                    break;
                }
            }
            conn.Close();

        }

      
    }
}
