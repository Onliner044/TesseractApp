using Graphics.Contracts;
using Graphics.Utils;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Graphics.Primitives
{
    public class Quad : Primitive
    {
        public float EdgeLength { get; }

        private Line _line;

        public Quad(float edgeLength)
        {
            EdgeLength = edgeLength;
            _line = new Line(Vector3.Zero, Vector3.UnitX * EdgeLength);
        }

        public Quad(float edgeLength, Pen pen)
        {
            Pen = pen;
            EdgeLength = edgeLength;
            _line = new Line(Vector3.Zero, Vector3.UnitX * EdgeLength, Pen);
        }

        public override void Draw(Graphics3D graphics)
        {
            base.Draw(graphics);

            graphics.PushTransform();
            _line.Draw(graphics);
            graphics.Translate(Vector3.UnitY * EdgeLength);
            _line.Draw(graphics);
            graphics.PopTransform();

            graphics.PushTransform();
            graphics.DrawLine(Vector3.Zero, Vector3.UnitY * EdgeLength);
            graphics.DrawLine(Vector3.UnitX * EdgeLength, Vector3.UnitX * EdgeLength + Vector3.UnitY * EdgeLength);
            graphics.PopTransform();
        }
    }
}
