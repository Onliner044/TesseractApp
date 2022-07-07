using Graphics.Utils;
using System.Drawing;
using System.Numerics;

namespace Graphics.Primitives
{
    public class Cube : Figure
    {
        public override Color VerticesColor
        {
            get => base.VerticesColor;
            set
            {
                _outlinedQuad.VerticesColor = value;
                base.VerticesColor = value;
            }
        }

        public override Color OutlineColor
        {
            get => base.OutlineColor;
            set
            {
                _line.Color = value;
                _outlinedQuad.OutlineColor = value;
                base.OutlineColor = value;
            }
        }

        public override Color FillColor
        {
            get => base.FillColor;
            set
            {
                _filledQuad.FillColor = value;
                base.FillColor = value;
            }
        }

        public override bool HasVertices
        {
            get => base.HasVertices;
            set
            {
                _outlinedQuad.HasVertices = value;
                base.HasVertices = value;
            }
        }

        public override bool HasOutline
        {
            get => base.HasOutline;
            set
            {
                _outlinedQuad.HasOutline = value;
                base.HasOutline = value;
            }
        }

        public override bool HasFill
        {
            get => base.HasFill;
            set
            {
                _filledQuad.HasFill = value;
                base.HasFill = value;
            }
        }

        public float VerticesSize { get; set; }
        public float EdgeLength { get; }

        private Line _line;
        private Quad _filledQuad;
        private Quad _outlinedQuad;

        public Cube(float edgeLength)
        {
            EdgeLength = edgeLength;

            _line = new Line(Vector3.Zero, Vector3.UnitZ * EdgeLength);

            _filledQuad = new Quad(EdgeLength)
            {
                HasOutline = false,
                HasVertices = false,
            };

            _outlinedQuad = new Quad(EdgeLength)
            {
                HasFill = false,
            };
        }

        public override void Draw(Graphics3D graphics)
        {
            base.Draw(graphics);

            graphics.PushTransform();
            graphics.Rotation(Vector3.UnitY, Converter.DegToRad(90.0f));
            graphics.Translate(Vector3.UnitZ);
            _filledQuad.Draw(graphics);
            graphics.Translate(-Vector3.UnitZ);
            graphics.Rotation(Vector3.UnitY, Converter.DegToRad(180.0f));
            graphics.Translate(Vector3.UnitX);
            _filledQuad.Draw(graphics);
            graphics.PopTransform();

            graphics.PushTransform();
            for (int i = 0; i < 4; i++)
            {
                graphics.Rotation(Vector3.UnitX, Converter.DegToRad(90.0f));
                graphics.Translate(Vector3.UnitY);
                _filledQuad.Draw(graphics);
            }
            graphics.PopTransform();

            _outlinedQuad.Draw(graphics);

            graphics.PushTransform();
            graphics.Translate(Vector3.UnitZ * EdgeLength);
            _outlinedQuad.Draw(graphics);
            graphics.PopTransform();

            if (HasOutline)
            {
                graphics.PushTransform();
                for (int i = 0; i < 4; i++)
                {
                    graphics.Rotation(Vector3.UnitZ, Converter.DegToRad(90.0f));
                    graphics.Translate(Vector3.UnitX * EdgeLength);
                    _line.Draw(graphics);
                }
                graphics.PopTransform();
            }
        }
    }
}
