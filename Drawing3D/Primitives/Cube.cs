using Graphics.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graphics.Primitives
{
    public class Cube : Primitive
    {
        public Quad Quad { get; }
        public float EdgeLength { get; }

        public Cube(float edgeLength)
        {
            EdgeLength = edgeLength;

            Quad = new Quad(EdgeLength);
        }

        public Cube(float edgeLength, Pen pen)
        {
            EdgeLength = edgeLength;
            Pen = pen;

            Quad = new Quad(EdgeLength, Pen);
        }

        public override void Draw(Graphics3D graphics)
        {
            base.Draw(graphics);

            graphics.PushTransform();

            Quad.Draw(graphics);

            graphics.PushTransform();
            graphics.Translate(new Vector3(0,0,EdgeLength));
            Quad.Draw(graphics);
            graphics.PopTransform();

            graphics.Rotation(Vector3.UnitX, Converter.DegToRad(90.0f));
            Quad.Draw(graphics);
            graphics.Translate(new Vector3(0, EdgeLength, 0));
            Quad.Draw(graphics);

            graphics.PopTransform();
        }
    }
}
