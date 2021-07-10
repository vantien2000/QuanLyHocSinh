using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmLogin : Form
    {
        private string USER_NAME = "admin";
        private string PASSWORD = "admin";
        int solanClick = 1;
        public frmLogin()
        {
            InitializeComponent();
            //tắt label thông báo
            lblThongBao.Visible = false;
            //dặt lại user name và pass
            
            //Form
            this.Text = string.Empty;
            //Tắt control của form
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        public frmLogin(string user,string pass)
        {
            InitializeComponent();
            this.USER_NAME = user;
            this.PASSWORD = pass;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == USER_NAME && txtPass.Text == PASSWORD)
            {
                this.Hide();
                frmAdmin admin = new frmAdmin(USER_NAME,PASSWORD);
                admin.Show();
            }
            else
            {
                lblThongBao.Text = "Nhập sai mật khẩu quá 5 lần. Tài khoản sẽ bị khóa";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                lblThongBao.Visible = true;
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (solanClick == 5)
                {
                    txtUser.Enabled = false;
                    txtPass.Enabled = false;
                    lblThongBao.Text = "Bạn đã Nhập sai mật khẩu quá 5 lần. Không thể đăng nhập";
                    lblThongBao.ForeColor = System.Drawing.Color.Red;
                    btnDangNhap.Enabled = false;
                }
                solanClick++;
            }
            
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ForgetPass(object sender, EventArgs e)
        {
            this.Hide();
            frmForgotPass fgpFrom = new frmForgotPass(USER_NAME,PASSWORD);
            fgpFrom.Show();
        }
    }
}
