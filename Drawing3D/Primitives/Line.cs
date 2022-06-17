using System.Drawing;
using System.Numerics;

namespace Graphics.Primitives
{
    public class Line : Primitive
    {
        public float VertexSize { get; set; }
        public Vector3 Point1 { get; set; }
        public Vector3 Point2 { get; set; }

        public Line(Vector3 point1, Vector3 point2)
        {
            Point1 = point1;
            Point2 = point2;
            VertexSize = 5.0f;
        }

        public Line(Vector3 point1, Vector3 point2, Pen pen)
            : this(point1, point2)
        {
            Pen = pen;
        }

        public override void Draw(Graphics3D graphics)
        {
            base.Draw(graphics);

            graphics.DrawLine(Point1, Point2);
            graphics.DrawCircle(Point1, VertexSize);
            graphics.DrawCircle(Point2, VertexSize);
        }
    }
}
