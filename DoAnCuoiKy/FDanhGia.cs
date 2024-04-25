using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace DoAnCuoiKy
{
  
    public partial class FDanhGia : Form
    {
        private NguoiDung a;
        private DanhGiaDAO dao = new DanhGiaDAO();
        private int cur = 10;
        public FDanhGia(NguoiDung a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void FDanhGia_Load(object sender, EventArgs e)
        {
            List<DanhGia> dg = dao.LoadTT(a.MaTK);
            List<UCDanhGia> udg = new List<UCDanhGia>();
            
            foreach (DanhGia a in dg)
            {
                UCDanhGia uc = new UCDanhGia();
                uc.lblTenSP.Text = a.TenSP.ToString();
                uc.lblMaDH.Text = a.MaDH.ToString();
                uc.lblNguoiMua.Text = a.TenNguoiMua.ToString();
                uc.lblKHDG.Text = a.KhachDG.ToString();
                uc.lblPhanHoi.Text = a.PhanHoiDG.ToString();
                uc.picHinhAnh.Image = Image.FromFile(a.FileAnh);
                uc.picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                udg.Add(uc);
            }
            foreach (var u in udg)
            {
                u.Margin = new Padding(0, cur, 0, 0);
                pnlDanhGia.Controls.Add(u);
                u.Dock = DockStyle.Top;
                cur += u.Height + 10;
            }
           

        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            FGhiDanhGia f = new FGhiDanhGia(a);
            f.ShowDialog();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnlDanhGia.Controls.Clear();
            FDanhGia_Load(sender, e);
        }
    }
}
