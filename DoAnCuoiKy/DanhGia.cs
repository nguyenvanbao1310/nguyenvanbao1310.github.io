using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class DanhGia
    {
        private string ma;
        private string tenNguoiBan;
        private string tenSP;
        private string maDH;
        private string tenNguoiMua;
        private string khachDG;
        private string phanHoiDG;
        private string fileAnh;
        public DanhGia( string ma, string tenNguoiBan, string tenSP, string maDH, string tenNguoiMua, string khachDG, string phanHoiDG, string fileAnh)
        {
            this.ma = ma;
            this.tenNguoiBan = tenNguoiBan;
            this.tenSP = tenSP;
            this.maDH = maDH;
            this.tenNguoiMua = tenNguoiMua;
            this.khachDG = khachDG;
            this.phanHoiDG = phanHoiDG;
            this.fileAnh = fileAnh;
        }

        public string Ma {  get { return ma; } }

        public string TenNguoiBan { get { return tenNguoiBan; } }

        public string TenSP { get { return tenSP; } }

        public string MaDH { get {  return maDH; } }

        public string TenNguoiMua {  get { return tenNguoiMua;} }

        public string KhachDG { get {  return khachDG; } }

        public string PhanHoiDG { get { return phanHoiDG;} }

        public string FileAnh {  get { return fileAnh; } }

    }
}
