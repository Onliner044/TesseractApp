using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesseractApp.Shapes {
    public class Quad : Primitive {
        public Line Line1 { get; set; }
        public Line Line2 { get; set; }
    }
}
