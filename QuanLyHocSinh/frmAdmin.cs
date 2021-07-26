using FontAwesome.Sharp;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmAdmin : Form
    {
        private IconButton currentBtn; //nut ien tai
        private Panel leftBorderBtn; //panel thanh chay
        private Form currentChildForm; //form con hien tai
        private IconPictureBox iconHide = new IconPictureBox();
        //Nut sổ lên
        private IconButton caretUpBtn = new IconButton();
        public frmAdmin(NhanVien nv)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 40);
            //form
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //open form
            //login
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Text = nv.TaiKhoan;
            lblLogin.ForeColor = Color.White;
            //panel Hoc Phi
            panelHocPhi.Hide();
            //xử lý event
            caretUpBtn.Click += caretUpBtn_Click;

            //scroll menu
            panelMenu.AutoScroll = true;
            panelHocPhi.AutoScroll = true;
            //load Avatar
            
            string filename = pathImage() + nv.ThongTinCaNhan.Anh;
            pictureAvatar.Image = Image.FromFile(filename);
        }

        private string pathImage()
        {
            string pathProject = Application.StartupPath;
            string newPath = pathProject.Substring(0, pathProject.Length - 23)+"Image"+'\\';
            return newPath;
        }

        private void ActivateButton(object senderBtn,Color color,Panel inputPanel)
        {
            inputPanel.Controls.Add(leftBorderBtn);
            //neu nut duoc chon
            if (senderBtn != null)
            {
                DisableButon();
                //ep kieu cho senderBtn
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                //leftborderbtn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.BringToFront();
                leftBorderBtn.Show();
                //dat icon va label change
                iconChange.IconChar = currentBtn.IconChar;
                lblChange.Text = currentBtn.Text;
            }

            
        }
        private void DisableButon()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.DimGray;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.DimGray;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnDashBoard_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195),panelMenu);
            //set lai mau nut sổ xuống
            caretUpBtn.IconColor = Color.DimGray;
            iconCaretDown.IconColor = Color.DimGray;
        }

        private void btnQLHocSinh_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195),panelMenu);
            //set lai mau nut sổ xuống
            caretUpBtn.IconColor = Color.DimGray;
        }

        private void btnQLLopHoc_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195), panelMenu);
            //set lai mau nut sổ xuống
            caretUpBtn.IconColor = Color.DimGray;
            iconCaretDown.IconColor = Color.DimGray;
        }

        private void btnGVCN_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frmQLGiaoVien());
        }

        private void btnGVCN_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195), panelMenu);
            //set lai mau nut sổ xuống
            caretUpBtn.IconColor = Color.DimGray;
            iconCaretDown.IconColor = Color.DimGray;
        }

        private void btnDiemSo_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195), panelMenu);
            //set lai mau nut sổ xuống
            caretUpBtn.IconColor = Color.DimGray;
            iconCaretDown.IconColor = Color.DimGray;
        }

        private void btnThongKe_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195), panelMenu);
            //set lai mau nut sổ xuống
            caretUpBtn.IconColor = Color.DimGray;
            iconCaretDown.IconColor = Color.DimGray;
        }

        private void btnThonTin_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195), panelMenu);
            //set lai mau nut sổ xuống
            caretUpBtn.IconColor = Color.DimGray;
            iconCaretDown.IconColor = Color.DimGray;
        }

        private void btnHocPhi_Click(object sender, System.EventArgs e)
        {

        }

        private void btnHocPhi_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 124, 195), panelMenu);
            panelIconDownUp.BackColor = Color.White;
            iconCaretDown.IconColor = Color.FromArgb(0, 124, 195);
            caretUpBtn.IconColor = Color.FromArgb(0, 124, 195);

        }

        private void btnLogo_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frmHome());
            DisableButon();
            leftBorderBtn.Hide();
            iconChange.IconChar = IconChar.Home;
            lblChange.Text = "Home";
        }
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //label change
            lblChange.Text = childForm.Text;
        }

        private void btnQLHocSinh_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frmQLHocSinh());
        }

        private void btnDashBoard_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frmDashBoard());
        }
        private void iconCaretDown_Click(object sender, System.EventArgs e)
        {
            panelHocPhi.Show();
            
            caretUpBtn.BackColor = Color.Transparent;
            caretUpBtn.FlatStyle = FlatStyle.Flat;
            caretUpBtn.FlatAppearance.BorderSize = 0;
            caretUpBtn.FlatAppearance.BorderColor = Color.White;
            caretUpBtn.FlatAppearance.MouseDownBackColor = Color.White;
            caretUpBtn.FlatAppearance.MouseOverBackColor = Color.White;
            caretUpBtn.Text = string.Empty;
            caretUpBtn.IconChar = IconChar.CaretUp;
            caretUpBtn.IconColor = Color.FromArgb(0, 124, 195);
            caretUpBtn.IconSize = 25;
            caretUpBtn.Dock = DockStyle.Fill;
            caretUpBtn.Size = new Size(16, 16);
            panelIconDownUp.Controls.Add(caretUpBtn);
            caretUpBtn.Show();
            iconCaretDown.Hide();
        }

        private void caretUpBtn_Click(object sender, System.EventArgs e)
        {
            panelHocPhi.Hide();
            caretUpBtn.Hide();
            iconCaretDown.Show();
            panelIconDownUp.Controls.Add(iconCaretDown);
        }
        private void btnLichSu_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(225, 83, 33), panelHocPhi);
            //set lai mau nut sổ xuống
            caretUpBtn.IconColor = Color.DimGray;
            iconCaretDown.IconColor = Color.DimGray;
        }

        private void btnCongNo_MouseHover(object sender, System.EventArgs e)
        {
            
            ActivateButton(sender, Color.FromArgb(225, 83, 33), panelHocPhi);
            //set lai mau nut sổ xuống
            caretUpBtn.IconColor = Color.DimGray;
            iconCaretDown.IconColor = Color.DimGray;
        }

        private void btnThanhToan_MouseHover(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(225, 83, 33), panelHocPhi);
            //set lai mau nut sổ xuống
            caretUpBtn.IconColor = Color.DimGray;
            iconCaretDown.IconColor = Color.DimGray;
        }

        private void inconLogout_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            frmLogin frmout = new frmLogin();
            frmout.Show();
        }

        private void btnDiemSo_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frmDiemSo());
        }

        private void btnQLLopHoc_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new frmQLLopHoc());
        }
    }
}
