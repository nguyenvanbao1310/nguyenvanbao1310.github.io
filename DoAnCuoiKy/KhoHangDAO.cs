using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public class KhoHangDAO
    {
        DBConnection db = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public DataTable LoadKhoHang()
        {
            string sql = string.Format("SELECT * FROM KHOHANG ");
            return db.Load(sql);
        }

        public KhoHang LayTTNguoiBan(string ma)
        {
            conn.Open();
            string sql = string.Format("SELECT * FROM KHOHANG WHERE MASP = '{0}' ", ma);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KhoHang a = new KhoHang
                         (
                            (string)reader["MASP"], (string)reader["TENSP"], (string)reader["NGUOIBAN"],
                            (string)reader["MATK"], (DateTime)reader["NGAYDANG"], (DateTime)reader["NGAYHETHAN"]
                            
                         );
                        conn.Close();
                        return a;

                    }
                }
            }
            return null;
        }

        public DataTable LaySanPhamTK(string tu)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM KHOHANG WHERE TENSP LIKE @tu";
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

        public DataTable LoadKHTheoMaSP(string ma)
        {
            string sql = string.Format("SELECT * FROM KHOHANG WHERE NGUOIBAN = N'{0}' ", ma);
            return db.Load(sql);
        }

        public DataTable LayKhoHangTheoCB(string ma)
        {
            string sql = string.Format("SELECT KHOHANG.* FROM KHOHANG LEFT OUTER JOIN SANPHAM ON KHOHANG.MASP = SANPHAM.MASP WHERE SANPHAM.DANHMUC = N'{0}'", ma);
            return db.Load(sql);
        }

        public DataTable LayKhoHangTheoDTP(string ngay)
        {
            string sql = string.Format("SELECT * FROM KHOHANG WHERE NGAYDANG = '{0}'", ngay);
            return db.Load(sql);
        }
    }
}
