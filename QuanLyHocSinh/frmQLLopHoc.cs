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
    public partial class frmQLLopHoc : Form
    {
        private dbDataContext db = new dbDataContext();
        private FindStudentByMaResult show = null;
        public static frmQLLopHoc getLoad;
        public frmQLLopHoc()
        {
            InitializeComponent();
            getLoad = this;
        }
        public void loadClass()
        {
            try
            {
                int index = 0;
                dgvLopHoc.Rows.Clear();
                dgvLopHoc.RowTemplate.Height = 80;
                foreach (var lop in db.ShowClass())
                {
                    dgvLopHoc.Rows.Add();
                    dgvLopHoc.Rows[index].Cells[0].Value = lop.MaLop.ToString();
                    dgvLopHoc.Rows[index].Cells[1].Value = lop.TenLop;
                    dgvLopHoc.Rows[index].Cells[2].Value = lop.LoaiLop;
                    dgvLopHoc.Rows[index].Cells[3].Value = lop.NamHoc;
                    dgvLopHoc.Rows[index].Cells[4].Value = lop.MaKhoiLop;
                    dgvLopHoc.Rows[index].Cells[5].Value = lop.TenKhoi;
                    dgvLopHoc.Rows[index].Cells[6].Value = lop.HoTen;
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void frmQLLopHoc_Load(object sender, EventArgs e)
        {
            loadClass();
            dgvLopHoc.CurrentCell.Selected = false;
        }
    }
}
