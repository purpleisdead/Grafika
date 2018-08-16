using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomputarnaGrafika.Model
{
    class LineFigure : Figure
    {
        public PointF StartPoint { get; set; }
        public PointF EndPoint { get; set; }
        
        public LineFigure(PointF startPoint, PointF endPoint, Pen pen)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.Pen = pen;
        }
        
        public override void Draw(Graphics grfx)
        {
            grfx.DrawLine(this.Pen, StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y);
        }
    }
}
