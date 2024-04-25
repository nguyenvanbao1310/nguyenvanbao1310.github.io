using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class DonHang
    {
        private string maDH;
        private string maND;
        private string tenNguoiBan;
        private string maSP;
        private DateTime ngayTao;
        private int tongTien;
        private string trangThaiTT;
        private string trangThaiGH;

        public DonHang(string maDH, string maND, string tenNguoiBan,  string maSP, DateTime ngayTao, int tongTien, string trangThaiTT, string trangThaiGH)
        {
            this.maDH = maDH;
            this.maND = maND;
            this.tenNguoiBan = tenNguoiBan;
            this.maSP = maSP;
            this.ngayTao = ngayTao;
            this.tongTien = tongTien;
            this.trangThaiTT = trangThaiTT;
            this.trangThaiGH = trangThaiGH;
            
        }

        public string MaDH {  get { return maDH; } }

        public string MaND { get {  return maND; } }

        public string TenNguoiBan {  get { return tenNguoiBan; } }

        public string MaSP { get { return maSP; } }

        public DateTime NgayTao {  get { return ngayTao; } }

        public int TongTien { get { return tongTien; } }

        public string TangThaiTT { get {  return trangThaiTT; } }

        public string TangThaiGH { get {  return trangThaiGH; } }

    }
}
