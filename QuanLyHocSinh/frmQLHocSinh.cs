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
    public partial class frmQLHocSinh : Form
    {
        private dbDataContext db = new dbDataContext();
        private FindStudentByMaResult show = null;
        public static frmQLHocSinh getLoad;
        public frmQLHocSinh()
        {
            InitializeComponent();
            getLoad = this;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemHS themHS = new frmThemHS();
            themHS.Show();
        }

        private void frmQLHocSinh_Load(object sender, EventArgs e)
        {
            loadStudent();
            //đóng mặc định chọn cell
            dgvHocSinh.CurrentCell.Selected = false;
        }

        private string pathImage()
        {
            string pathProject = Application.StartupPath;
            string newPath = pathProject.Substring(0, pathProject.Length - 23) + "Image" + '\\';
            return newPath;
        }

        public void loadStudent()
        {
            try
            {
                int index = 0;
                dgvHocSinh.Rows.Clear();
                dgvHocSinh.RowTemplate.Height = 80;
                foreach(var stud in db.ShowStudent())
                {
                    dgvHocSinh.Rows.Add();
                    dgvHocSinh.Rows[index].Cells[0].Value = stud.MaHS.ToString();
                    dgvHocSinh.Rows[index].Cells[1].Value = new Bitmap(pathImage()+stud.Anh);
                    dgvHocSinh.Rows[index].Cells[2].Value = stud.HoTen;
                    dgvHocSinh.Rows[index].Cells[3].Value = stud.NgaySinh.Value.ToString("dd/MM/yyyy");
                    dgvHocSinh.Rows[index].Cells[4].Value = stud.GioiTinh;
                    dgvHocSinh.Rows[index].Cells[5].Value = stud.DiaChi;
                    dgvHocSinh.Rows[index].Cells[6].Value = stud.SDT;
                    dgvHocSinh.Rows[index].Cells[7].Value = stud.DiemDauVao;
                    dgvHocSinh.Rows[index].Cells[8].Value = stud.TenLop;
                    index++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            loadStudent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSearch.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã để tìm kiếm!!!", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    return;
                }
                dgvHocSinh.Rows.Clear();
                dgvHocSinh.RowTemplate.Height = 80;
                var stud = db.FindStudentByMa(txtSearch.Text.Trim()).Single();
                dgvHocSinh.Rows.Add();
                dgvHocSinh.Rows[0].Cells[0].Value = stud.MaHS.ToString();
                dgvHocSinh.Rows[0].Cells[1].Value = new Bitmap(pathImage() + stud.Anh);
                dgvHocSinh.Rows[0].Cells[2].Value = stud.HoTen;
                dgvHocSinh.Rows[0].Cells[3].Value = stud.NgaySinh.Value.ToString("dd/MM/yyyy");
                dgvHocSinh.Rows[0].Cells[4].Value = stud.GioiTinh;
                dgvHocSinh.Rows[0].Cells[5].Value = stud.DiaChi;
                dgvHocSinh.Rows[0].Cells[6].Value = stud.SDT;
                dgvHocSinh.Rows[0].Cells[7].Value = stud.DiemDauVao;
                dgvHocSinh.Rows[0].Cells[8].Value = stud.TenLop;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvHocSinh.SelectedRows.Count > 0 && dgvHocSinh.SelectedRows.Count <=1)
            {
                frmSuaHS suaHS = new frmSuaHS(show);
                suaHS.Show();
            }
            else if(dgvHocSinh.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ chọn một học sinh để sửa!!!", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn học sinh!!!", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            } 
        }

        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRow = dgvHocSinh.SelectedRows.Count;
            if (selectedRow > 0 && selectedRow <= 1)
            {
                string keyStud = dgvHocSinh.SelectedRows[0].Cells[0].Value+"";
                var getInforChange = db.FindStudentByMa(keyStud.Trim()).Single();
                show = getInforChange;
            }
            else return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = dgvHocSinh.SelectedRows.Count;
                if (selectedRow > 0)
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa học sinh này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if(dr == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvHocSinh.SelectedRows)
                        {
                            db.DeleteStudent(row.Cells[0].Value.ToString());
                            db.SubmitChanges();
                        }
                        loadStudent();
                    }
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
