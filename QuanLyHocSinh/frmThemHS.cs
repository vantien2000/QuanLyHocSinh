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
    public partial class frmThemHS : Form
    {
        private dbDataContext db = new dbDataContext();
        private string fileName = "";
        public frmThemHS()
        {
            InitializeComponent();
            txtMaHS.Text = autoKeyHocSinh();
            loadCombobox();
        }
        private string pathImage()
        {
            string pathProject = Application.StartupPath;
            string newPath = pathProject.Substring(0, pathProject.Length - 23) + "Image" + '\\';
            return newPath;
        }

        private string autoKeyHocSinh()
        {
            string key = "";
            try
            {
                
                var studKey = (from stud in db.HocSinhs select stud.MaHS).ToList().Last().Trim();

                int number = int.Parse(studKey.Substring(2));

                if (number > 0 && number < 9)
                {
                    key = studKey.Substring(0, 2) + '0' + (number+1);
                }
                else
                {
                    key = studKey.Substring(0, 2) + (number+1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            return key;
            
        }

        private string autoKeyTHongTinCaNhan()
        {
            string key = "";
            try
            {
                var ttcnKey = (from ttcn in db.ThongTinCaNhans select ttcn.MaCN).ToList().Last().Trim();

                int number = int.Parse(ttcnKey.Substring(4));

                if (number > 0 && number < 9)
                {
                    key = ttcnKey.Substring(0, 4) + '0' + (number + 1);
                }
                else
                {
                    key = ttcnKey.Substring(0, 4) + (number + 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            return key;

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
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
                    if(!File.Exists(pathImage() + fileName))
                    {
                        File.Copy(openDlg.FileName, pathImage() + fileName);
                    }
                    txtAnh.Text = fileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra rổng
                if (txtMaHS.Text == "" || txtTenHS.Text == "" || txtAnh.Text == "" || txtDiaChi.Text == ""
                    || txtSoDT.Text == "" || txtDiem.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                    return;
                }
                //kiểm tra điểm hợp lệ
                int diem = 0;
                if (int.Parse(txtDiem.Text) < 0)
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
                var InsertStudent = db.InsertStudent(
                        txtMaHS.Text.Trim(),
                        diem,
                        cbbTenLop.SelectedValue.ToString(),
                        autoKeyTHongTinCaNhan(),
                        txtTenHS.Text,
                        txtAnh.Text,
                        dateNgaySinh.Value,
                        gt,
                        txtDiaChi.Text,
                        sdt
                    );

                db.SubmitChanges();
                frmQLHocSinh.getLoad.loadStudent();
                MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //dong form
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
    }
}
