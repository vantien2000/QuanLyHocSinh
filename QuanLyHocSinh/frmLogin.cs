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
        private dbDataContext db = new dbDataContext();
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
            var p = db.NhanViens.Single(tk => tk.TaiKhoan == user);
            p.MatKhau = pass;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tài khoản và mật khẩu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                NhanVien p = db.NhanViens.Where(tk => tk.TaiKhoan == txtUser.Text.Trim() && tk.MatKhau == txtPass.Text).Select(x => x).FirstOrDefault();

                if (p != null)
                {
                    this.Hide();
                    frmAdmin admin = new frmAdmin(p);
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblThongBao.Text = "Nhập sai mật khẩu quá 5 lần. Tài khoản sẽ bị khóa";
                    lblThongBao.ForeColor = System.Drawing.Color.Red;
                    lblThongBao.Visible = true;
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ForgetPass(object sender, EventArgs e)
        {
            this.Hide();
            frmForgotPass fgpFrom = new frmForgotPass();
            fgpFrom.Show();
        }


    }
}
