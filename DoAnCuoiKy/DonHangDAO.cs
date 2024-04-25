using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public class DonHangDAO
    {
        DBConnection db = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public DonHangDAO() { }

        public void ThemDonHang(DonHang them)
        {

            string sql = string.Format("INSERT INTO DONHANG(MaDH, MaND, TenNguoiBan, MaSP, NgayMua, TongTien, TrangThaiThanhToan, TrangThaiGiaoHang) VALUES('{0}', '{1}',N'{2}',N'{3}','{4}','{5}','{6}', '{7}')",
                                        them.MaDH, them.MaND, them.TenNguoiBan, them.MaSP, them.NgayTao, them.TongTien, them.TangThaiTT, them.TangThaiGH);
            db.ThucHien(sql);
        }

        public DataTable LoadDonHang()
        {
            string sql = string.Format("SELECT * FROM DONHANG ");
            return db.Load(sql);
        }

        public DonHang LayDonHang(string ma)
        {
            string sql = string.Format("SELECT * FROM DONHANG WHERE MaDH = '{0}'", ma);
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DonHang a = new DonHang
                         (
                            (string)reader["MaDH"], (string)reader["MaND"], (string)reader["TenNguoiBan"],
                            (string)reader["MaSP"], (DateTime)reader["NgayMua"], (int)reader["TongTien"], 
                            (string)reader["TrangThaiThanhToan"], (string)reader["TrangThaiGiaoHang"]
                         );
                        conn.Close();
                        return a;

                    }
                }
            }
            return null;
        }

        public SanPham LayTTSanPham(string ma)
        {
            conn.Open();
            string sql = string.Format("SELECT * FROM SANPHAM WHERE MASP = '{0}' ", ma);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
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
                            (string)reader["PHUKIEN"], (DateTime)reader["NGAYTHEM"], (string)reader["FILEANH"]
                         );
                        conn.Close();
                        return a;

                    }
                }
            }
            return null;
            
        }


        public NguoiDung LayTTKH(string ma) 
        {
            conn.Open();
            string sql = string.Format("SELECT * FROM USERS WHERE MaTK = '{0}' ", ma);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NguoiDung a = new NguoiDung
                         (
                            (string)reader["TaiKhoan"], (string)reader["MatKhau"], (string)reader["MaTK"], (string)reader["Email"],
                            (string)reader["TenND"], (string)reader["Phone"], (string)reader["DiaChi"], (DateTime)reader["NgaySinh"],
                            (DateTime)reader["NgayTao"], (string)reader["VaiTro"]
                         );
                        conn.Close();
                        return a;
                    }
                }
            }
            return null;
        }

        public DataTable TimKiemTheoMDH(string tu)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM DONHANG WHERE MaDH LIKE @tu";
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@tu", "%" + tu + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public string TimNguoiMuaHang()
        {
            string a = "";
            string sql ="SELECT TOP 1 MaND, COUNT(MaND) AS DemMaND FROM DONHANG " +
                        "GROUP BY MaND " +
                        "ORDER BY DemMaND DESC ";
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = (string)reader["MaND"];
                        conn.Close();
                        return a;
                    }
                }
            }
            return a;
        }

        public DataTable Load()
        {
            string a = TimNguoiMuaHang();
            string sql = string.Format("SELECT * FROM DONHANG WHERE MaND = '{0}'", a);
            return db.Load(sql);
        }

    }

}
