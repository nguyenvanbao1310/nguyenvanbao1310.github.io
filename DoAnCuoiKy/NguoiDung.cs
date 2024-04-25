using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class NguoiDung
    {
        private string taiKhoan;
        private string matKhau;
        private string maTK;
        private string email;
        private string tenND;
        private string sDT;
        private string diaChi;
        private DateTime ngaySinh;
        private DateTime ngayTao;
        private string vaiTro;


        public NguoiDung(string taiKhoan, string matKhau, string maTK, string email, string tenND, string sDT, string diaChi, DateTime ngaySinh,
                       DateTime ngayTao, string vaiTro)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.maTK = maTK;
            this.email = email;
            this.tenND = tenND;
            this.sDT = sDT;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.ngayTao = ngayTao;
            this.vaiTro = vaiTro;
        }

        public string TaiKhoan { get {  return taiKhoan; } }

        public string MatKhau { get {  return matKhau; } }

        public string MaTK {  get { return maTK; } }

        public string Email { get { return email; } }

        public string TenND { get {  return tenND; } }

        public string SDT { get {  return sDT; } }

        public string DiaChi { get {  return diaChi; } }

        public DateTime NgaySinh { get { return ngaySinh; } }   

        public DateTime NgayTao { get { return ngayTao; } }

        public string VaiTro { get {  return vaiTro; } }


    }

   
}
