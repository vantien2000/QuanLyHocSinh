﻿
namespace QuanLyHocSinh
{
    partial class frmResetPass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXacThuc = new System.Windows.Forms.TextBox();
            this.btnXacThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(195)))));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt Lại Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMK.Location = new System.Drawing.Point(22, 119);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(306, 35);
            this.txtMK.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xác Thực Mật Khẩu";
            // 
            // txtXacThuc
            // 
            this.txtXacThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtXacThuc.Location = new System.Drawing.Point(22, 216);
            this.txtXacThuc.Name = "txtXacThuc";
            this.txtXacThuc.PasswordChar = '*';
            this.txtXacThuc.Size = new System.Drawing.Size(306, 35);
            this.txtXacThuc.TabIndex = 3;
            // 
            // btnXacThuc
            // 
            this.btnXacThuc.BackColor = System.Drawing.Color.LimeGreen;
            this.btnXacThuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacThuc.ForeColor = System.Drawing.Color.White;
            this.btnXacThuc.Location = new System.Drawing.Point(22, 272);
            this.btnXacThuc.Name = "btnXacThuc";
            this.btnXacThuc.Size = new System.Drawing.Size(125, 42);
            this.btnXacThuc.TabIndex = 4;
            this.btnXacThuc.Text = "Xác Thực";
            this.btnXacThuc.UseVisualStyleBackColor = false;
            this.btnXacThuc.Click += new System.EventHandler(this.btnXacThuc_Click);
            // 
            // frmResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 363);
            this.Controls.Add(this.btnXacThuc);
            this.Controls.Add(this.txtXacThuc);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXacThuc;
        private System.Windows.Forms.Button btnXacThuc;
    }
}