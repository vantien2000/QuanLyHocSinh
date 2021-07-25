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
using System.Data.OleDb;

namespace QuanLyHocSinh
{
    public partial class frmDiemSo : Form
    {
        private dbDataContext db = new dbDataContext();
        public frmDiemSo()
        {
            InitializeComponent();
        }
        private void frmDiemSo_Load(object sender, EventArgs e)
        {
            loadComboboxTenLop();
            loadComboboxMonHoc();
            loadComboboxHocKy();
        }
        private void loadComboboxTenLop()
        {
            var names = (from _class in db.LopHocs
                         select new { _class.MaLop, _class.TenLop }).ToList();
            cbbTenLop.DataSource = names;
            cbbTenLop.DisplayMember = "TenLop";
            cbbTenLop.ValueMember = "MaLop";
        }
        private void loadComboboxMonHoc()
        {
            var names = (from subj in db.MonHocs
                         select new { subj.MaMon,subj.TenMon }).ToList();
            cbbMonHoc.DataSource = names;
            cbbMonHoc.DisplayMember = "TenMon";
            cbbMonHoc.ValueMember = "MaMon";
        }
        private void loadComboboxHocKy()
        {
            var names = (from lession in db.HocKies
                         select new { lession.MaHK, lession.TenHocKy }).ToList();
            cbbHocKy.DataSource = names;
            cbbHocKy.DisplayMember = "TenHocKy";
            cbbHocKy.ValueMember = "MaHK";
        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {

        }
        private void loadExcel()
        {
            string conectStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + txtUpload.Text + "'; Extended Properties=\"Excel 12.0 Xml; HDR = Yes; IMEX = 1;\"";
            using (OleDbConnection connOle = new OleDbConnection(conectStr))
            {
                connOle.Open();
                DataTable data = connOle.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (data == null)
                {
                    MessageBox.Show("Không tìm thấy sheet!!!");
                    return;
                }
                else
                {
                    string sheetName = "";
                    foreach (DataRow dr in data.Rows)
                    {
                        sheetName = dr[2].ToString().Replace("'", "");
                    }
                    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [" + sheetName + "]", connOle);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBangDiem.DataSource = dt;
                }
            }
        }
        private void btnBrower_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.Title = "Select Files";
                openDlg.Filter = "Excel Files(*.xlsx; *.xls)|*.xlsx; *.xls";
                openDlg.FilterIndex = 1;
                openDlg.InitialDirectory = @"C:\";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    txtUpload.Text = openDlg.FileName;
                    if (!File.Exists(txtUpload.Text))
                    {
                        MessageBox.Show("Không thể mở file");
                        return;
                    }
                    loadExcel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private void dgvBangDiem_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.ContextMenuStrip = contextMenu;
            }
        }
        private double HSDiem()
        {
            double hsDiem = 0;
            var loaiDiem = db.LoaiDiems.Select(x => new { x.HeSo });
            foreach (var d in loaiDiem)
            {
                hsDiem += d.HeSo.Value;
            }
            return hsDiem;
        }
        double diem = 0;
        private void dgvBangDiem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int currentRow = e.RowIndex;
                int currentCell = e.ColumnIndex;
                if(currentCell >1 && currentCell < 7)
                {
                    var loaiDiem = db.LoaiDiems.Select(x => new { x.HeSo }).ToArray();
                    diem += double.Parse(dgvBangDiem.Rows[currentRow].Cells[currentCell].Value.ToString()) * loaiDiem[currentCell - 2].HeSo.Value;
                    dgvBangDiem.Rows[currentRow].Cells[7].Value = Math.Round((diem / HSDiem()),1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //if (dgvBangDiem.Rows.Count > 0)
                //{
                //    var maMons = db.MonHocs.Where(p => p.TenMon == cbbMonHoc.SelectedText).Select(x => new { x.MaMon }).ToList();
                //    int count = (maMons.Count() / 5);
                //    foreach (DataGridViewRow row in dgvBangDiem.Rows)
                //    {
                //        for (int index = 0; index < maMons.Count(); index++)
                //        {
                //            Diem diem = new Diem();
                //            diem.MaHS = row.Cells[0].ToString();
                //            diem.MaMon = maMons[index].MaMon;
                //            diem.HanhKiem = ;
                //            diem.DiemTB = decimal.Parse(row.Cells[index+2].ToString());
                //            if (count > 0 && count <= 9)
                //                diem.MaKQ = "KQ0" + count;
                //            else
                //                diem.MaKQ = "KQ" + count;

                //            db.Diems.InsertOnSubmit(diem);
                //            MessageBox.Show("Thêm thành công!!");
                //            db.SubmitChanges();
                //        }
                //        count++;
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
    }
}
