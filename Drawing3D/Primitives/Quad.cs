using Drawing3D.Contracts;
using System.Collections.Generic;
using System.Numerics;

namespace Drawing3D.Primitives
{
    public class Quad : Primitive
    {
        public Quad(float edgeLength)
        {
            Children.AddRange(new List<IDrawable>()
            {
                new Line(new Vector3(0, 0, 0), new Vector3(0, edgeLength, 0)),
                new Line(new Vector3(0, edgeLength, 0), new Vector3(edgeLength, edgeLength, 0)),
                new Line(new Vector3(edgeLength, edgeLength, 0), new Vector3(edgeLength, 0, 0)),
                new Line(new Vector3(edgeLength, 0, 0), new Vector3(0, 0, 0)),
            });
        }
    }
}
