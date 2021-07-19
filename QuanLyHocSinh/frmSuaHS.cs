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
    public partial class frmSuaHS : Form
    {
        private dbDataContext db = new dbDataContext();
        private ShowStudentByMaResult show = null;
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
            dbDataContext db = new dbDataContext();
            var names = (from _class in db.LopHocs
                         select new { _class.MaLop, _class.TenLop }).ToList();
            cbbTenLop.DataSource = names;
            cbbTenLop.DisplayMember = "TenLop";
            cbbTenLop.ValueMember = "MaLop";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
