
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
            this.btnBrower = new FontAwesome.Sharp.IconButton();
            this.txtUpload = new System.Windows.Forms.TextBox();
            this.cbbTenLop = new System.Windows.Forms.ComboBox();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbbHocKy = new System.Windows.Forms.ComboBox();
            this.btnRefesh = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dgvBangDiem.Location = new System.Drawing.Point(0, 83);
            this.dgvBangDiem.Name = "dgvBangDiem";
            this.dgvBangDiem.Size = new System.Drawing.Size(1370, 667);
            this.dgvBangDiem.TabIndex = 0;
            this.dgvBangDiem.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvBangDiem_CellContextMenuStripNeeded);
            this.dgvBangDiem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangDiem_CellValueChanged);
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
            // txtUpload
            // 
            this.txtUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpload.Location = new System.Drawing.Point(469, 28);
            this.txtUpload.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpload.Name = "txtUpload";
            this.txtUpload.Size = new System.Drawing.Size(373, 32);
            this.txtUpload.TabIndex = 8;
            // 
            // cbbTenLop
            // 
            this.cbbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTenLop.FormattingEnabled = true;
            this.cbbTenLop.Location = new System.Drawing.Point(12, 26);
            this.cbbTenLop.Name = "cbbTenLop";
            this.cbbTenLop.Size = new System.Drawing.Size(121, 33);
            this.cbbTenLop.TabIndex = 10;
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(148, 26);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(121, 33);
            this.cbbMonHoc.TabIndex = 10;
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbHocKy.FormattingEnabled = true;
            this.cbbHocKy.Location = new System.Drawing.Point(284, 27);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(121, 33);
            this.cbbHocKy.TabIndex = 10;
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
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.findToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(159, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // frmDiemSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
    }
}