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
    public class SanPhamDAO
    {
        DBConnection db = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public SanPhamDAO()
        {

        }

        public DataTable LoadTT()
        {
            string sqlStr = string.Format("SELECT *FROM SANPHAM");

            return db.Load(sqlStr);
        }

        public void ThemSanPham(SanPham them)
        {

            string sql = string.Format("INSERT INTO SANPHAM(DANHMUC, TENSP, MASP, MAU, GIAGOC, GIA, TINHTRANG, KHUYENMAI, DANHGIA, LINHKIEN, BAOHANH, SOLUONG, THONGTIN, PHUKIEN, NGAYTHEM, FILEANH) VALUES(N'{0}', N'{1}',N'{2}',N'{3}','{4}','{5}', N'{6}',N'{7}','{8}',N'{9}',N'{10}', '{11}', N'{12}', N'{13}', '{14}', '{15}')",
                                        them.DanhMuc, them.TenSP, them.MaSP, them.Mau, them.GiaGoc,  them.GiaTien, them.TinhTrang, them.KhuyenMai, them.DanhGia, them.LinhKien, them.BaoHanh, them.SoLuong, them.ThongTin, them.PhuKien, them.NgayThem, them.FileAnh);
            db.ThucHien(sql);
        }

        public void XoaSanPham(string xoa)
        {
            string SQL = string.Format("DELETE FROM SANPHAM WHERE MASP= '{0}'", xoa);
            db.ThucHien(SQL);
        }

        public void SuaSanPham(SanPham sua)
        {
            string sql = string.Format("UPDATE SANPHAM SET DANHMUC = N'{0}', TENSP = N'{1}', MAU = N'{3}', GIAGOC= '{4}', GIA = '{5}', TINHTRANG= N'{6}', KHUYENMAI = N'{7}', DANHGIA = '{8}', LINHKIEN = N'{9}', BAOHANH= N'{10}', SOLUONG='{11}', THONGTIN= N'{12}', PHUKIEN = N'{13}', NGAYTHEM = '{14}', FILEANH = N'{15}' WHERE MASP = N'{2}'",
                                        sua.DanhMuc, sua.TenSP, sua.MaSP, sua.Mau, sua.GiaGoc, sua.GiaTien, sua.TinhTrang, sua.KhuyenMai, sua.DanhGia, sua.LinhKien, sua.BaoHanh, sua.SoLuong, sua.ThongTin, sua.PhuKien, sua.NgayThem, sua.FileAnh);
            db.ThucHien(sql);
        }


        public DataTable LaySanPhamTheoTK(string tu)
        {

            DataTable dt = new DataTable();
            string sql = "SELECT * FROM SANPHAM WHERE TENSP LIKE @tu";
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

        


        /*public void ThucThi(string sqlStr)
        {
            db.ThucHien(sqlStr);
        }*/
    }
}
