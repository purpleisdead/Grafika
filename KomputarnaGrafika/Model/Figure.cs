using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KomputarnaGrafika
{
    class Figure
    {
        public bool IsSelected { get; set; }
        public RectangleF RectF { get; set; }
        public Color Color { get; set; }
        public Pen Pen { get; set; }
        public Matrix Matrix { get; set; }
        public string Name { get; set; }


        public virtual bool IsInside(PointF point)
        {
            return true;
        }

        public virtual void Draw(Graphics grfx)
        {

        }

        public virtual void ChangePenColor(Color color)
        {
            this.Pen.Color = color;
        }

        public virtual void ChangePenWidth(float width)
        {
            this.Pen.Width = width;
        }

        public virtual void Translate(float x, float y)
        {
            Matrix translationMatrix = new Matrix();
            translationMatrix.Translate(x, y);
            this.Matrix.Multiply(translationMatrix, MatrixOrder.Append);
        }

        public virtual void Rotate(float degrees, PointF point)
        {
            Matrix rotationMatrix = new Matrix();
            rotationMatrix.RotateAt(degrees, point);
            this.Matrix.Multiply(rotationMatrix, MatrixOrder.Append);
        }

        public virtual void RotateAt(float degrees)
        {
            PointF rotationPoint = this.GetMiddlePoint();

            this.Rotate(degrees, rotationPoint);
        }

        protected PointF GetMiddlePoint()
        {
            RectangleF bounds = GetBounds();

            PointF mid = new PointF(bounds.Width / 2 + bounds.X, bounds.Height / 2 + bounds.Y);

            return mid;
        }

        protected RectangleF GetBounds()
        {
            PointF p1, p2, p3, p4;
            p1 = new PointF(this.RectF.X, this.RectF.Y);
            p2 = new PointF(this.RectF.X, this.RectF.Y + this.RectF.Height);
            p3 = new PointF(this.RectF.X + this.RectF.Width, this.RectF.Y);
            p4 = new PointF(this.RectF.X + this.RectF.Width, this.RectF.Y + this.RectF.Height);
            PointF[] points = new PointF[4] { p1, p2, p3, p4 };
            this.Matrix.TransformPoints(points);

            float minx, maxx, miny, maxy;
            minx = points[0].X;
            maxx = points[0].X;
            miny = points[0].Y;
            maxy = points[0].Y;
            for (int i = 0; i <= 3; i++)
            {
                minx = Math.Min(minx, points[i].X);
                miny = Math.Min(miny, points[i].Y);
                maxx = Math.Max(maxx, points[i].X);
                maxy = Math.Max(maxy, points[i].Y);
            }

            RectangleF bounds = new RectangleF(minx, miny, (maxx - minx), (maxy - miny));

            return bounds;
        }
    }
}
