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
    public partial class UCQuanLy : UserControl
    {
       
        public UCQuanLy()
        {
            InitializeComponent();
        }

        public DataGridView dgvQL => dgvQLNV;

        private void picChinhSua_Click(object sender, EventArgs e)
        {
                FChinhSuaNV f = new FChinhSuaNV();
                f.Show();
        }

        private void UCQuanLy_Load(object sender, EventArgs e)
        {
           
        }
    }
}
