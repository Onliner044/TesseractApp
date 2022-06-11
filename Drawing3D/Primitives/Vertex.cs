using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;

namespace Drawing3D.Primitives
{
    public class Vertex : Primitive
    {
        public float Size { get; protected set; }

        public Vertex(Vector3 position, float size = 1.0f)
            : base(position)
        {
            Size = size;
        }

        public Vertex(float x, float y, float z, float size = 1.0f)
            : this(new Vector3(x, y, z), size)
        {
        }

        public override void Draw(Graphics3D graphics)
        {
            //PointF point1 = Transformation.Position.ToPointF();
            //RectangleF rect = new RectangleF(point1, new SizeF(Size, Size));
            
            //graphics.FillRectangle(Pen.Brush, rect);
        }
    }
}
