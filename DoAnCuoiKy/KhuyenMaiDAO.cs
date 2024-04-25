using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    internal class KhuyenMaiDAO
    {
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        private DBConnection db = new DBConnection();

        public KhuyenMaiDAO() { }

        public int MaVouCher(string mau)
        {
            int a = 0;
            string sql = string.Format("SELECT GiaTri FROM KHUYENMAI WHERE MaKhuyenMai = '{0}'", mau);
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        a = (int)reader["GiaTri"];
                        conn.Close();
                        return a;
                    }
                }
            }
            return a;
        }
    }
}
