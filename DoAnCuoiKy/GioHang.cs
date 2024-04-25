using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class GioHang
    {
        private string maTK;
        private string maSP;
        private string tenSP;
        private int gia;
        private string anh;


        public GioHang(string maTK, string maSP, string tenSP, int gia, string anh)
        {
            this.maTK = maTK;
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.gia = gia;
            this.anh = anh;
        }

        public string MaTK { get { return maTK;} }


        public string MaSP { get { return maSP; } }

        public string TenSP { get { return tenSP;} }

        public int Gia { get {  return gia; } }

        public string Anh { get {  return anh; } }

    }
}
