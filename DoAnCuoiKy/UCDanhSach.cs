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
    public partial class UCGioHang : UserControl
    {
        private GioHangDAO gh = new GioHangDAO();
        
        public UCGioHang()
        {
            InitializeComponent();

            
        }

        public event EventHandler CancelButtonClicked;

        private void btnHuy_Click(object sender, EventArgs e)
        {
            CancelButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            CancelButtonClicked?.Invoke(this, EventArgs.Empty);

        }
    }
}
