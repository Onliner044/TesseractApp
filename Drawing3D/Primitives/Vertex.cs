using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;

namespace Graphics.Primitives
{
    public class Vertex : Primitive
    {
        public float Size { get; protected set; }

        public Vertex(Vector3 position, float size = 1.0f)
        {
            Size = size;
        }

        public override void Draw(Graphics3D graphics)
        {
            /*PointF point1 = Transformation.Position.ToPointF();
            RectangleF rect = new RectangleF(point1, new SizeF(Size, Size));
            
            graphics.FillRectangle(Pen.Brush, rect);*/
        }
    }
}
