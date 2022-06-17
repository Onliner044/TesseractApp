using Drawing3D;
using Graphics.Contracts;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace Graphics
{
    public class Graphics3D
    {
        private Pen _pen;
        private Projection _projection;
        private System.Drawing.Graphics _graphics;

        private Matrix4x4 _localTransform;
        private Matrix4x4 _globalTransform;
        private Stack<Matrix4x4> _transformations;

        public Graphics3D(Control control)
        {
            _pen = new Pen(Color.Black);
            _graphics = control.CreateGraphics();
            _projection = new Projection(_graphics.VisibleClipBounds.Size);

            _localTransform = Matrix4x4.Identity;
            _globalTransform = Matrix4x4.Identity;
            _transformations = new Stack<Matrix4x4>();
        }

        public void SetColor(Color color)
        {
            _pen.Color = color;
        }

        public void DrawLine(Vector3 point1, Vector3 point2)
        {
            var pointF1 = ProjectVector(point1);
            var pointF2 = ProjectVector(point2);

            _graphics.DrawLine(_pen, pointF1, pointF2);
        }

        public void DrawCircle(Vector3 point, float size)
        {
            var pointF = PointF.Subtract(ProjectVector(point), new SizeF(size / 2.0f, size / 2.0f));
            
            _graphics.FillEllipse(_pen.Brush, pointF.X, pointF.Y, size, size);
        }

        public void Clear(Color color)
        {
            _graphics.Clear(color);
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

        private PointF ProjectVector(Vector3 point)
        {
            point = Vector3.Transform(point, _localTransform * _globalTransform);
            return _projection.ProjectVector(point);
        }
    }
}
