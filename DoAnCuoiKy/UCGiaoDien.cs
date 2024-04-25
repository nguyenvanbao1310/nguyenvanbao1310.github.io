using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoAnCuoiKy
{
    public partial class UCGiaoDien : UserControl
    {
        private Form current;

        public UCGiaoDien()
        {
          
            InitializeComponent();
        }

        public Button btnDangXuat1 => btnDangXuat;
        public Button btnTrangChu1 => btnTrangChu;

        private void UCGiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void OpenFrom(Form child)
        {
            if (current != null) 
            {
                current.Close();
            }
            current = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlChuyenTiep.Controls.Add(child);
            pnlChuyenTiep.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            FThongTin f= new FThongTin();
            OpenFrom(f);
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FCongCu f = new FCongCu();
            OpenFrom(f);
        }

        
    }
}
