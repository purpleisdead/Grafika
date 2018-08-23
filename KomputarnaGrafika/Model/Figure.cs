using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using KomputarnaGrafika.Model;

namespace KomputarnaGrafika
{
    [Serializable]
    public class Figure
    {
        public SerializableFigure SerializedFigure { get; set; }

        public bool IsSelected { get; set; }

        [NonSerialized]
        public RectangleF rectF;
        public RectangleF RectF { get { return this.rectF; } set { this.rectF = value; } }

        [NonSerialized]
        public Color color;
        public Color Color { get { return this.color; } set { this.color = value; } }

        [NonSerialized]
        public Pen pen = null;
        public Pen Pen { get { return this.pen; } set { this.pen = value; } }

        [NonSerialized]
        public Matrix matrix = null;
        public Matrix Matrix { get { return this.matrix; } set { this.matrix = value; } }

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

        public virtual void Serialize()
        {
            this.SerializedFigure = new SerializableFigure();
            this.SerializedFigure.X = this.RectF.X;
            this.SerializedFigure.Y = this.RectF.Y;
            this.SerializedFigure.Width = this.RectF.Width;
            this.SerializedFigure.Height = this.RectF.Height;
            this.SerializedFigure.PenColor = this.Pen.Color;
            this.SerializedFigure.PenWidth = this.Pen.Width;
            this.SerializedFigure.MatrixElements = this.Matrix.Elements;
        }

        public virtual void Deserialize()
        {
            this.Color = (Color)this.SerializedFigure.PenColor;
            this.Matrix = new Matrix(this.SerializedFigure.MatrixElements[0], this.SerializedFigure.MatrixElements[1], this.SerializedFigure.MatrixElements[2], this.SerializedFigure.MatrixElements[3], this.SerializedFigure.MatrixElements[4], this.SerializedFigure.MatrixElements[5]);
            this.RectF = new RectangleF(this.SerializedFigure.X, this.SerializedFigure.Y, this.SerializedFigure.Width, this.SerializedFigure.Height);
            this.Pen = new Pen((Color)this.SerializedFigure.PenColor, this.SerializedFigure.PenWidth);
        }
    }
}
