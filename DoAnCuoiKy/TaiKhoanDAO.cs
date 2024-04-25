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
   
    public  class TaiKhoanDAO
    {
        DBConnection db = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public DataTable LoadDSTK()
        {
            string sql = string.Format("SELECT * FROM USERS ");
            return db.Load(sql);
        }

        public void ThemTaiKhoan(NguoiDung them)
        {
            string sql = string.Format("INSERT INTO USERS (TaiKhoan, MatKhau, MaTK, Email, TenND, Phone, DiaChi, NgaySinh, NgayTao, VaiTro)" +
                "                       VALUES('{0}', '{1}', '{2}', N'{3}', N'{4}','{5}', N'{6}', '{7}','{8}', '{9}')",
                                        them.TaiKhoan, them.MatKhau, them.MaTK, them.Email, them.TenND, them.SDT, them.DiaChi, them.NgaySinh, them.NgayTao, them.VaiTro);
            db.ThucHien(sql);
        }


        public NguoiDung LayTT(string ma)
        {
            conn.Open();
            string sql = string.Format("SELECT * FROM USERS WHERE MaTK = '{0}'", ma);
            
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NguoiDung a = new NguoiDung
                         (
                            (string)reader["TaiKhoan"], (string)reader["MatKhau"], (string)reader["MaTK"],
                            (string)reader["Email"], (string)reader["TenND"], (string)reader["Phone"], 
                            (string)reader["DiaChi"], (DateTime)reader["NgaySinh"], (DateTime)reader["NgayTao"],
                            (string)reader["VaiTro"]
                         );
                        conn.Close();
                        return a;

                    }
                }
            }
            return null;
        }

        public string LayMaTK(string ma) 
        {
            conn.Open();
            string sql = string.Format("SELECT * FROM USERS WHERE TaiKhoan = N'{0}'", ma);

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string a = (string)reader["MaTK"];
                        conn.Close();
                        return a;

                    }
                }
            }
            return null;
        }

        public string LayTenND(string ma)
        {
            conn.Open();
            string sql = string.Format("SELECT * FROM USERS WHERE TaiKhoan = N'{0}'", ma);

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string a = (string)reader["TenND"];
                        conn.Close();
                        return a;

                    }
                }
            }
            return null;
        }


        public DataTable  LayTaiKhoanTheoTK(string tu)
        {
            
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM USERS WHERE TenND LIKE @tu";
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
    }


}
