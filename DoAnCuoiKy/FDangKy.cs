using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FDangKy : Form
    {
        public FDangKy()
        {
            InitializeComponent();
            lblcheck.Visible = false;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Đăng Ký Thành Công!");
            this.Close();
        }
    }
}
