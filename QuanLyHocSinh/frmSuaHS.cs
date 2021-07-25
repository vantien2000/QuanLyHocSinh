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
                //kiểm tra rổng
                if (txtMa.Text == "" || txtTenHS.Text == "" || txtAnh.Text == "" || txtDiaChi.Text == ""
                    || txtSoDT.Text == "" || txtDiem.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                    return;
                }
                //kiểm tra điểm hợp lệ
                int diem = 0;
                if(int.Parse(txtDiem.Text) < 0)
                {
                    MessageBox.Show("điểm phải lớn hơn 0");
                    return;
                }
                else
                    diem = int.Parse(txtDiem.Text);

                //laays gioi tinh
                string gt = "";
                if (rdNam.Checked) gt = "Nam";
                else gt = "Nữ";

                //check điện thoại
                string sdt = "";
                if (txtSoDT.Text.Trim().Length > 10)
                {
                    MessageBox.Show("Số điện thoại không qúa 10 số");
                }
                else
                    sdt = txtSoDT.Text.Trim();
                //update student
                var updateStudent = db.UpdateStudent(
                        txtMa.Text,
                        diem,
                        cbbTenLop.SelectedValue.ToString(),
                        txtTenHS.Text,
                        txtAnh.Text,
                        txtNgaySinh.Value,
                        gt,
                        txtDiaChi.Text,
                        sdt
                    );

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
