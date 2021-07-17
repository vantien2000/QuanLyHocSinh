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
            var subjCount = (from subj in db.MonHocs select subj).Count();

            return subjCount;
        }
    }
}
