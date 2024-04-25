using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DoAnCuoiKy
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public DBConnection()
        {

        }

        public DataTable Load(string sql)
        {
            DataTable dtSinhVien = new DataTable();
            try
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dtSinhVien);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtSinhVien;
        }

        public void ThucHien(string sql)
        {
            conn.Open();
            try
            {

                SqlCommand cmd = new SqlCommand(sql, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thanh cong");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public bool KiemTraDangNhap(string tk, string mk)
        {
            bool check = false;
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM USERS WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau", conn);
            command.Parameters.AddWithValue("@TaiKhoan", tk);
            command.Parameters.AddWithValue("@MatKhau", mk);

            try
            {
                conn.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    check = true;
                }
            }
            catch (Exception ex)
            {
      
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return check;
        }

        public string VaiTroND(string tk)
        {
            string role = "";

            // Kết nối đến cơ sở dữ liệu
            SqlCommand command = new SqlCommand("SELECT VaiTro FROM USERS WHERE TaiKhoan = @TaiKhoan", conn);
            command.Parameters.AddWithValue("@TaiKhoan", tk);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    role = reader["VaiTro"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return role;
        }

        
    }
}
