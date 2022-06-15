using Graphics.Contracts;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Graphics.Primitives
{
    public class Quad : Primitive
    {
        public float EdgeLength { get; }

        public Quad(float edgeLength)
        {
            EdgeLength = edgeLength;
        }

        public Quad(float edgeLength, Pen pen)
            : this(edgeLength)
        {
            Pen = pen;
        }

        public override void Draw(Graphics3D graphics)
        {
            base.Draw(graphics);

            graphics.PushTransform();

            graphics.DrawLine(new Vector3(0, 0, 0), new Vector3(0, EdgeLength, 0));
            graphics.DrawLine(new Vector3(0, EdgeLength, 0), new Vector3(EdgeLength, EdgeLength, 0));
            graphics.DrawLine(new Vector3(EdgeLength, EdgeLength, 0), new Vector3(EdgeLength, 0, 0));
            graphics.DrawLine(new Vector3(EdgeLength, 0, 0), new Vector3(0, 0, 0));

            graphics.PopTransform();
        }
    }
}
