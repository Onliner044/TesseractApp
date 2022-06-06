using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesseractApp.Shapes {
    public class Line : Primitive {
        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }
        public float Length { get; set; }


        public Line(PointF point1, PointF point2) {
            Vertex1 = new Vertex(point1);
            Vertex2 = new Vertex(point2);
        }

        public Line(Vertex vertex1, Vertex vertex2) {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
        }
    }
}
