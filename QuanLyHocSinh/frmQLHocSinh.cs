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
        public frmQLHocSinh()
        {
            InitializeComponent();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemHS themHS = new frmThemHS();
            themHS.Show();
        }

        private void frmQLHocSinh_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private string pathImage()
        {
            string pathProject = Application.StartupPath;
            string newPath = pathProject.Substring(0, pathProject.Length - 23) + "Image" + '\\';
            return newPath;
        }

        private void LoadStudent()
        {
            try
            {
                int index = 0;
                dgvHocSinh.Rows.Clear();
                dgvHocSinh.RowTemplate.Height = 80;
                foreach (var stud in db.ShowStudent())
                {
                    dgvHocSinh.Rows.Add();
                    dgvHocSinh.Rows[index].Cells[0].Value = stud.MaHS;
                    dgvHocSinh.Rows[index].Cells[1].Value = Image.FromFile(pathImage() + stud.Anh);
                    dgvHocSinh.Rows[index].Cells[2].Value = stud.HoTen;
                    dgvHocSinh.Rows[index].Cells[3].Value = stud.Tuoi;
                    dgvHocSinh.Rows[index].Cells[4].Value = stud.NgaySinh.Value.ToString("dd/MM/yyyy");
                    dgvHocSinh.Rows[index].Cells[5].Value = stud.GioiTinh;
                    dgvHocSinh.Rows[index].Cells[6].Value = stud.DiaChi;
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
            LoadStudent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHocSinh.Rows.Clear();
                dgvHocSinh.RowTemplate.Height = 80;
                if(txtSearch.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã để tìm kiếm!!!", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    return;
                }

                var stud = db.ShowStudentByMa(txtSearch.Text.Trim()).ToList();
                //foreach(var stud in db.ShowStudentByMa(txtSearch.Text.Trim()))
                //{
                    dgvHocSinh.Rows.Add();
                    dgvHocSinh.Rows[0].Cells[0].Value = stud[0].MaHS;
                    dgvHocSinh.Rows[0].Cells[1].Value = Image.FromFile(pathImage() + stud[0].Anh);
                    dgvHocSinh.Rows[0].Cells[2].Value = stud[0].HoTen;
                    dgvHocSinh.Rows[0].Cells[3].Value = stud[0].Tuoi;
                    dgvHocSinh.Rows[0].Cells[4].Value = stud[0].NgaySinh.Value.ToString("dd/MM/yyyy");
                    dgvHocSinh.Rows[0].Cells[5].Value = stud[0].GioiTinh;
                    dgvHocSinh.Rows[0].Cells[6].Value = stud[0].DiaChi;
                    dgvHocSinh.Rows[0].Cells[7].Value = stud[0].DiemDauVao;
                    dgvHocSinh.Rows[0].Cells[8].Value = stud[0].TenLop;
                //}
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
    }
}
