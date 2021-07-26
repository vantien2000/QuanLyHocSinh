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
    public partial class frmResetPass : Form
    {
        private string user;
        public frmResetPass(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            if(txtMK.Text == txtXacThuc.Text)
            {
                using(dbDataContext db = new dbDataContext())
                {
                    var updatePass = db.NhanViens.Where(w => w.TaiKhoan == user).Select(x => x).Single();
                    updatePass.MatKhau = txtXacThuc.Text.Trim();
                    db.SubmitChanges();
                    MessageBox.Show("Đặt Lại Mật Khẩu Thành Công!!");
                    this.Hide();
                    frmLogin login = new frmLogin(user, txtMK.Text);
                    login.Show();
                }
            }
            else
            {
                MessageBox.Show("Mật khâủ không khớp!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        
    }
}
