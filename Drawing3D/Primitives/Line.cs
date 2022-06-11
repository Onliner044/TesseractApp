using System;
using System.Drawing;
using System.Numerics;

namespace Drawing3D.Primitives
{
    public class Line : Primitive
    {
        public Vector3 Point1 { get; private set; }
        public Vector3 Point2 { get; private set; }

        public Line(Vector3 point1, Vector3 point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public override void Draw(Graphics3D graphics)
        {
            graphics.DrawLine(Pen, Point1, Point2);
        }
    }
}
