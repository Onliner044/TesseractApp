using Drawing3D;
using Drawing3D.Contracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesseractApp.Contracts;

namespace TesseractApp
{
    public class Tesseract : Decorator
    {
        public Tesseract(IComponent component) 
            : base(component)
        {
            
        }

        public void Draw(Graphics3D graphics)
        {
        }
    }
}
