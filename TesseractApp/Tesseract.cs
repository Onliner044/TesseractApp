using Graphics;
using Graphics.Primitives;
using Graphics.Utils;
using System.Drawing;
using System.Numerics;

namespace TesseractApp
{
    public class Tesseract : Figure
    {
        public override Color OutlineColor
        {
            get => base.OutlineColor;
            set
            {
                _line.Color = value;
                InnerCube.OutlineColor = value;
                OuterCube.OutlineColor = value;
                base.OutlineColor = value;
            }
        }

        public override Color FillColor
        {
            get => base.FillColor;
            set
            {
                InnerCube.FillColor = value;
                OuterCube.FillColor = value;
                base.OutlineColor = value;
            }
        }

        public override Color VerticesColor
        {
            get => base.VerticesColor;
            set
            {
                InnerCube.VerticesColor = value;
                OuterCube.VerticesColor = value;
                base.OutlineColor = value;
            }
        }

        public override bool HasOutline
        {
            get => base.HasOutline;
            set
            {
                InnerCube.HasOutline = value;
                OuterCube.HasOutline = value;
                base.HasOutline = value;
            }
        }

        public override bool HasVertices
        {
            get => base.HasVertices;
            set
            {
                InnerCube.HasVertices = value;
                OuterCube.HasVertices = value;
                base.HasVertices = value;
            }
        }

        public override bool HasFill
        {
            get => base.HasFill;
            set
            {
                InnerCube.HasFill = value;
                OuterCube.HasFill = value;
                base.HasFill = value;
            }
        }

        public Cube InnerCube { get; }
        public Cube OuterCube { get; }
        public float EdgeLength { get; }

        private Line _line;
        private float _halfEdgeLength;

        public Tesseract(float edgeLength)
        {
            EdgeLength = edgeLength;
            _halfEdgeLength = EdgeLength / 2.0f;

            _line = new Line(Vector3.One * _halfEdgeLength / 2.0f, Vector3.One * _halfEdgeLength);

            OuterCube = new Cube(EdgeLength)
            {
                HasFill = false,
            };

            InnerCube = new Cube(EdgeLength);
        }

        public override void Draw(Graphics3D graphics)
        {
            base.Draw(graphics);

            graphics.PushTransform();
            graphics.Translate(Vector3.One * _halfEdgeLength);
            graphics.Scale(Vector3.One * 0.5f);
            InnerCube.Draw(graphics);
            graphics.PopTransform();

            OuterCube.Draw(graphics);

            graphics.SetColor(OuterCube.OutlineColor);

            if (HasOutline)
            {
                for (int i = 0; i < 4; i++)
                {
                    graphics.PushTransform();
                    graphics.Rotation(Vector3.UnitY, Converter.DegToRad(90.0f * i));

                    graphics.Translate(Vector3.One * _halfEdgeLength);
                    _line.Draw(graphics);

                    graphics.Translate(-Vector3.One * _halfEdgeLength);
                    graphics.Rotation(Vector3.UnitX, Converter.DegToRad(180.0f));

                    graphics.Translate(Vector3.One * _halfEdgeLength);
                    _line.Draw(graphics);

                    graphics.PopTransform();
                }
            }
        }
    }
}
