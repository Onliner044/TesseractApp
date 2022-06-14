using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Drawing3D.Primitives
{
    public class Cube : Primitive
    {
        Quad quad;
        float edgeLength;

        public Cube(float edgeLength)
        {
            this.edgeLength = edgeLength;
            quad = new Quad(this.edgeLength);
        }

        public override void Draw(Graphics3D graphics)
        {
            graphics.PushTransform();
            quad.Draw(graphics);

            graphics.DrawLine(new Vector3(0, 0, 0), new Vector3(0, 0, edgeLength));
            graphics.DrawLine(new Vector3(0, edgeLength, 0), new Vector3(0, edgeLength, edgeLength));
            graphics.DrawLine(new Vector3(edgeLength, edgeLength, 0), new Vector3(edgeLength, edgeLength, edgeLength));
            graphics.DrawLine(new Vector3(edgeLength, 0, 0), new Vector3(edgeLength, 0, edgeLength));

            graphics.PushTransform();
            graphics.Translate(new Vector3(0, 0, edgeLength));
            quad.Draw(graphics);
            graphics.PopTransform();

            graphics.PopTransform();
        }
    }
}
