using Graphics.Contracts;
using System.Drawing;

namespace Graphics.Primitives
{
    public abstract class Primitive : IDrawable
    {
        public Transformation Transform { get; set; }

        public Primitive()
        {
            Transform = new Transformation();
        }

        public virtual void Draw(Graphics3D graphics)
        {
            graphics.Translate(Transform.Origin);
            graphics.Scale(Transform.Scaling);
            graphics.Rotation(Transform.Rotation);
            graphics.Translate(Transform.Position);
        }
    }
}
