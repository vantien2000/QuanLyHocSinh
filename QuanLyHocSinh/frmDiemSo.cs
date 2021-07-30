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
        public static frmDiemSo dso = null;
        private string selectedLop, selectedMon, selectedHocKy;
        public frmDiemSo()
        {
            InitializeComponent();
            dso = this;
        }
        private void frmDiemSo_Load(object sender, EventArgs e)
        {
            loadComboboxTenLop();
            loadComboboxMonHoc();
            loadComboboxHocKy();
            loadTable();

            selectedLop = cbbTenLop.SelectedValue.ToString();
            selectedMon = cbbMonHoc.SelectedValue.ToString();
            selectedHocKy = cbbHocKy.SelectedValue.ToString();
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
        public void loadTable()
        {
            var ds = db.ShowScores(cbbTenLop.SelectedValue.ToString()
                , cbbMonHoc.SelectedValue.ToString(),
                cbbHocKy.SelectedValue.ToString()).ToList();
            dgvBangDiem.DataSource = ds;

        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            loadTable();
            btnLuu.Enabled = true;
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
            if(dgvBangDiem.RowCount>0)
                e.ContextMenuStrip = contextMenu;
        }
        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Hãy chọn đúng thông tin Lớp học, Môn học vào học kỳ trước khi lưu!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    string key = "";
                    for (int row = 0; row < dgvBangDiem.Rows.Count-1; row++)
                    {
                        int number = db.KetQuas.Select(x => x).Count();

                        if (number >= 0 && number < 9)
                        {
                            key = "KQ" + '0' + (number + 1);
                        }
                        else
                        {
                            key = "KQ" + (number + 1);
                        }
                        db.InsertScores(                     
                            key,
                            Convert.ToSingle(dgvBangDiem.Rows[row].Cells[7].Value.ToString().Replace(",", ".")),
                            cbbHocKy.SelectedValue.ToString(),
                            dgvBangDiem.Rows[row].Cells[0].Value.ToString(),
                            cbbMonHoc.SelectedValue.ToString(),
                            Convert.ToSingle(dgvBangDiem.Rows[row].Cells[2].Value.ToString().Replace(",", ".")),
                            Convert.ToSingle(dgvBangDiem.Rows[row].Cells[3].Value.ToString().Replace(",", ".")),
                            Convert.ToSingle(dgvBangDiem.Rows[row].Cells[4].Value.ToString().Replace(",", ".")),
                            Convert.ToSingle(dgvBangDiem.Rows[row].Cells[5].Value.ToString().Replace(",", ".")),
                            Convert.ToSingle(dgvBangDiem.Rows[row].Cells[6].Value.ToString().Replace(",", "."))
                            );
                        db.SubmitChanges();
                    }
                    MessageBox.Show("Thêm điểm thành công!!!");
                    loadTable();
                    btnLuu.Enabled = false;
                }
                else
                    return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi không đúng định dạng dữ liệu");
            }
            catch(Exception ex)
            {
                if(ex.Message.Contains("duplicate key"))
                {
                    MessageBox.Show("Mã đã tồn tại!! không thêm được dữ liệu. Vui lòng thực hiieenj thao tác khác!");
                }
                MessageBox.Show(ex.Message);
            }
                
        }

        private void insertTripMenu_Click(object sender, EventArgs e)
        {
            frmThemDiemSo themDS = new frmThemDiemSo();
            themDS.Show();
        }

        private void deleteTripMenu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa thông tin này không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                if (dgvBangDiem.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in dgvBangDiem.SelectedRows)
                    {
                        db.DeleteScores(item.Cells[0].Value.ToString(), cbbMonHoc.SelectedValue.ToString());
                        db.SubmitChanges();
                    }
                    loadTable();
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng để xóa", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void dgvBangDiem_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenu.Show(Cursor.Position);
            }
        }
        private void cbbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ds = db.ShowScores(cbbTenLop.SelectedValue.ToString()
                ,selectedMon,selectedHocKy).ToList();
            dgvBangDiem.DataSource = ds;
        }

        private void updateStrip_Click(object sender, EventArgs e)
        {
            int row = dgvBangDiem.CurrentRow.Index;
            string mahs = dgvBangDiem.Rows[row].Cells[0].Value.ToString();
            var getScoresByMaHS = db.FindScoresByMaHS(mahs, cbbTenLop.SelectedValue.ToString(),cbbMonHoc.SelectedValue.ToString(),cbbHocKy.SelectedValue.ToString()).FirstOrDefault();
            frmSuaDiemSo SuaDS = new frmSuaDiemSo(getScoresByMaHS,cbbTenLop.SelectedValue.ToString(),cbbMonHoc.SelectedValue.ToString(),cbbHocKy.SelectedValue.ToString());
            SuaDS.Show();
        }

        private void FindStrip_Click(object sender, EventArgs e)
        {
            frmTimDiemSo timDS = new frmTimDiemSo();
            timDS.Show();
        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ds = db.ShowScores(selectedLop,cbbMonHoc.SelectedValue.ToString()
                ,selectedHocKy).ToList();
            dgvBangDiem.DataSource = ds;
        }

        private void cbbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ds = db.ShowScores(selectedLop, selectedMon
               , cbbHocKy.SelectedValue.ToString()).ToList();
            dgvBangDiem.DataSource = ds;
        }

        public void loadFindByMaHS(List<FindScoresByMaHSResult> result)
        {
            dgvBangDiem.DataSource = result;
        }

        public void loadFindByHoTen(List<FindScoresByHoTenResult> result)
        {
            dgvBangDiem.DataSource = result;
        }
    }
}
