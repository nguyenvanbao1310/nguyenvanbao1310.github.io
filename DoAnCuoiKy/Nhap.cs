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
    public partial class Nhap : Form
    {
        private SanPhamDAO sp = new SanPhamDAO();
        public Nhap()
        {
            InitializeComponent();
        }

        private void dgvGird_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                

        }

        private void Nhap_Load(object sender, EventArgs e)
        {
            dgvGird.DataSource = sp.LoadTT();
        }
    }
}
