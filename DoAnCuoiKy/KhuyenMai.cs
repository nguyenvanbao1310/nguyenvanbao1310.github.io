using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    internal class KhuyenMai
    {
        private string loaiKM;
        private string tenKM;
        private int gia;
        private DateTime ngayBD;
        private DateTime ngayKT;


        public KhuyenMai(string loaiKM, string tenKM, int gia, DateTime ngayBD, DateTime ngayKT)
        {
            this.loaiKM = loaiKM;
            this.tenKM = tenKM;
            this.gia = gia;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
        }

        public string LoaiKM {  get { return loaiKM; } }

        public string TenKM { get { return tenKM; } }

        public int Gia { get { return gia;} }

        public DateTime NgayBD {  get { return ngayBD; } }

        public DateTime NgayKT { get {  return ngayKT; } }
    }
}
