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
    public partial class FQLNV : Form
    {
        DBConnection db = new DBConnection();
        public FQLNV()
        {
            InitializeComponent();
        }

        private void ucQuanLy1_Load(object sender, EventArgs e)
        {
            string sqlStr = string.Format("SELECT *FROM NHANVIEN");

            ucQuanLy1.dgvQL.DataSource = db.Load(sqlStr);
        }
    }
}
