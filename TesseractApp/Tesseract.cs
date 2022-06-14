using Drawing3D;
using Drawing3D.Primitives;
using System.Numerics;

namespace TesseractApp
{
    public class Tesseract : Primitive
    {
        Cube cube;
        float _edgeLength;

        public Tesseract(float edgeLength)
        {
            _edgeLength = edgeLength;
            
            cube = new Cube(_edgeLength);
        }

        public override void Draw(Graphics3D graphics)
        {
            cube.Draw(graphics);

            graphics.PushTransform();
            graphics.Translate(new Vector3(_edgeLength / 2.0f));
            graphics.Scale(new Vector3(0.5f));
            cube.Draw(graphics);
            graphics.PopTransform();
        }
    }
}
