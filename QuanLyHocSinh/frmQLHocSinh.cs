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
            loadStudent();
        }

        private string pathImage()
        {
            string pathProject = Application.StartupPath;
            string newPath = pathProject.Substring(0, pathProject.Length - 23) + "Image" + '\\';
            return newPath;
        }

        private void loadStudent()
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
    }
}
