using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{

    public class GradientPanel:Panel
    {
        //Màu bên trên
        public Color TopColor { get; set; }
        //Màu bên dưới
        public Color BottomColor { get; set; }
        //Góc độ
        public float Angle { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            //gọi đối tượng LinearGradient
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle);
            //vẽ giao diện
            Graphics g = e.Graphics;
            g.FillRectangle(brush,this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
