using Drawing3D.Contracts;
using Drawing3D.Utils;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Drawing3D.Primitives
{
    public class Cube : Primitive
    {
        public Cube(float edgeLength)
        {
            Quad quad = new Quad(edgeLength);
            Children.Add(quad);

            quad = new Quad(edgeLength);
            quad.Transform.Translate(new Vector3(0, 0, edgeLength), Mode.Local);
            Children.Add(quad);

            for (int i = 0; i < 4; i++)
            {
                Line line = new Line(new Vector3(0, 0, 0), new Vector3(0, 0, edgeLength));
                line.Transform.Origin = new Vector3(edgeLength / 2, edgeLength / 2, 0);
                line.Transform.Rotate(Vector3.UnitZ, Converter.DegToRad(90 * i), Mode.Local);

                Children.Add(line);
            }

            Transform.Origin = new Vector3(edgeLength / 2);
        }
    }
}
