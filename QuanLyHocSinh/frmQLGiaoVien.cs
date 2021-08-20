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
        private FindTeacherByMaResult show = null;
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.SelectedRows.Count > 0 && dgvGiaoVien.SelectedRows.Count <= 1)
            {
                frmSuaGV suaGV = new frmSuaGV(show);
                suaGV.Show();
            }
            else if (dgvGiaoVien.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ chọn một giáo viên để sửa!!!", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giáo viên!!!", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dgvGiaoVien.SelectedRows.Count;
            if (selectedRow > 0 && selectedRow <= 1)
            {
                string keyStud = dgvGiaoVien.SelectedRows[0].Cells[0].Value + "";
                var getInforChange = db.FindTeacherByMa(keyStud.Trim()).Single();
                show = getInforChange;
            }
            else return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = dgvGiaoVien.SelectedRows.Count;
                if (selectedRow > 0)
                {
                    foreach (DataGridViewRow row in dgvGiaoVien.SelectedRows)
                    {
                        db.DeleteTeacher(row.Cells[0].Value.ToString());
                        db.SubmitChanges();
                    }
                    loadTeacher();
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng để xóa !!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
    }
}
