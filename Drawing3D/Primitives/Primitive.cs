using Graphics.Contracts;
using System.Drawing;

namespace Graphics.Primitives
{
    public abstract class Primitive : IDrawable
    {
        public Transformation Transform { get; set; }
        public Pen Pen { get; protected set; }

        public Primitive()
        {
            Pen = new Pen(Color.Black);
            Transform = new Transformation();
        }

        public virtual void Draw(Graphics3D graphics)
        {
            graphics.ApplyTransform(this);
            graphics.SetColor(Pen.Color);
        }
    }
}
