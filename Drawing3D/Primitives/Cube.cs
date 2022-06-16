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
        public float EdgeLength { get; }

        private Quad _quad;
        private float _halfEdgeLength;

        public Cube(float edgeLength)
        {
            EdgeLength = edgeLength;
            _halfEdgeLength = EdgeLength / 2.0f;

            _quad = new Quad(EdgeLength);
        }

        public Cube(float edgeLength, Pen pen)
        {
            EdgeLength = edgeLength;
            _halfEdgeLength = EdgeLength / 2.0f;

            Pen = pen;

            _quad = new Quad(EdgeLength, Pen);
        }

        public override void Draw(Graphics3D graphics)
        {
            base.Draw(graphics);

            _quad.Draw(graphics);

            graphics.PushTransform();
            graphics.Translate(Vector3.UnitZ * EdgeLength);
            _quad.Draw(graphics);
            graphics.PopTransform();

            graphics.PushTransform();
            for (int i = 0; i < 4; i++)
            {
                graphics.Translate(new Vector3(-Vector2.One * _halfEdgeLength, 0));
                graphics.Rotation(Vector3.UnitZ, Converter.DegToRad(90.0f * i));
                graphics.Translate(new Vector3(Vector2.One * _halfEdgeLength, 0));
                graphics.DrawLine(Vector3.Zero, Vector3.UnitZ * EdgeLength);
            }
            graphics.PopTransform();
        }
    }
}
