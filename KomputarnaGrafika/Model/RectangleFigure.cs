using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KomputarnaGrafika
{
    [Serializable]
    class RectangleFigure : Figure
    {   
        public RectangleFigure(RectangleF rectF, Pen pen)
        {
            this.RectF = rectF;
            this.Pen = pen;
            this.Matrix = new Matrix();
            this.Name = "Rectangle";
        }

        public RectangleFigure(RectangleF rectF, Pen pen, Matrix matrix)
        {
            this.RectF = rectF;
            this.Pen = pen;
            this.Matrix = matrix;
            this.Name = "Rectangle";
        }

        public override bool IsInside(PointF point)
        {
            Matrix matrixClone = this.Matrix.Clone();
            matrixClone.Invert();
            PointF[] points = new PointF[] { point };
            matrixClone.TransformPoints(points);

            GraphicsPath pathOfFigure = new GraphicsPath();
            pathOfFigure.AddRectangle(this.RectF);

            bool isInside = pathOfFigure.IsVisible(points[0]);

            return isInside;
        }

        public override void Draw(Graphics grfx)
        {
            Matrix firstMatrix = new Matrix();
            Matrix secondMatrix = new Matrix();
            firstMatrix.Multiply(this.Matrix, MatrixOrder.Prepend);
            grfx.Transform = firstMatrix;
            grfx.DrawRectangle(this.Pen, this.RectF.X, this.RectF.Y, this.RectF.Width + 1, this.RectF.Height + 1);
            grfx.Transform = secondMatrix;
        }
    }
}
