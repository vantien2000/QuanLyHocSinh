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
    public partial class frmProfile : Form
    {
        private dbDataContext db = new dbDataContext();
        //private FindNVByMaResult show = null;
        private NhanVien nVien;
        private string fileName = "";
        public frmProfile(NhanVien nv)
        {
            InitializeComponent();
            nVien = nv;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra rổng
                if (txtMa.Text == "" || txtHoTen.Text == "" || txtAnh.Text == "" || txtDiaChi.Text == ""
                    || txtSoDT.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                    return;
                }

                //lấy gioi tinh
                string gt = "";
                if (rdbNam.Checked) gt = "Nam";
                else gt = "Nữ";

                //check điện thoại
                string sdt = "";
                if (txtSoDT.Text.Trim().Length > 10)
                {
                    MessageBox.Show("Số điện thoại không quá 10 số");
                }
                else
                    sdt = txtSoDT.Text.Trim();
                //update infor
                var updateInfor = db.UpdateInfor(
                        txtMa.Text,
                        txtHoTen.Text,
                        txtAnh.Text,
                        txtNgaySinh.Value,
                        gt,
                        txtDiaChi.Text,
                        sdt
                    );

                db.SubmitChanges();
                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                frmProfile_Load(sender, e);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private string pathImage()
        {
            string pathProject = Application.StartupPath;
            string newPath = pathProject.Substring(0, pathProject.Length - 23) + "Image" + '\\';
            return newPath;
        }
        public void frmProfile_Load(object sender, EventArgs e)
        {
            var showNV = db.NhanViens.Single(x => x.MaNV == nVien.MaNV);
            txtMa.Text = showNV.MaNV;
            txtHoTen.Text = showNV.ThongTinCaNhan.HoTen;
            txtAnh.Text = showNV.ThongTinCaNhan.Anh;
            pictureAnh.Image = new Bitmap(pathImage() + showNV.ThongTinCaNhan.Anh);
            txtNgaySinh.Value = showNV.ThongTinCaNhan.NgaySinh.Value;
            if (showNV.ThongTinCaNhan.GioiTinh.ToString().Trim().Equals("Nam")) 
                rdbNam.Checked = true;
            else 
                rdbNu.Checked = true;
            txtDiaChi.Text = showNV.ThongTinCaNhan.DiaChi;
            txtSoDT.Text = showNV.ThongTinCaNhan.SDT;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
