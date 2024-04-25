using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class SanPham
    {
        private string danhMuc;
        private string tenSP;
        private string maSP;
        private string mau;
        private int giaGoc;
        private int giaTien;
        private string tinhTrang;
        private string khuyenMai;
        private double danhGia;
        private string linhKien;
        private string baoHanh;
        private int soLuong;
        private string thongTin;
        private string phuKien;
        private DateTime ngayThem;
        private string fileAnh;

        public SanPham(string danhMuc, string tenSP, string maSP, string mau, int giaGoc,  int giaTien, string tinhTrang, string khuyenMai,
                       double danhGia, string linhKien, string baoHanh, int soLuong, string thongTin, string phuKien, DateTime ngayThem, string fileAnh)
        {
            this.danhMuc = danhMuc;
            this.tenSP = tenSP;
            this.maSP = maSP;
            this.mau = mau;
            this.giaGoc = giaGoc;
            this.giaTien = giaTien;
            this.tinhTrang = tinhTrang;
            this.khuyenMai = khuyenMai;
            this.danhGia = danhGia;
            this.linhKien = linhKien;
            this.baoHanh =  baoHanh;
            this.soLuong = soLuong;
            this.thongTin = thongTin;
            this.phuKien = phuKien;
            this.ngayThem = ngayThem;
            this.fileAnh = fileAnh;
        }

        public string DanhMuc
        {
            get { return danhMuc;} 
        }

        public string TenSP
        {
            get { return tenSP;} 
        }

        public string MaSP
        {
            get { return maSP;} 
        }

        public string Mau
        {
            get { return mau;}
        }

        public int GiaGoc
        {
            get { return giaGoc; }
        }

        public int GiaTien
        {
            get { return giaTien; }
        }

        public string TinhTrang
        {
            get { return tinhTrang; }
        }
        
        public string KhuyenMai
        {
            get { return khuyenMai;} 
        }

        public double DanhGia
        {
            get { return danhGia;}
        }

        public string LinhKien
        {
            get { return linhKien;}
        }


        public string BaoHanh
        {
            get { return baoHanh; }
        }
        

        public int SoLuong
        {
            get { return soLuong;} 
        }

        public string ThongTin
        {
            get { return thongTin; }
        }


        public string PhuKien
        {
            get { return phuKien; }
        }

        public DateTime NgayThem
        {
            get { return ngayThem; }
        }

        public string FileAnh
        {
            get { return fileAnh; }
        }
    }
}
