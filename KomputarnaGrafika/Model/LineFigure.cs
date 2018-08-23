using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomputarnaGrafika.Model
{
    [Serializable]
    class LineFigure : Figure
    {
        //public PointF StartPoint { get; set; }
        //public PointF EndPoint { get; set; }

        public float StartPointX { get; set; }
        public float StartPointY { get; set; }
        public float EndPointX { get; set; }
        public float EndPointY { get; set; }
        public object PenColor { get; set; }
        public float PenWidth { get; set; }
        public float[] MatrixElements { get; set; }

        [NonSerialized]
        public PointF _startPoint;
        public PointF StartPoint
        {
            get
            {
                return this._startPoint;
            }
            set
            {
                this._startPoint = value;
            }
        }

        [NonSerialized]
        public PointF _endPoint;
        public PointF EndPoint
        {
            get
            {
                return this._endPoint;
            }
            set
            {
                this._endPoint = value;
            }
        }

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
