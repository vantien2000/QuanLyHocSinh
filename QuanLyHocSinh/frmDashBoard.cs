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
    public partial class frmDashBoard : Form
    {
        private dbDataContext db = new dbDataContext();
        public frmDashBoard()
        {
            InitializeComponent();
            lblEmp.Text = getCountEmp()+"";
            lblStudent.Text = getCountStudent() + "";
            lblTeacher.Text = getCountTeacher() + "";
            lblSubject.Text = getCountSubject() + "";
            loadChartStudent();
            loadChartSie();
        }
        private int getCountEmp()
        {
            var empCount = (from emp in db.NhanViens select emp).Count();

            return empCount;
        }
        private int getCountStudent()
        {
            var studCount = (from stud in db.HocSinhs select stud).Count();

            return studCount;
        }
        private int getCountTeacher()
        {
            var teachCount = (from teach in db.GVCNs select teach).Count();

            return teachCount;
        }
        private int getCountSubject()
        {
            var subjCount = (from subj in db.MonHocs 
                            group subj by subj.TenMon).Count();
            return subjCount;
        }

        private void loadChartStudent()
        {
            var chartStud = from _class in db.LopHocs
                            join stud in db.HocSinhs
                            on _class.MaLop equals stud.MaLop
                            group stud by _class.TenLop into result
                            select new { TenLop = result.Key, 
                                SoHocSinh = result.Select(x => x.MaHS).Count(),
                                SoGVCN = 1};
            foreach(var result in chartStud)
            {
                chartStudent.Series["Học sinh"].Points.AddXY(result.TenLop, result.SoHocSinh);
                chartStudent.Series["GVCN"].Points.AddXY(result.TenLop, result.SoGVCN);
            }
        }

        private void loadChartSie()
        {
            var chartStud = from _class in db.LopHocs
                            join stud in db.HocSinhs
                            on _class.MaLop equals stud.MaLop
                            group stud by _class.NamHoc into result
                            select new { NamHoc = result.Key, SoHocSinh = result.Select(x => x.MaHS).Count() };
            foreach (var result in chartStud)
            {
                chartSieStudent.Series["Học sinh"].Points.AddXY(result.NamHoc, result.SoHocSinh);
            }
        }
    }
}
