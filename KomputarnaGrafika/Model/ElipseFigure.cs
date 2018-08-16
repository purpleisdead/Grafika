using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomputarnaGrafika.Model
{
    class ElipseFigure : Figure
    {
        public ElipseFigure(RectangleF rectF, Pen pen)
        {
            this.RectF = rectF;
            this.Pen = pen;
            this.Matrix = new Matrix();
            this.Name = "Elipse";
        }

        public override bool IsInside(PointF point)
        {
            Matrix cloneMatrix = this.Matrix.Clone();
            cloneMatrix.Invert();
            PointF[] points = new PointF[] { point };
            cloneMatrix.TransformPoints(points);
            
            GraphicsPath pathOfFigure = new GraphicsPath();
            pathOfFigure.AddEllipse(this.RectF);
            bool isInside = pathOfFigure.IsVisible(points[0]);

            return isInside;
        }

        public override void Draw(Graphics grfx)
        {
            Matrix firstMatrix = new Matrix();
            //Matrix secondMatrix = new Matrix();
            firstMatrix.Multiply(this.Matrix, MatrixOrder.Prepend);
            grfx.Transform = firstMatrix;
            grfx.DrawEllipse(this.Pen, this.RectF.X, this.RectF.Y, this.RectF.Width, this.RectF.Height);
           // grfx.Transform = secondMatrix;
        }
    }
}
