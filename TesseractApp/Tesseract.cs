using Graphics;
using Graphics.Primitives;
using Graphics.Utils;
using System.Numerics;

namespace TesseractApp
{
    public class Tesseract : Primitive
    {
        public Cube Cube { get; }
        public float EdgeLength { get; }

        public Tesseract(float edgeLength)
        {
            EdgeLength = edgeLength;

            Cube = new Cube(EdgeLength, Pen);
        }

        public override void Draw(Graphics3D graphics)
        {
            base.Draw(graphics);

            Cube.Draw(graphics);

            graphics.PushTransform();
            graphics.Translate(new Vector3(EdgeLength / 2.0f));
            graphics.Scale(new Vector3(0.5f));
            Cube.Draw(graphics);

            graphics.PopTransform();
        }
    }
}
