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
            dbDataContext db = new dbDataContext();
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

                HocSinh stud = new HocSinh();
                ThongTinCaNhan ttcn = new ThongTinCaNhan();

                ttcn.MaCN = autoKeyTHongTinCaNhan();
                ttcn.HoTen = txtTenHS.Text;
                ttcn.Anh = txtAnh.Text;
                //kiểm tra rổng
                if(txtMaHS.Text == "" || txtTenHS.Text == "" || txtAnh.Text == "" || txtTuoi.Text == "" || txtDiaChi.Text == ""
                    || txtSoDT.Text == "" || txtDiem.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                    return;
                }
                //kiểm tra tuổi hợp lệ
                if(int.Parse(txtTuoi.Text) <= 0)
                {
                    MessageBox.Show("Tuổi phải lớn hơn 0");
                    return;
                }    
                else
                    ttcn.Tuoi = int.Parse(txtTuoi.Text);
                string gt = "";
                if (rdNam.Checked) gt = "Nam";
                else gt = "Nữ";

                ttcn.GioiTinh = gt;
                ttcn.NgaySinh = dateNgaySinh.Value;
                ttcn.DiaChi = txtDiaChi.Text;
                ttcn.SDT = txtSoDT.Text;

                //Them bang hoc sinh
                stud.MaHS = txtMaHS.Text;
                if (int.Parse(txtDiem.Text) < 0)
                {
                    MessageBox.Show("điểm phải lớn hơn 0");
                    return;
                }
                else
                    stud.DiemDauVao = int.Parse(txtDiem.Text);
                stud.MaLop = cbbTenLop.SelectedValue.ToString();
                stud.MaCN = autoKeyTHongTinCaNhan();
                db.HocSinhs.InsertOnSubmit(stud);
                db.ThongTinCaNhans.InsertOnSubmit(ttcn);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                frmQLHocSinh.getLoad.loadStudent();
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
