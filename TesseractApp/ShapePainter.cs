using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesseractApp {
    public class ShapePainter {
        public ShapePainter() {
            PictureBox a = null;
            var b = a.CreateGraphics();
            System.Windows.Controls.Canvas canvas = null;
            canvas.ClipToBounds = true;
        }
    }
}
