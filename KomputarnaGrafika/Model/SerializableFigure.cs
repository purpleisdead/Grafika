using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomputarnaGrafika.Model
{
    [Serializable]
    public class SerializableFigure
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public object PenColor { get; set; }
        public float PenWidth { get; set; }
        public object FillColor { get; set; }
        public float[] MatrixElements { get; set; }
    }
}
