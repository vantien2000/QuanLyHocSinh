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
    public partial class frmThemDiemSo : Form
    {
        private dbDataContext db = new dbDataContext();
        public frmThemDiemSo()
        {
            InitializeComponent();
        }

        private void frmThemDiemSo_Load(object sender, EventArgs e)
        {
            loadComboboxTenLop();
            loadComboboxHocKy();
            loadComboboxMonHoc();
            loadComboboxMaHS();
        }

        private void loadComboboxTenLop()
        {
            var names = (from _class in db.LopHocs
                         select new { _class.MaLop, _class.TenLop }).ToList();
            cbbLop.DataSource = names;
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "MaLop";
        }
        private void loadComboboxMonHoc()
        {
            var names = (from subj in db.MonHocs
                         select new { subj.MaMon, subj.TenMon }).ToList();
            cbbMon.DataSource = names;
            cbbMon.DisplayMember = "TenMon";
            cbbMon.ValueMember = "MaMon";
        }
        private void loadComboboxHocKy()
        {
            var names = (from lession in db.HocKies
                         select new { lession.MaHK, lession.TenHocKy }).ToList();
            cbbHocKy.DataSource = names;
            cbbHocKy.DisplayMember = "TenHocKy";
            cbbHocKy.ValueMember = "MaHK";
        }
        private void loadComboboxMaHS()
        {
            var names = (from hs in db.HocSinhs
                         join lop in db.LopHocs
                         on hs.MaLop equals lop.MaLop
                         where hs.MaLop == cbbLop.SelectedValue.ToString()
                         select hs);
            cbbMa.Items.Clear();
            foreach (var item in names)
            {
                cbbMa.Text = item.MaHS;
                cbbMa.Items.Add(item.MaHS);
            }
        }
        private string pathImage()
        {
            string pathProject = Application.StartupPath;
            string newPath = pathProject.Substring(0, pathProject.Length - 23) + "Image" + '\\';
            return newPath;
        }
        private string autoKeyKetQua()
        {
            string key = "";
            try
            {

                var resultKey = (from result in db.KetQuas select result.MaKQ).ToList().Last().Trim();

                int number = int.Parse(resultKey.Substring(2));

                if (number >= 0 && number < 9)
                {
                    key = "KQ" + "0" + (number + 1);
                }
                else
                {
                    key = "KQ" + (number + 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            return key;

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
        private double DiemTB()
        {
            double tong = 0;
            var loaiDiem = db.LoaiDiems.Select(x => new { x.HeSo }).ToList();
            if (txtDiemM.Text == "" || txtDiem15.Text == "" || txtDiem1Tiet.Text == "" || txtDiemGK.Text == ""
                || txtDiemCK.Text == "")
            {
                tong = 0;
            }
            else
            {
                tong = Convert.ToDouble(txtDiemM.Text) * loaiDiem[0].HeSo.Value
                + Convert.ToDouble(txtDiem15.Text) * loaiDiem[1].HeSo.Value
                + Convert.ToDouble(txtDiem1Tiet.Text) * loaiDiem[2].HeSo.Value
                + Convert.ToDouble(txtDiemGK.Text) * loaiDiem[3].HeSo.Value
                + Convert.ToDouble(txtDiemCK.Text) * loaiDiem[4].HeSo.Value;
            }
            return Math.Round(tong / HSDiem(), 1);
        }
        private void cbbMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var names = db.ShowStudentByMa(cbbMa.Text);
            foreach(var item in names)
            {
                txtHoTen.Text = item.HoTen.ToString();
                pictrueAvatar.Image = Image.FromFile(pathImage() + item.Anh.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiemM.Text == "" || txtDiem15.Text == "" || txtDiem1Tiet.Text == "" || txtDiemGK.Text == ""
                    || txtDiemCK.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    return;
                }
                if(Convert.ToSingle(txtDiemM.Text) <0 || Convert.ToSingle(txtDiem15.Text) < 0 || Convert.ToSingle(txtDiem1Tiet.Text) < 0 || Convert.ToSingle(txtDiemGK.Text) < 0
                    || Convert.ToSingle(txtDiemCK.Text) < 0)
                {
                    MessageBox.Show("Điểm nhập vào không nhỏ hơn 0", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    return;
                }
                db.InsertScores(
                    autoKeyKetQua(),
                    DiemTB(),
                    cbbHocKy.SelectedValue.ToString(),
                    cbbMa.SelectedItem.ToString().Trim(),
                    cbbMon.SelectedValue.ToString(),
                    Convert.ToSingle(txtDiemM.Text),
                    Convert.ToSingle(txtDiem15.Text),
                    Convert.ToSingle(txtDiem1Tiet.Text),
                    Convert.ToSingle(txtDiemGK.Text),
                    Convert.ToSingle(txtDiemCK.Text)
                );
                db.SubmitChanges();
                MessageBox.Show("Thêm điểm thành công!!!");
                frmDiemSo.dso.loadTable();
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Lỗi dữ liệu nhập vào ko đúng dạng "+fe.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("duplicate key"))
                {
                    MessageBox.Show("Học sinh này đã có điểm!!");
                }
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            
        }

        private void txtDiemCK_TextChanged(object sender, EventArgs e)
        {

            if (txtDiemM.Text != "" || txtDiem15.Text != "" || txtDiem1Tiet.Text != "" || txtDiemGK.Text != ""
                || txtDiemCK.Text != "")
            {
                txtDiemTB.Text = Math.Round(DiemTB(),1) + "";
            }
        }

        

        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            var names = (from hs in db.HocSinhs
                         join lop in db.LopHocs
                         on hs.MaLop equals lop.MaLop
                         where hs.MaLop == cbbLop.SelectedValue.ToString()
                         select hs);
            cbbMa.Items.Clear();
            cbbMa.Text = "";
            foreach (var item in names)
            {
                cbbMa.Text = item.MaHS;
                cbbMa.Items.Add(item.MaHS);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
