using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class DanhGiaDAO
    {
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        private DBConnection db = new DBConnection();
        public DanhGiaDAO() { }




        public void ThemDanhGia(DanhGia them)
        {
            string sql = string.Format("INSERT INTO DANHGIA(Ma, TenNguoiBan, TenSP, MaDH, TenNguoiMua, KhachHangDG, PhanHoiDG,  FILEANH) VALUES('{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}')",
                                        them.Ma, them.TenNguoiBan, them.TenSP, them.MaDH, them.TenNguoiMua, them.KhachDG, them.PhanHoiDG, them.FileAnh);
            db.ThucHien(sql);
        }


        public List<DanhGia> LoadTT(string ma)
        {
            List<DanhGia> list = new List<DanhGia>();
            conn.Open();
            string sql = string.Format("SELECT * FROM DANHGIA  WHERE Ma ='{0}'", ma);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DanhGia a = new DanhGia
                         (
                            (string)reader["Ma"],(string)reader["TenNguoiBan"], (string)reader["TenSP"], (string)reader["MaDH"], (string)reader["TenNguoiMua"],
                            (string)reader["KhachHangDG"], (string)reader["PhanHoiDG"], (string)reader["FileAnh"]
                         );
                        list.Add(a);
                    }
                }
            }
            conn.Close();
            return list;
        }

        public List<string> LayTTDonHang(string tk)
        {
            List<string> st = new List<string>();
            string sql = string.Format("SELECT MaDH FROM DONHANG WHERE MaND = '{0}'", tk);
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        st.Add((string)reader["MaDH"]);
                    }
                }
            }
            conn.Close();
            return st;
        }

        public string LayTTSanPham(string ma)
        {
            string a="";
            string sql = string.Format("SELECT SANPHAM.TenSP FROM DONHANG INNER JOIN SANPHAM ON SANPHAM.MaSP = DONHANG.MaSP WHERE DONHANG.MaDH = '{0}'", ma);
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = (string)reader["TenSP"];
                    }
                }
            }
            conn.Close();
            return a;
        }

        public string LayTTNguoiBan(string ma)
        {
            string a = "";
            string sql = string.Format("SELECT TenNguoiBan FROM DONHANG WHERE MaDH = '{0}'", ma);
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = (string)reader["TenNguoiBan"];
                    }
                }
            }
            conn.Close();
            return a;
        }

        public string LayMaNguoiBan(string ma)
        {
            string a = "";
            string sql = string.Format("SELECT MATK FROM DONHANG INNER JOIN KHOHANG ON DONHANG.MaSP = KHOHANG.MASP WHERE MaDH = '{0}'", ma);
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = (string)reader["MATK"];
                    }
                }
            }
            conn.Close();
            return a;
        }


        public string LayTTDonHangDG(string ma)
        {
            string a = "";
            string sql = string.Format("SELECT SANPHAM.FileAnh FROM DONHANG INNER JOIN SANPHAM ON SANPHAM.MaSP = DONHANG.MaSP WHERE DONHANG.MaDH = '{0}'", ma);
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = (string)reader["FileAnh"];
                    }
                }
            }
            conn.Close();
            return a;
        }
    }
}
