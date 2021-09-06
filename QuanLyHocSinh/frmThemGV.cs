using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace QuanLyHocSinh
{
    public partial class frmThemGV : Form
    {
        private dbDataContext db = new dbDataContext();
        private string fileName = "";
        public frmThemGV()
        {
            InitializeComponent();
            //txtMaGV.Text = autoKeyGiaoVien();
            var teachKey = (from teach in db.GVCNs select teach.MaGV).ToList().Last().Trim();
        }
        private string pathImage()
        {
            string pathProject = Application.StartupPath;
            string newPath = pathProject.Substring(0, pathProject.Length - 23) + "Image" + '\\';
            return newPath;
        }

        private string autoKeyGiaoVien()
        {
            string key = "";
            try
            {

                var teachKey = (from teach in db.GVCNs select teach.MaGV).ToList().Last().Trim();

                int number = int.Parse(teachKey.Substring(2));
                key = teachKey.Substring(0, 2);
                //if (number > 0 && number < 9)
                //{
                //    key = teachKey.Substring(0, 2) + '0' + (number + 1);
                //}
                //else
                //{
                //    key = teachKey.Substring(0, 2) + (number + 1);
                //}
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

        private void btnChonFile_Click_1(object sender, EventArgs e)
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
                    || txtSoDT.Text == "" )
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                    return;
                }
                
                //lấy gioi tinh
                string gt = "";
                if (rdNam.Checked) gt = "Nam";
                else gt = "Nữ";

                //check điện thoại
                string sdt = "";
                if (txtSoDT.Text.Trim().Length > 10)
                {
                    MessageBox.Show("Số điện thoại không quá 10 số");
                }
                else
                    sdt = txtSoDT.Text.Trim();
                //update student
                var InsertTeacher = db.InsertTeacher(
                        txtMaGV.Text.Trim(),
                        autoKeyTHongTinCaNhan(),
                        txtTenGV.Text,
                        txtAnh.Text,
                        dateNgaySinh.Value,
                        gt,
                        txtDiaChi.Text,
                        sdt
                    );

                db.SubmitChanges();
                frmQLGiaoVien.getLoad.loadTeacher();
                MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
