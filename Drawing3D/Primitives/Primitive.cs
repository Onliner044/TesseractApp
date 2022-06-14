using Drawing3D.Contracts;
using Drawing3D.Utils;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Text;

namespace Drawing3D.Primitives
{
    public abstract class Primitive : IDrawable
    {
        public Transformation Transform { get; protected set; }
        public Pen Pen { get; protected set; }

        public Primitive()
        {
            Transform = new Transformation();
            Pen = new Pen(Color.Black);
        }
        
        public virtual void SetColor(Color color)
        {
            Pen.Color = color;
        }

        public abstract void Draw(Graphics3D graphics);
    }
}
