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
    public partial class FThongTin : Form
    {
        private Form current;
        public FThongTin()
        {
            InitializeComponent();
            
        }

        

        private void OpenForm(Form child)
        {
            if (current != null)
            {
                current.Close();
            }
            current = child;
            child.TopLevel = false;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Add(child);
            pnlHienThi.Tag = child;
            child.Show();
        }

        private void lblDoiMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FMatKhau f  = new FMatKhau();
            OpenForm(f);
        }

        /*private void lblThongTinLH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FThongTinLH f = new FThongTinLH(ma);
            OpenForm(f);
        }*/
    }
}
