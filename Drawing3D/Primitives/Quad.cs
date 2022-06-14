using Drawing3D.Contracts;
using System.Collections.Generic;
using System.Numerics;

namespace Drawing3D.Primitives
{
    public class Quad : Primitive
    {
        float _edgeLength;

        public Quad(float edgeLength)
        {
            _edgeLength = edgeLength;
        }

        public override void Draw(Graphics3D graphics)
        {
            graphics.PushTransform();

            graphics.DrawLine(new Vector3(0, 0, 0), new Vector3(0, _edgeLength, 0));
            graphics.DrawLine(new Vector3(0, _edgeLength, 0), new Vector3(_edgeLength, _edgeLength, 0));
            graphics.DrawLine(new Vector3(_edgeLength, _edgeLength, 0), new Vector3(_edgeLength, 0, 0));
            graphics.DrawLine(new Vector3(_edgeLength, 0, 0), new Vector3(0, 0, 0));

            graphics.PopTransform();
        }
    }
}
