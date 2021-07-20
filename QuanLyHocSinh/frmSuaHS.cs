using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmSuaHS : Form
    {
        private dbDataContext db = new dbDataContext();
        private ShowStudentByMaResult show = null;
        private string fileName = "";
        public frmSuaHS(ShowStudentByMaResult result)
        {
            InitializeComponent();
            show = result;
        }
        private string pathImage()
        {
            string pathProject = Application.StartupPath;
            string newPath = pathProject.Substring(0, pathProject.Length - 23) + "Image" + '\\';
            return newPath;
        }
        private void frmSuaHS_Load(object sender, EventArgs e)
        {
            txtMa.Text = show.MaHS;
            txtTenHS.Text = show.HoTen;
            txtAnh.Text = show.Anh;
            pictureAnh.Image = new Bitmap(pathImage() + show.Anh);
            txtNgaySinh.Value = show.NgaySinh.Value;
            txtTuoi.Text = show.Tuoi+"";
            if (show.GioiTinh == "Nam") rdNam.Select();
            else rdNu.Select();
            txtDiaChi.Text = show.DiaChi;
            txtSoDT.Text = show.SDT;
            txtDiem.Text = show.DiemDauVao + "";
            loadCombobox();
            cbbTenLop.Text = show.TenLop;
        }

        private void loadCombobox()
        {
            var names = (from _class in db.LopHocs
                         select new { _class.MaLop, _class.TenLop }).ToList();
            cbbTenLop.DataSource = names;
            cbbTenLop.DisplayMember = "TenLop";
            cbbTenLop.ValueMember = "MaLop";
        }


        private void btnChonFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.Title = "Open Image";
                openDlg.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
                openDlg.InitialDirectory = @"C:\";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    pictureAnh.Image = Image.FromFile(openDlg.FileName);
                    fileName = Path.GetFileName(openDlg.FileName);
                    if (!File.Exists(pathImage() + fileName))
                    {
                        File.Copy(openDlg.FileName, pathImage() + fileName);
                    }
                    txtAnh.Text = fileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var getStud = db.HocSinhs.FirstOrDefault(x => x.MaHS == txtMa.Text);
                var getProfile = db.ThongTinCaNhans.FirstOrDefault(x => x.MaCN == getStud.MaCN);
                MessageBox.Show(getStud.MaHS);
                //sửa bang hoc sinh
                //if (int.Parse(txtDiem.Text) < 0)
                //{
                //    MessageBox.Show("điểm phải lớn hơn 0");
                //    return;
                //}
                //else
                //    getStud.DiemDauVao = int.Parse(txtDiem.Text);
                //getStud.MaLop = cbbTenLop.SelectedValue.ToString();

                ////sua bảng cá nhân
                //getProfile.HoTen = txtTenHS.Text;
                //getProfile.Anh = txtAnh.Text;
                ////kiểm tra rổng
                //if (txtMa.Text == "" || txtTenHS.Text == "" || txtAnh.Text == "" || txtTuoi.Text == "" || txtDiaChi.Text == ""
                //    || txtSoDT.Text == "" || txtDiem.Text == "")
                //{
                //    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                //    return;
                //}
                ////kiểm tra tuổi hợp lệ
                //if (int.Parse(txtTuoi.Text) <= 0)
                //{
                //    MessageBox.Show("Tuổi phải lớn hơn 0");
                //    return;
                //}
                //else
                //    getProfile.Tuoi = int.Parse(txtTuoi.Text);
                //string gt = "";
                //if (rdNam.Checked) gt = "Nam";
                //else gt = "Nữ";

                //getProfile.GioiTinh = gt;
                //getProfile.NgaySinh = txtNgaySinh.Value;
                //getProfile.DiaChi = txtDiaChi.Text;
                //getProfile.SDT = txtSoDT.Text;

                db.SubmitChanges();
                frmQLHocSinh.getLoad.loadStudent();
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //dong form
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
