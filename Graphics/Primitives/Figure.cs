using System.Drawing;

namespace Graphics.Primitives
{
    public abstract class Figure : Primitive
    {
        public virtual Color VerticesColor { get; set; } = Color.Black;
        public virtual Color OutlineColor { get; set; } = Color.Black;
        public virtual Color FillColor { get; set; } = Color.Black;
        public virtual bool HasVertices { get; set; } = true;
        public virtual bool HasOutline { get; set; } = true;
        public virtual bool HasFill { get; set; } = true;
    }
}
