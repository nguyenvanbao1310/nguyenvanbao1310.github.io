using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCuoiKy
{
    public partial class Form1 : Form
    {
        public static string matk;
        public static string ten;
        private DBConnection db = new DBConnection();
        private TaiKhoanDAO tk = new TaiKhoanDAO();

        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
                if (txtTaiKhoan.Text == "Username|")
                {
                    txtTaiKhoan.Text = "";
                }
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Password|")
            {
                txtMatKhau.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if(db.KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == true)
            {
                string vt = db.VaiTroND(txtTaiKhoan.Text);
                if(vt == "Admin")
                {
                    matk = tk.LayMaTK(txtTaiKhoan.Text);
                    ten = tk.LayTenND(txtTaiKhoan.Text);
                    FGiaoDienQL f = new FGiaoDienQL();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    matk = tk.LayMaTK(txtTaiKhoan.Text);
                    ten = tk.LayTenND(txtTaiKhoan.Text);
                    FGiaoDien f = new FGiaoDien();
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Thông tin tài khoàn hoặc mật khẩu không chính xác. Vui lòng nhập lại");
            }
        }

        private void llblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FDangKy f = new FDangKy();
            f.ShowDialog();
        }

        private void pAn_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.PasswordChar == '*')
            {
                pHien.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void pHien_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                pAn.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }
    }
}
