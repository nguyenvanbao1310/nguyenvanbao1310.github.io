using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FShopDo : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        private List<SanPham> sp;


        public FShopDo(List<SanPham> sp)
        {
            this.sp = sp;
            InitializeComponent();
            
        }
       

        private void ShopDo_Load(object sender, EventArgs e)
        {
            List<UCSanPham> usp = new List<UCSanPham>();
            foreach (SanPham a in sp)
            {
                UCSanPham uc = new UCSanPham();
                uc.lblTenSP.Text = a.TenSP.ToString();
                uc.lblGiaTien.Text = (a.GiaGoc*1000).ToString();
                uc.lblGiaBan.Text = (a.GiaTien * 1000).ToString();
                uc.picAnhSP.Image = Image.FromFile(a.FileAnh);
                uc.picAnhSP.SizeMode = PictureBoxSizeMode.Zoom;
                usp.Add(uc);
            }


            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.AutoScroll = true;
            flowPanel.FlowDirection = FlowDirection.LeftToRight;
            flowPanel.WrapContents = true;


            flowPanel.Width = this.ClientSize.Width;
            this.Controls.Add(flowPanel);

            int productPerRow = 3;
            int ucWidth = (flowPanel.Width / productPerRow) - 30;

            foreach (UCSanPham a in usp)
            {

                a.Width = ucWidth;
                flowPanel.Controls.Add(a);
            }

        }
    }
}
