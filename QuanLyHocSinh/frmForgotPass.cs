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
        private dbDataContext db = new dbDataContext();
        public frmForgotPass()
        {
            InitializeComponent();
            loadCaptchaImage();
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
            try
            {
                var p = db.NhanViens.Single(tk => tk.TaiKhoan == txtTaiKhoan.Text.Trim());
                if (p!=null)
                {
                    this.Hide();
                    frmResetPass resetForm = new frmResetPass(txtTaiKhoan.Text);
                    resetForm.Show();
                }
                else
                {
                    MessageBox.Show("Xác thực không thành công!!!");
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
                
            
        }
    }
}
