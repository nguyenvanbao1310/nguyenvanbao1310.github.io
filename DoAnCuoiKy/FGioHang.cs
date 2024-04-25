using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FGioHang : Form
    {
        private GioHangDAO gh = new GioHangDAO();
        private KhoHangDAO kh = new KhoHangDAO();
        private DonHangDAO dh = new DonHangDAO();

        public FGioHang()
        {
            InitializeComponent();
            
        }

        private void FGioHang_Load(object sender, EventArgs e)
        {
            List<GioHang> lgh = gh.LayTT(Form1.matk);
            List<UCGioHang> ugh = new List<UCGioHang>();

            foreach (GioHang a in lgh)
            {
                UCGioHang uc = new UCGioHang();
                uc.lblMaSP.Text = a.MaSP.ToString();
                uc.lblTenSP.Text = a.TenSP.ToString();
                uc.lblGiaTien.Text= (a.Gia*1000).ToString();
                uc.picHinhAnh.Image = Image.FromFile(a.Anh);
                uc.picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                ugh.Add(uc);
            }
            

            int productPerRow = 1;
            int ucWidth = (FPanel.Width / productPerRow) ;

            foreach (UCGioHang a in ugh)
            {

                a.Width = ucWidth;
                FPanel.Controls.Add(a);
                a.CancelButtonClicked += SanPham_Huy;
                a.CancelButtonClicked += MuaSanPham;
            }

            
        }

        private void SanPham_Huy(object sender, EventArgs e)
        {
            UCGioHang sp = (UCGioHang)sender;
            gh.XoaSanPham(sp.lblMaSP.Text);
            FPanel.Controls.Clear();
            FGioHang_Load(sender, e);
        }

        private void MuaSanPham(object sender , EventArgs e)
        {
            UCGioHang sp = (UCGioHang)sender;
            KhoHang a = kh.LayTTNguoiBan(sp.lblMaSP.Text);
            DonHang them = new DonHang
            (
                sp.lblMaSP.Text + DateTime.Now.ToString("dd/MM/yy"), Form1.matk, a.NguoiBan,
                sp.lblMaSP.Text, DateTime.Now, int.Parse(sp.lblGiaTien.Text), "Chua thanh toan", "Chua giao hang"
            );
            dh.ThemDonHang(them);
        }
    }
}
