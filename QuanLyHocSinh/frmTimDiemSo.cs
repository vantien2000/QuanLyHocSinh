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
    public partial class frmTimDiemSo : Form
    {
        private dbDataContext db = new dbDataContext();
        public frmTimDiemSo()
        {
            InitializeComponent();
        }

        private void frmTimDiemSo_Load(object sender, EventArgs e)
        {
            loadComboboxTenLop();
            loadComboboxHocKy();
            loadComboboxMonHoc();
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
                         select new { subj.MaMon, subj.TenMon }).ToList();
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

        private void raMa_CheckedChanged(object sender, EventArgs e)
        {
            if (raMa.Checked)
            {
                txtMa.Enabled = true;
            }
            else txtMa.Enabled = false;
        }

        private void raHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (raHoTen.Checked)
            {
                txtHoTen.Enabled = true;
            }
            else txtHoTen.Enabled = false;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (raMa.Checked)
                {
                    if(txtMa.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã học sinh");
                        return;
                    }
                    else
                    {
                        var find = db.FindScoresByMaHS(txtMa.Text, cbbTenLop.SelectedValue.ToString(), cbbMonHoc.SelectedValue.ToString(), cbbHocKy.SelectedValue.ToString()).ToList();
                        if (find.Count > 0)
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Tìm kiếm thành công!!!");
                            frmDiemSo.dso.loadFindByMaHS(find);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy học sinh này");
                            return;
                        }
                    }
                }
                else
                {
                    if (txtHoTen.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập ho tên học sinh");
                        return;
                    }
                    else
                    {

                        var find = db.FindScoresByHoTen(txtHoTen.Text, cbbTenLop.SelectedValue.ToString(), cbbMonHoc.SelectedValue.ToString(), cbbHocKy.SelectedValue.ToString()).ToList();
                        if (find.Count > 0)
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Tìm kiếm thành công!!!");
                            frmDiemSo.dso.loadFindByHoTen(find);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy học sinh này");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
    }
}
