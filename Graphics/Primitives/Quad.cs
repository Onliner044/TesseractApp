using Graphics.Utils;
using System.Drawing;
using System.Numerics;

namespace Graphics.Primitives
{
    public class Quad : Figure
    {
        public override Color OutlineColor
        {
            get => base.OutlineColor;
            set
            {
                _line.Color = value;
                base.OutlineColor = value;
            }
        }

        public float VerticesSize { get; set; }
        public float EdgeLength { get; }

        private Line _line;

        public Quad(float edgeLength)
        {
            EdgeLength = edgeLength;
            VerticesSize = 5.0f;

            _line = new Line(Vector3.Zero, Vector3.UnitX * EdgeLength);
        }

        public override void Draw(Graphics3D graphics)
        {
            base.Draw(graphics);

            if (HasOutline)
            {
                graphics.SetColor(OutlineColor);

                graphics.PushTransform();
                for (int i = 0; i < 4; i++)
                {
                    graphics.Rotation(Vector3.UnitZ, Converter.DegToRad(90.0f));
                    graphics.Translate(Vector3.UnitX * EdgeLength);
                    _line.Draw(graphics);
                }
                graphics.PopTransform();
            }

            if (HasVertices)
            {
                graphics.SetColor(VerticesColor);

                graphics.PushTransform();
                for (int i = 0; i < 4; i++)
                {
                    graphics.Rotation(Vector3.UnitZ, Converter.DegToRad(90.0f));
                    graphics.Translate(Vector3.UnitX * EdgeLength);
                    graphics.DrawCircle(_line.Point1, VerticesSize);
                    graphics.DrawCircle(_line.Point2, VerticesSize);
                }
                graphics.PopTransform();
            }

            if (HasFill)
            {
                graphics.SetColor(FillColor);
                graphics.FillPolygon(new Vector3[]
                {
                    Vector3.Zero,
                    Vector3.UnitY,
                    Vector3.One - Vector3.UnitZ,
                    Vector3.UnitX,
                });
            }
        }
    }
}
