using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace Graphics
{
    public class Graphics3D
    {
        public event PaintEventHandler Paint;

        public Pen Pen { get; }
        public PictureBox Canvas { get; }
        public Renderer Renderer { get; }

        private Matrix4x4 _localTransform;
        private Matrix4x4 _globalTransform;
        private Stack<Matrix4x4> _transformations;

        public Graphics3D(PictureBox canvas)
        {
            Canvas = canvas;
            Renderer = new Renderer(Canvas);
            Pen = new Pen(Color.Black);

            _localTransform = Matrix4x4.Identity;
            _globalTransform = Matrix4x4.Identity;
            _transformations = new Stack<Matrix4x4>();

            Canvas.Paint += Control_Paint;
        }

        public void SetColor(Color color)
        {
            Pen.Color = color;
        }

        public void FillTriangle(Vector3 a, Vector3 b, Vector3 c)
        {
            a = ProjectVector(a);
            b = ProjectVector(b);
            c = ProjectVector(c);

            Renderer.Rasterizer.FillTriangle(a, b, c, Pen.Color);
        }

        public void DrawLine(Vector3 point1, Vector3 point2)
        {
            point1 = ProjectVector(point1);
            point2 = ProjectVector(point2);

            Renderer.Rasterizer.DrawLine(point1, point2, Pen.Color);
        }

        public void DrawCircle(Vector3 point, float size)
        {
            point = ProjectVector(point);

            Renderer.Rasterizer.DrawCircle(point, size, Pen.Color);
        }

        public void Clear()
        {
            Renderer.Clear();
        }

        public void Scale(Vector3 scale)
        {
            _localTransform *= Matrix4x4.CreateScale(scale);
        }

        public void Rotation(Vector3 axis, float angle)
        {
            Rotation(Quaternion.CreateFromAxisAngle(axis, angle));
        }

        public void Rotation(Quaternion rotation)
        {
            rotation = Quaternion.Normalize(rotation);
            _localTransform = Matrix4x4.Transform(_localTransform, rotation);
        }

        public void Translate(Vector3 position)
        {
            _localTransform *= Matrix4x4.CreateTranslation(position);
        }

        public void PushTransform()
        {
            _transformations.Push(_localTransform);
            _transformations.Push(_globalTransform);

            _globalTransform = _localTransform * _globalTransform;
            _localTransform = Matrix4x4.Identity;
        }

        public void PopTransform()
        {
            _globalTransform = _transformations.Pop();
            _localTransform = _transformations.Pop();
        }

        public void Resize()
        {
            Canvas.Image = null;

            Renderer.Resize(Canvas.Size);
        }

        private Vector3 ProjectVector(Vector3 point)
        {
            point = Vector3.Transform(point, _localTransform * _globalTransform);
            return Renderer.Projection.OrthographicProjection(point);
        }

        private void Control_Paint(object sender, PaintEventArgs e)
        {
            Paint?.Invoke(sender, new PaintEventArgs(Renderer.DirectBitmap.Graphics, e.ClipRectangle));

            Renderer.Prerender();

            Canvas.Image = Renderer.DirectBitmap.Bitmap;
        }
    }
}
