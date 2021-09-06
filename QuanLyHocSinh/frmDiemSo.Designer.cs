
namespace QuanLyHocSinh
{
    partial class frmDiemSo
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
            this.components = new System.ComponentModel.Container();
            this.dgvBangDiem = new System.Windows.Forms.DataGridView();
            this.txtUpload = new System.Windows.Forms.TextBox();
            this.cbbTenLop = new System.Windows.Forms.ComboBox();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbbHocKy = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertTripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FindStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefesh = new FontAwesome.Sharp.IconButton();
            this.btnBrower = new FontAwesome.Sharp.IconButton();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemMieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15Phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem1Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemGiuaKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCuoiKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBangDiem
            // 
            this.dgvBangDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.HoTen,
            this.DiemMieng,
            this.Diem15Phut,
            this.Diem1Tiet,
            this.DiemGiuaKy,
            this.DiemCuoiKy,
            this.DiemTB,
            this.TenHocKy,
            this.TenMon});
            this.dgvBangDiem.Location = new System.Drawing.Point(0, 83);
            this.dgvBangDiem.Name = "dgvBangDiem";
            this.dgvBangDiem.RowHeadersWidth = 62;
            this.dgvBangDiem.Size = new System.Drawing.Size(1370, 667);
            this.dgvBangDiem.TabIndex = 0;
            this.dgvBangDiem.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvBangDiem_CellContextMenuStripNeeded);
            this.dgvBangDiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBangDiem_MouseClick);
            // 
            // txtUpload
            // 
            this.txtUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpload.Location = new System.Drawing.Point(469, 28);
            this.txtUpload.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpload.Name = "txtUpload";
            this.txtUpload.Size = new System.Drawing.Size(373, 44);
            this.txtUpload.TabIndex = 8;
            // 
            // cbbTenLop
            // 
            this.cbbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTenLop.FormattingEnabled = true;
            this.cbbTenLop.Location = new System.Drawing.Point(12, 26);
            this.cbbTenLop.Name = "cbbTenLop";
            this.cbbTenLop.Size = new System.Drawing.Size(121, 45);
            this.cbbTenLop.TabIndex = 10;
            this.cbbTenLop.SelectedIndexChanged += new System.EventHandler(this.cbbTenLop_SelectedIndexChanged);
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(148, 26);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(121, 45);
            this.cbbMonHoc.TabIndex = 10;
            this.cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonHoc_SelectedIndexChanged);
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbHocKy.FormattingEnabled = true;
            this.cbbHocKy.Location = new System.Drawing.Point(284, 27);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(121, 45);
            this.cbbHocKy.TabIndex = 10;
            this.cbbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbbHocKy_SelectedIndexChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(916, 23);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 44);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertTripMenu,
            this.updateStrip,
            this.deleteTripMenu,
            this.FindStrip});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(212, 132);
            // 
            // insertTripMenu
            // 
            this.insertTripMenu.Name = "insertTripMenu";
            this.insertTripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.insertTripMenu.Size = new System.Drawing.Size(211, 32);
            this.insertTripMenu.Text = "Insert ";
            this.insertTripMenu.Click += new System.EventHandler(this.insertTripMenu_Click);
            // 
            // updateStrip
            // 
            this.updateStrip.Name = "updateStrip";
            this.updateStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateStrip.Size = new System.Drawing.Size(211, 32);
            this.updateStrip.Text = "Update";
            this.updateStrip.Click += new System.EventHandler(this.updateStrip_Click);
            // 
            // deleteTripMenu
            // 
            this.deleteTripMenu.Name = "deleteTripMenu";
            this.deleteTripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteTripMenu.Size = new System.Drawing.Size(211, 32);
            this.deleteTripMenu.Text = "Delete";
            this.deleteTripMenu.Click += new System.EventHandler(this.deleteTripMenu_Click);
            // 
            // FindStrip
            // 
            this.FindStrip.Name = "FindStrip";
            this.FindStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FindStrip.Size = new System.Drawing.Size(211, 32);
            this.FindStrip.Text = "Find";
            this.FindStrip.Click += new System.EventHandler(this.FindStrip_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnRefesh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnRefesh.IconColor = System.Drawing.Color.White;
            this.btnRefesh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefesh.IconSize = 25;
            this.btnRefesh.Location = new System.Drawing.Point(1033, 25);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(48, 42);
            this.btnRefesh.TabIndex = 13;
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnBrower
            // 
            this.btnBrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(83)))), ((int)(((byte)(33)))));
            this.btnBrower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBrower.ForeColor = System.Drawing.Color.White;
            this.btnBrower.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBrower.IconColor = System.Drawing.Color.White;
            this.btnBrower.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrower.IconSize = 25;
            this.btnBrower.Location = new System.Drawing.Point(858, 29);
            this.btnBrower.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(40, 32);
            this.btnBrower.TabIndex = 9;
            this.btnBrower.Text = "...";
            this.btnBrower.UseVisualStyleBackColor = false;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.MinimumWidth = 8;
            this.MaHS.Name = "MaHS";
            this.MaHS.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 170;
            // 
            // DiemMieng
            // 
            this.DiemMieng.DataPropertyName = "DiemMieng";
            this.DiemMieng.HeaderText = "Điểm miệng";
            this.DiemMieng.MinimumWidth = 8;
            this.DiemMieng.Name = "DiemMieng";
            this.DiemMieng.Width = 150;
            // 
            // Diem15Phut
            // 
            this.Diem15Phut.DataPropertyName = "Diem15Phut";
            this.Diem15Phut.HeaderText = "Điểm 15 phút";
            this.Diem15Phut.MinimumWidth = 8;
            this.Diem15Phut.Name = "Diem15Phut";
            this.Diem15Phut.Width = 170;
            // 
            // Diem1Tiet
            // 
            this.Diem1Tiet.DataPropertyName = "Diem1Tiet";
            this.Diem1Tiet.HeaderText = "Điểm 1 tiết";
            this.Diem1Tiet.MinimumWidth = 8;
            this.Diem1Tiet.Name = "Diem1Tiet";
            this.Diem1Tiet.Width = 160;
            // 
            // DiemGiuaKy
            // 
            this.DiemGiuaKy.DataPropertyName = "DiemGiuaKy";
            this.DiemGiuaKy.HeaderText = "Điểm giữa kỳ";
            this.DiemGiuaKy.MinimumWidth = 8;
            this.DiemGiuaKy.Name = "DiemGiuaKy";
            this.DiemGiuaKy.Width = 160;
            // 
            // DiemCuoiKy
            // 
            this.DiemCuoiKy.DataPropertyName = "DiemCuoiKy";
            this.DiemCuoiKy.HeaderText = "Điểm cuối kỳ";
            this.DiemCuoiKy.MinimumWidth = 8;
            this.DiemCuoiKy.Name = "DiemCuoiKy";
            this.DiemCuoiKy.Width = 160;
            // 
            // DiemTB
            // 
            this.DiemTB.DataPropertyName = "DiemTB";
            this.DiemTB.HeaderText = "Điếm trung bình";
            this.DiemTB.MinimumWidth = 8;
            this.DiemTB.Name = "DiemTB";
            this.DiemTB.Width = 180;
            // 
            // TenHocKy
            // 
            this.TenHocKy.DataPropertyName = "TenHocKy";
            this.TenHocKy.HeaderText = "Tên học kỳ";
            this.TenHocKy.MinimumWidth = 8;
            this.TenHocKy.Name = "TenHocKy";
            this.TenHocKy.Width = 140;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên môn";
            this.TenMon.MinimumWidth = 8;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 140;
            // 
            // frmDiemSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbbHocKy);
            this.Controls.Add(this.cbbMonHoc);
            this.Controls.Add(this.cbbTenLop);
            this.Controls.Add(this.btnBrower);
            this.Controls.Add(this.txtUpload);
            this.Controls.Add(this.dgvBangDiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiemSo";
            this.Text = "Bảng điểm";
            this.Load += new System.EventHandler(this.frmDiemSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBangDiem;
        private FontAwesome.Sharp.IconButton btnBrower;
        private System.Windows.Forms.TextBox txtUpload;
        private System.Windows.Forms.ComboBox cbbTenLop;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.ComboBox cbbHocKy;
        private FontAwesome.Sharp.IconButton btnRefesh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteTripMenu;
        private System.Windows.Forms.ToolStripMenuItem FindStrip;
        private System.Windows.Forms.ToolStripMenuItem insertTripMenu;
        private System.Windows.Forms.ToolStripMenuItem updateStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemMieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15Phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem1Tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemGiuaKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCuoiKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
    }
}