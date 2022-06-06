using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesseractApp.Shapes {
    public class Vertex : Primitive {
        public Vertex(PointF position) {
            Position = position;
        }
    }
}
