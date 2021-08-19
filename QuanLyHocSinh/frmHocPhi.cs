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
    public partial class frmHocPhi : Form
    {
        private dbDataContext db = new dbDataContext();
        public static frmHocPhi getLoad;
        public frmHocPhi()
        {
            InitializeComponent();
            getLoad = this;
        }
        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            loadHPhi();
            //đóng mặc định chọn cell
            dgvHocPhi.CurrentCell.Selected = false;
        }
        private string pathImage()
        {
            string pathProject = Application.StartupPath;
            string newPath = pathProject.Substring(0, pathProject.Length - 23) + "Image" + '\\';
            return newPath;
        }

        public void loadHPhi()
        {
            try
            {
                int index = 0;
                dgvHocPhi.Rows.Clear();
                dgvHocPhi.RowTemplate.Height = 80;
                foreach (var hphi in db.ShowHPhi())
                {
                    dgvHocPhi.Rows.Add();
                    dgvHocPhi.Rows[index].Cells[0].Value = hphi.MaHS.ToString();
                    dgvHocPhi.Rows[index].Cells[1].Value = new Bitmap(pathImage() + hphi.Anh);
                    dgvHocPhi.Rows[index].Cells[2].Value = hphi.HoTen;
                    dgvHocPhi.Rows[index].Cells[3].Value = hphi.HocPhi;
                    dgvHocPhi.Rows[index].Cells[4].Value = hphi.PhiPhatSinh;
                    dgvHocPhi.Rows[index].Cells[5].Value = hphi.ThanhTien;
                    dgvHocPhi.Rows[index].Cells[6].Value = hphi.TinhTrang;
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

    }
}
