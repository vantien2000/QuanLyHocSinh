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
    public partial class frmForgotPass : Form
    {
        private string user, pass;
        public frmForgotPass(string user,string pass)
        {
            InitializeComponent();
            loadCaptchaImage();
            this.user = user;
            this.pass = pass;
        }
        int number = 0;
        private void loadCaptchaImage()
        {
            Random rd = new Random();
            number = rd.Next(100, 1000);
            var image = new Bitmap(this.pictureCaptcha.Width, this.pictureCaptcha.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(number.ToString(), font, Brushes.Green, new Point(0, 0));
            pictureCaptcha.Image = image;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadCaptchaImage();
        }

        private void btnYeuCau_Click(object sender, EventArgs e)
        {
            if (txtXacThuc.Text == number.ToString() && txtTaiKhoan.Text == user)
            {
                this.Hide();
                frmResetPass resetForm = new frmResetPass(user,pass);
                resetForm.Show();
            }
            else
            {
                MessageBox.Show("Xác thực không thành công!!!");
            }
        }
    }
}
