using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace KomputarnaGrafika.Model
{
    class Group : Figure
    {
        public List<Figure> GroupedFigures { get; set; }

        public Group(List<Figure> figures)
        {
            this.GroupedFigures = new List<Figure>();
            foreach (var figure in figures)
            {
                this.GroupedFigures.Add(figure);
            }

            this.Pen = new Pen(Color.Black, 1f);
            this.Matrix = new Matrix();
            this.Name = "Group";
            CreateGroupRect();
        }

        public override bool IsInside(PointF point)
        {
            foreach (var figure in this.GroupedFigures)
            {
                if (figure.IsInside(point))
                {
                    return true;
                }
            }

            return false;
        }
        
        public override void Translate(float x, float y)
        {
            base.Translate(x, y);

            foreach (var figure in this.GroupedFigures)
            {
                figure.Translate(x, y);
            }
        }

        public override void Rotate(float degrees, PointF point)
        {
            foreach (var figure in this.GroupedFigures)
            {
                figure.Rotate(degrees, point);
            }
        }

        public override void RotateAt(float degrees)
        {
            PointF rotationPoint = this.GetMiddlePoint();

            base.Rotate(degrees, rotationPoint);

            foreach (var figure in this.GroupedFigures)
            {
                figure.Rotate(degrees, rotationPoint);
            }
        }

        public override void Draw(Graphics grfx)
        {
            foreach (var figure in this.GroupedFigures)
            {
                figure.Draw(grfx);
            }
        }

        public override void ChangePenColor(Color color)
        {
            this.Pen.Color = color;

            foreach (var figure in this.GroupedFigures)
            {
                figure.ChangePenColor(color);
            }
        }

        public override void ChangePenWidth(float width)
        {
            this.Pen.Width = width;

            foreach (var figure in this.GroupedFigures)
            {
                figure.ChangePenWidth(width);
            }
        }

        private void CreateGroupRect()
        {
            float minX = this.GroupedFigures[0].RectF.X;
            float minY = this.GroupedFigures[0].RectF.Y;
            float maxX = this.GroupedFigures[0].RectF.X + this.GroupedFigures[0].RectF.Width;
            float maxY = this.GroupedFigures[0].RectF.Y + this.GroupedFigures[0].RectF.Height;

            foreach (var figure in this.GroupedFigures)
            {
                if (minX > figure.RectF.X)
                {
                    minX = figure.RectF.X;
                }

                if (minY > figure.RectF.Y)
                {
                    minY = figure.RectF.Y;
                }

                if (maxX < (figure.RectF.X + figure.RectF.Width))
                {
                    maxX = figure.RectF.X + figure.RectF.Width;
                }

                if (maxY < (figure.RectF.Y + figure.RectF.Height))
                {
                    maxY = figure.RectF.Y + figure.RectF.Height;
                }
            }

            this.RectF = new RectangleF(minX, minY, Math.Abs(maxX - minX), Math.Abs(maxY - minY));
        }
    }
}
