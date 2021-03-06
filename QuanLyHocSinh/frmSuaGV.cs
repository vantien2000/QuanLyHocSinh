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

    public partial class frmSuaGV : Form
    {
        private dbDataContext db = new dbDataContext();
        private FindTeacherByMaResult show = null;
        private string fileName = "";
        private FindStudentByMaResult show1;

        public frmSuaGV(FindTeacherByMaResult result)
        {
            InitializeComponent();
            show = result;
        }

        public frmSuaGV(FindStudentByMaResult show1)
        {
            this.show1 = show1;
        }

        private string pathImage()
        {
            string pathProject = Application.StartupPath;
            string newPath = pathProject.Substring(0, pathProject.Length - 23) + "Image" + '\\';
            return newPath;
        }

        private void frmSuaGV_Load(object sender, EventArgs e)
        {
            txtMaGV.Text = show.MaGV;
            txtTenGV.Text = show.HoTen;
            txtAnh.Text = show.Anh;
            pictureAnh.Image = new Bitmap(pathImage() + show.Anh);
            dtpNS.Value = show.NgaySinh.Value;
            if (show.GioiTinh.ToString().Trim().Equals("Nam"))
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            txtDiaChi.Text = show.DiaChi;
            txtSoDT.Text = show.SDT;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra rổng
                if (txtMaGV.Text == "" || txtTenGV.Text == "" || txtAnh.Text == "" || txtDiaChi.Text == ""
                    || txtSoDT.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                    return;
                }


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
                var updateStudent = db.UpdateTeacher(
                        txtMaGV.Text,
                        txtTenGV.Text,
                        txtAnh.Text,
                        dtpNS.Value,
                        gt,
                        txtDiaChi.Text,
                        sdt
                    );

                db.SubmitChanges();
                frmQLGiaoVien.getLoad.loadTeacher();
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //dong form
                Close();
            }
            catch (Exception ex)
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
