
namespace QuanLyHocSinh
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelIconDownUp = new System.Windows.Forms.Panel();
            this.iconCaretDown = new FontAwesome.Sharp.IconButton();
            this.panelHocPhi = new System.Windows.Forms.Panel();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.btnCongNo = new FontAwesome.Sharp.IconButton();
            this.btnLichSu = new FontAwesome.Sharp.IconButton();
            this.btnHocPhi = new FontAwesome.Sharp.IconButton();
            this.btnThonTin = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnDiemSo = new FontAwesome.Sharp.IconButton();
            this.btnGVCN = new FontAwesome.Sharp.IconButton();
            this.btnQLLopHoc = new FontAwesome.Sharp.IconButton();
            this.btnQLHocSinh = new FontAwesome.Sharp.IconButton();
            this.btnDashBoard = new FontAwesome.Sharp.IconButton();
            this.iconChange = new FontAwesome.Sharp.IconPictureBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.gradientPanel1 = new QuanLyHocSinh.GradientPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureAvatar = new QuanLyHocSinh.CircularPictureBox();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelIconDownUp.SuspendLayout();
            this.panelHocPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChange)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 69);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(195)))));
            this.label2.Location = new System.Drawing.Point(77, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trường THPT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(83)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(77, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chuyên Lam Sơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogo.Image = global::QuanLyHocSinh.Properties.Resources.logo;
            this.btnLogo.Location = new System.Drawing.Point(21, 12);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(50, 44);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 0;
            this.btnLogo.TabStop = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogo.Controls.Add(this.panelMenu);
            this.panelLogo.Controls.Add(this.panel2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(251, 617);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelIconDownUp);
            this.panelMenu.Controls.Add(this.panelHocPhi);
            this.panelMenu.Controls.Add(this.btnHocPhi);
            this.panelMenu.Controls.Add(this.btnThonTin);
            this.panelMenu.Controls.Add(this.btnThongKe);
            this.panelMenu.Controls.Add(this.btnDiemSo);
            this.panelMenu.Controls.Add(this.btnGVCN);
            this.panelMenu.Controls.Add(this.btnQLLopHoc);
            this.panelMenu.Controls.Add(this.btnQLHocSinh);
            this.panelMenu.Controls.Add(this.btnDashBoard);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 69);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(247, 544);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelIconDownUp
            // 
            this.panelIconDownUp.BackColor = System.Drawing.Color.Transparent;
            this.panelIconDownUp.Controls.Add(this.iconCaretDown);
            this.panelIconDownUp.Location = new System.Drawing.Point(167, 330);
            this.panelIconDownUp.Name = "panelIconDownUp";
            this.panelIconDownUp.Size = new System.Drawing.Size(75, 13);
            this.panelIconDownUp.TabIndex = 19;
            this.panelIconDownUp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIconDownUp_Paint);
            // 
            // iconCaretDown
            // 
            this.iconCaretDown.BackColor = System.Drawing.Color.Transparent;
            this.iconCaretDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconCaretDown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconCaretDown.FlatAppearance.BorderSize = 0;
            this.iconCaretDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconCaretDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconCaretDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCaretDown.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.iconCaretDown.IconColor = System.Drawing.Color.DimGray;
            this.iconCaretDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCaretDown.IconSize = 25;
            this.iconCaretDown.Location = new System.Drawing.Point(0, 0);
            this.iconCaretDown.Name = "iconCaretDown";
            this.iconCaretDown.Size = new System.Drawing.Size(75, 13);
            this.iconCaretDown.TabIndex = 18;
            this.iconCaretDown.UseVisualStyleBackColor = false;
            this.iconCaretDown.Click += new System.EventHandler(this.iconCaretDown_Click);
            // 
            // panelHocPhi
            // 
            this.panelHocPhi.Controls.Add(this.btnThanhToan);
            this.panelHocPhi.Controls.Add(this.btnCongNo);
            this.panelHocPhi.Controls.Add(this.btnLichSu);
            this.panelHocPhi.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHocPhi.Location = new System.Drawing.Point(0, 360);
            this.panelHocPhi.Name = "panelHocPhi";
            this.panelHocPhi.Size = new System.Drawing.Size(255, 184);
            this.panelHocPhi.TabIndex = 17;
            this.panelHocPhi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHocPhi_Paint);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.DimGray;
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.btnThanhToan.IconColor = System.Drawing.Color.DimGray;
            this.btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhToan.IconSize = 25;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 90);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnThanhToan.Size = new System.Drawing.Size(255, 45);
            this.btnThanhToan.TabIndex = 19;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            this.btnThanhToan.MouseHover += new System.EventHandler(this.btnThanhToan_MouseHover);
            // 
            // btnCongNo
            // 
            this.btnCongNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCongNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCongNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCongNo.FlatAppearance.BorderSize = 0;
            this.btnCongNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCongNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCongNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCongNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCongNo.ForeColor = System.Drawing.Color.DimGray;
            this.btnCongNo.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnCongNo.IconColor = System.Drawing.Color.DimGray;
            this.btnCongNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCongNo.IconSize = 25;
            this.btnCongNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCongNo.Location = new System.Drawing.Point(0, 45);
            this.btnCongNo.Name = "btnCongNo";
            this.btnCongNo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCongNo.Size = new System.Drawing.Size(255, 45);
            this.btnCongNo.TabIndex = 18;
            this.btnCongNo.Text = "Công Nợ";
            this.btnCongNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCongNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCongNo.UseVisualStyleBackColor = true;
            this.btnCongNo.Click += new System.EventHandler(this.btnCongNo_Click);
            this.btnCongNo.MouseHover += new System.EventHandler(this.btnCongNo_MouseHover);
            // 
            // btnLichSu
            // 
            this.btnLichSu.BackColor = System.Drawing.Color.Transparent;
            this.btnLichSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichSu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLichSu.FlatAppearance.BorderSize = 0;
            this.btnLichSu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLichSu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLichSu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLichSu.ForeColor = System.Drawing.Color.DimGray;
            this.btnLichSu.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnLichSu.IconColor = System.Drawing.Color.DimGray;
            this.btnLichSu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLichSu.IconSize = 25;
            this.btnLichSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSu.Location = new System.Drawing.Point(0, 0);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLichSu.Size = new System.Drawing.Size(255, 45);
            this.btnLichSu.TabIndex = 17;
            this.btnLichSu.Text = "Lịch Sử Giao Dịch";
            this.btnLichSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichSu.UseVisualStyleBackColor = false;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            this.btnLichSu.MouseHover += new System.EventHandler(this.btnLichSu_MouseHover);
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHocPhi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHocPhi.FlatAppearance.BorderSize = 0;
            this.btnHocPhi.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnHocPhi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHocPhi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHocPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHocPhi.ForeColor = System.Drawing.Color.DimGray;
            this.btnHocPhi.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btnHocPhi.IconColor = System.Drawing.Color.DimGray;
            this.btnHocPhi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHocPhi.IconSize = 25;
            this.btnHocPhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocPhi.Location = new System.Drawing.Point(0, 315);
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnHocPhi.Size = new System.Drawing.Size(247, 45);
            this.btnHocPhi.TabIndex = 16;
            this.btnHocPhi.Text = "Học Phí";
            this.btnHocPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocPhi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHocPhi.UseVisualStyleBackColor = true;
            this.btnHocPhi.Click += new System.EventHandler(this.btnHocPhi_Click);
            this.btnHocPhi.MouseHover += new System.EventHandler(this.btnHocPhi_MouseHover);
            // 
            // btnThonTin
            // 
            this.btnThonTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThonTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThonTin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThonTin.FlatAppearance.BorderSize = 0;
            this.btnThonTin.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnThonTin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThonTin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThonTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThonTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThonTin.ForeColor = System.Drawing.Color.DimGray;
            this.btnThonTin.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnThonTin.IconColor = System.Drawing.Color.DimGray;
            this.btnThonTin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThonTin.IconSize = 25;
            this.btnThonTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThonTin.Location = new System.Drawing.Point(0, 270);
            this.btnThonTin.Name = "btnThonTin";
            this.btnThonTin.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnThonTin.Size = new System.Drawing.Size(247, 45);
            this.btnThonTin.TabIndex = 15;
            this.btnThonTin.Text = "Thông Tin";
            this.btnThonTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThonTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThonTin.UseVisualStyleBackColor = true;
            this.btnThonTin.Click += new System.EventHandler(this.btnThonTin_Click);
            this.btnThonTin.MouseHover += new System.EventHandler(this.btnThonTin_MouseHover);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.ForeColor = System.Drawing.Color.DimGray;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnThongKe.IconColor = System.Drawing.Color.DimGray;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.IconSize = 25;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 225);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnThongKe.Size = new System.Drawing.Size(247, 45);
            this.btnThongKe.TabIndex = 14;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            this.btnThongKe.MouseHover += new System.EventHandler(this.btnThongKe_MouseHover);
            // 
            // btnDiemSo
            // 
            this.btnDiemSo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiemSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemSo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDiemSo.FlatAppearance.BorderSize = 0;
            this.btnDiemSo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDiemSo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDiemSo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDiemSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiemSo.ForeColor = System.Drawing.Color.DimGray;
            this.btnDiemSo.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnDiemSo.IconColor = System.Drawing.Color.DimGray;
            this.btnDiemSo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiemSo.IconSize = 25;
            this.btnDiemSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemSo.Location = new System.Drawing.Point(0, 180);
            this.btnDiemSo.Name = "btnDiemSo";
            this.btnDiemSo.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnDiemSo.Size = new System.Drawing.Size(247, 45);
            this.btnDiemSo.TabIndex = 13;
            this.btnDiemSo.Text = "Điểm Số";
            this.btnDiemSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiemSo.UseVisualStyleBackColor = true;
            this.btnDiemSo.Click += new System.EventHandler(this.btnDiemSo_Click);
            this.btnDiemSo.MouseHover += new System.EventHandler(this.btnDiemSo_MouseHover);
            // 
            // btnGVCN
            // 
            this.btnGVCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGVCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGVCN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGVCN.FlatAppearance.BorderSize = 0;
            this.btnGVCN.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnGVCN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGVCN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGVCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGVCN.ForeColor = System.Drawing.Color.DimGray;
            this.btnGVCN.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnGVCN.IconColor = System.Drawing.Color.DimGray;
            this.btnGVCN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGVCN.IconSize = 25;
            this.btnGVCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGVCN.Location = new System.Drawing.Point(0, 135);
            this.btnGVCN.Name = "btnGVCN";
            this.btnGVCN.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnGVCN.Size = new System.Drawing.Size(247, 45);
            this.btnGVCN.TabIndex = 12;
            this.btnGVCN.Text = "Giáo Viên Chủ Nhiệm";
            this.btnGVCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGVCN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGVCN.UseVisualStyleBackColor = true;
            this.btnGVCN.Click += new System.EventHandler(this.btnGVCN_Click);
            this.btnGVCN.MouseHover += new System.EventHandler(this.btnGVCN_MouseHover);
            // 
            // btnQLLopHoc
            // 
            this.btnQLLopHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLLopHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLLopHoc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLLopHoc.FlatAppearance.BorderSize = 0;
            this.btnQLLopHoc.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnQLLopHoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnQLLopHoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnQLLopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLLopHoc.ForeColor = System.Drawing.Color.DimGray;
            this.btnQLLopHoc.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.btnQLLopHoc.IconColor = System.Drawing.Color.DimGray;
            this.btnQLLopHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLLopHoc.IconSize = 25;
            this.btnQLLopHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLLopHoc.Location = new System.Drawing.Point(0, 90);
            this.btnQLLopHoc.Name = "btnQLLopHoc";
            this.btnQLLopHoc.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnQLLopHoc.Size = new System.Drawing.Size(247, 45);
            this.btnQLLopHoc.TabIndex = 11;
            this.btnQLLopHoc.Text = "Quản Lý Lớp Học";
            this.btnQLLopHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLLopHoc.UseVisualStyleBackColor = true;
            this.btnQLLopHoc.Click += new System.EventHandler(this.btnQLLopHoc_Click);
            this.btnQLLopHoc.MouseHover += new System.EventHandler(this.btnQLLopHoc_MouseHover);
            // 
            // btnQLHocSinh
            // 
            this.btnQLHocSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLHocSinh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLHocSinh.FlatAppearance.BorderSize = 0;
            this.btnQLHocSinh.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnQLHocSinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnQLHocSinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnQLHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLHocSinh.ForeColor = System.Drawing.Color.DimGray;
            this.btnQLHocSinh.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btnQLHocSinh.IconColor = System.Drawing.Color.DimGray;
            this.btnQLHocSinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLHocSinh.IconSize = 25;
            this.btnQLHocSinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHocSinh.Location = new System.Drawing.Point(0, 45);
            this.btnQLHocSinh.Name = "btnQLHocSinh";
            this.btnQLHocSinh.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnQLHocSinh.Size = new System.Drawing.Size(247, 45);
            this.btnQLHocSinh.TabIndex = 10;
            this.btnQLHocSinh.Text = "Quản Lý Học Sinh";
            this.btnQLHocSinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLHocSinh.UseVisualStyleBackColor = true;
            this.btnQLHocSinh.Click += new System.EventHandler(this.btnQLHocSinh_Click);
            this.btnQLHocSinh.MouseHover += new System.EventHandler(this.btnQLHocSinh_MouseHover);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashBoard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDashBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.DimGray;
            this.btnDashBoard.IconChar = FontAwesome.Sharp.IconChar.Compass;
            this.btnDashBoard.IconColor = System.Drawing.Color.DimGray;
            this.btnDashBoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashBoard.IconSize = 25;
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 0);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnDashBoard.Size = new System.Drawing.Size(247, 45);
            this.btnDashBoard.TabIndex = 9;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            this.btnDashBoard.MouseHover += new System.EventHandler(this.btnDashBoard_MouseHover);
            // 
            // iconChange
            // 
            this.iconChange.BackColor = System.Drawing.Color.Transparent;
            this.iconChange.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconChange.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconChange.IconColor = System.Drawing.Color.Gainsboro;
            this.iconChange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChange.Location = new System.Drawing.Point(30, 12);
            this.iconChange.Name = "iconChange";
            this.iconChange.Size = new System.Drawing.Size(43, 32);
            this.iconChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconChange.TabIndex = 0;
            this.iconChange.TabStop = false;
            this.iconChange.Click += new System.EventHandler(this.iconChange_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChange.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChange.Location = new System.Drawing.Point(79, 19);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(52, 20);
            this.lblChange.TabIndex = 1;
            this.lblChange.Text = "Home";
            this.lblChange.Click += new System.EventHandler(this.lblChange_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 180F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(199)))));
            this.gradientPanel1.Controls.Add(this.lblLogin);
            this.gradientPanel1.Controls.Add(this.iconButton2);
            this.gradientPanel1.Controls.Add(this.iconButton1);
            this.gradientPanel1.Controls.Add(this.pictureAvatar);
            this.gradientPanel1.Controls.Add(this.lblChange);
            this.gradientPanel1.Controls.Add(this.iconChange);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(251, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(870, 58);
            this.gradientPanel1.TabIndex = 1;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(210)))));
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("VNI-Ariston", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogin.Location = new System.Drawing.Point(811, 15);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(53, 22);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "label3";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(684, 11);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(40, 32);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(719, 11);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(40, 32);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureAvatar.Location = new System.Drawing.Point(765, 7);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(40, 40);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAvatar.TabIndex = 2;
            this.pictureAvatar.TabStop = false;
            this.pictureAvatar.Click += new System.EventHandler(this.pictureAvatar_Click);
            // 
            // pictureHome
            // 
            this.pictureHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureHome.Image = global::QuanLyHocSinh.Properties.Resources.dashboard;
            this.pictureHome.Location = new System.Drawing.Point(0, 0);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(870, 559);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHome.TabIndex = 1;
            this.pictureHome.TabStop = false;
            this.pictureHome.Click += new System.EventHandler(this.pictureHome_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.pictureHome);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(251, 58);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(870, 559);
            this.panelContent.TabIndex = 2;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1121, 617);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panelLogo);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelIconDownUp.ResumeLayout(false);
            this.panelHocPhi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconChange)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnLogo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelIconDownUp;
        private FontAwesome.Sharp.IconButton iconCaretDown;
        private System.Windows.Forms.Panel panelHocPhi;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private FontAwesome.Sharp.IconButton btnCongNo;
        private FontAwesome.Sharp.IconButton btnLichSu;
        private FontAwesome.Sharp.IconButton btnHocPhi;
        private FontAwesome.Sharp.IconButton btnThonTin;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnDiemSo;
        private FontAwesome.Sharp.IconButton btnGVCN;
        private FontAwesome.Sharp.IconButton btnQLLopHoc;
        private FontAwesome.Sharp.IconButton btnQLHocSinh;
        private FontAwesome.Sharp.IconButton btnDashBoard;
        private FontAwesome.Sharp.IconPictureBox iconChange;
        private System.Windows.Forms.Label lblChange;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lblLogin;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private CircularPictureBox pictureAvatar;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Panel panelContent;
    }
}