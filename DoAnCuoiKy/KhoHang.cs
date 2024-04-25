using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    
    public class KhoHang
    {
        private string maSP;
        private string tenSP;
        private string nguoiBan;
        private string maTK;
        private DateTime ngayDang;
        private DateTime ngayHetHan;

        public KhoHang(string maSP, string tenSP, string nguoiBan, string maTK, DateTime ngayDang, DateTime ngayHetHan)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.nguoiBan = nguoiBan;
            this.maTK = maTK;
            this.ngayDang = ngayDang;
            this.ngayHetHan = ngayHetHan;
        }

        public string MaSP { get { return maSP; } }

        public string TenSP { get { return tenSP; } }

        public string NguoiBan { get {  return nguoiBan; } }

        public string MaTK { get {  return maTK; } }

        public DateTime NgayDang {  get { return ngayDang; } }

        public DateTime NgayHetHan {  get { return ngayHetHan; } }

        
    }
}
