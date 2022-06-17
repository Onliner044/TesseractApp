using Graphics;
using Graphics.Primitives;
using Graphics.Utils;
using System.Numerics;

namespace TesseractApp
{
    public class Tesseract : Primitive
    {
        public float EdgeLength { get; }

        private Cube _cube;
        private float _halfEdgeLength;

        public Tesseract(float edgeLength)
        {
            EdgeLength = edgeLength;
            _halfEdgeLength = EdgeLength / 2.0f;

            _cube = new Cube(EdgeLength, Pen);
        }

        public override void Draw(Graphics3D graphics)
        {
            base.Draw(graphics);

            graphics.SetColor(Pen.Color);
            _cube.Draw(graphics);

            graphics.PushTransform();
            graphics.Translate(Vector3.One * _halfEdgeLength);
            graphics.Scale(Vector3.One * 0.5f);
            _cube.Draw(graphics);
            graphics.PopTransform();

            for (int i = 0; i < 4; i++)
            {
                graphics.PushTransform();
                graphics.Rotation(Vector3.UnitY, Converter.DegToRad(90.0f * i));

                graphics.Translate(Vector3.One * _halfEdgeLength);
                graphics.DrawLine(Vector3.One * _halfEdgeLength / 2.0f, Vector3.One * _halfEdgeLength);

                graphics.Translate(-Vector3.One * _halfEdgeLength);
                graphics.Rotation(Vector3.UnitX, Converter.DegToRad(180.0f));

                graphics.Translate(Vector3.One * _halfEdgeLength);
                graphics.DrawLine(Vector3.One * _halfEdgeLength / 2.0f, Vector3.One * _halfEdgeLength);

                graphics.PopTransform();
            }
        }
    }
}
