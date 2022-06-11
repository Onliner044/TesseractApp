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

        public List<IDrawable> Children{ get; private set; }
        public Primitive(Vector3 position) 
            : this()
        {
            Transform.Translate(position, Mode.Local);
        }

        public Primitive()
        {
            Children = new List<IDrawable>();
            Transform = new Transformation();
            Pen = new Pen(Color.Black);
        }
        
        public void SetColor(Color color)
        {
            Pen.Color = color;
        }

        public virtual void Draw(Graphics3D graphics)
        {
            foreach (var child in Children)
            {
                graphics.PushLocal();
                graphics.ApplyLocal(child);

                child.Draw(graphics);

                graphics.PopLocal();
            }
        }
    }
}
