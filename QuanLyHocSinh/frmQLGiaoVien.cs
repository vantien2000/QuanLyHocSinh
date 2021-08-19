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
    public partial class frmQLGiaoVien : Form
    {
        private dbDataContext db = new dbDataContext();
        private FindStudentByMaResult show = null;
        public static frmQLGiaoVien getLoad;

        public frmQLGiaoVien()
        {
            InitializeComponent();
            getLoad = this;
        }
        private string pathImage()
        {
            string pathProject = Application.StartupPath;
            string newPath = pathProject.Substring(0, pathProject.Length - 23) + "Image" + '\\';
            return newPath;
        }

        public void loadTeacher()
        {
            try
            {
                int index = 0;
                dgvGiaoVien.Rows.Clear();
                dgvGiaoVien.RowTemplate.Height = 80;
                foreach (var teach in db.ShowTeacher())
                {
                    dgvGiaoVien.Rows.Add();
                    dgvGiaoVien.Rows[index].Cells[0].Value = teach.MaGV.ToString();
                    dgvGiaoVien.Rows[index].Cells[1].Value = new Bitmap(pathImage() + teach.Anh);
                    dgvGiaoVien.Rows[index].Cells[2].Value = teach.HoTen;
                    dgvGiaoVien.Rows[index].Cells[3].Value = teach.NgaySinh.Value.ToString("dd/MM/yyyy");
                    dgvGiaoVien.Rows[index].Cells[4].Value = teach.GioiTinh;
                    dgvGiaoVien.Rows[index].Cells[5].Value = teach.DiaChi;
                    dgvGiaoVien.Rows[index].Cells[6].Value = teach.SDT;
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void frmQLGiaoVien_Load(object sender, EventArgs e)
        {
            loadTeacher();
            dgvGiaoVien.CurrentCell.Selected = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemGV themGV = new frmThemGV();
            themGV.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã để tìm kiếm!!!", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    return;
                }
                dgvGiaoVien.Rows.Clear();
                dgvGiaoVien.RowTemplate.Height = 80;
                var teach = db.FindTeacherByMa(txtSearch.Text.Trim()).Single();
                dgvGiaoVien.Rows.Add();
                dgvGiaoVien.Rows[0].Cells[0].Value = teach.MaGV.ToString();
                dgvGiaoVien.Rows[0].Cells[1].Value = new Bitmap(pathImage() + teach.Anh);
                dgvGiaoVien.Rows[0].Cells[2].Value = teach.HoTen;
                dgvGiaoVien.Rows[0].Cells[3].Value = teach.NgaySinh.Value.ToString("dd/MM/yyyy");
                dgvGiaoVien.Rows[0].Cells[4].Value = teach.GioiTinh;
                dgvGiaoVien.Rows[0].Cells[5].Value = teach.DiaChi;
                dgvGiaoVien.Rows[0].Cells[6].Value = teach.SDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            frmQLGiaoVien_Load(sender, e);
        }
    }
}
