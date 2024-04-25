using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class GioHangDAO
    {
        DBConnection db = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public GioHangDAO() { }

        public void ThemGioHang(GioHang them)
        {

            string sql = string.Format("INSERT INTO GIOHANG(MaTK, MaSP, TenSP, Tien, FileAnh) VALUES('{0}', N'{1}', N'{2}', '{3}', N'{4}')",
                                        them.MaTK, them.MaSP, them.TenSP, them.Gia, them.Anh);
            db.ThucHien(sql);
        }

        public void XoaSanPham(string ma)
        {
            string sql = string.Format("DELETE FROM GIOHANG WHERE MaSP = '{0}'", ma);
            db.ThucHien(sql);
        }

        public List<GioHang> LayTT(string ma)
        {
            List<GioHang> list = new List<GioHang>();
            conn.Open();
            string sql = string.Format("SELECT * FROM GIOHANG  WHERE MaTK ='{0}'", ma);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GioHang a = new GioHang
                         (
                            (string)reader["MaTK"], (string)reader["MaSP"], (string)reader["TenSP"],
                            (int)reader["Tien"], (string)reader["FileAnh"]
                         );
                        list.Add(a);
                    }
                }
            }
            conn.Close();
            return list;
        }
    }
}
