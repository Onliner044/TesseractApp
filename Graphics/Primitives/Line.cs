using System.Drawing;
using System.Numerics;

namespace Graphics.Primitives
{
    public class Line : Primitive
    {
        public Vector3 Point1 { get; set; }
        public Vector3 Point2 { get; set; }
        public Color Color { get; set; }

        public Line(Vector3 point1, Vector3 point2)
        {
            Point1 = point1;
            Point2 = point2;
            Color = Color.Black;
        }

        public override void Draw(Graphics3D graphics)
        {
            base.Draw(graphics);

            graphics.SetColor(Color);
            graphics.DrawLine(Point1, Point2);
        }
    }
}
