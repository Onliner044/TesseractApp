using Graphics.Contracts;
using Graphics.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace Graphics
{
    public class Graphics3D
    {
        private System.Drawing.Graphics _graphics;

        private Pen _pen;

        private float _z0;
        private float _resolution;
        private float _fieldOfView;
        private SizeF _halfBoundSize;

        private Matrix4x4 _model;
        private Stack<Matrix4x4> _transformations;

        public Graphics3D(Control control)
        {
            _graphics = control.CreateGraphics();
            
            _pen = new Pen(Color.Black);

            _model = Matrix4x4.Identity;
            _transformations = new Stack<Matrix4x4>();

            _resolution = _graphics.VisibleClipBounds.Height;
            _fieldOfView = Converter.DegToRad(70.0f);
            _z0 = (_resolution / 2.0f) / (float)Math.Tan((_fieldOfView / 2.0f) * (float)Math.PI / 180.0f);

            _halfBoundSize = _graphics.VisibleClipBounds.Size;
            _halfBoundSize = new SizeF(_halfBoundSize.Width / 2, _halfBoundSize.Height / 2);
        }

        public void SetColor(Color color)
        {
            _pen.Color = color;
        }

        public void DrawLine(Vector3 point1, Vector3 point2)
        {
            PushTransform();
            _model = GetTransform();

            var pointF1 = ProjectVector(point1);
            var pointF2 = ProjectVector(point2);

            _graphics.DrawLine(_pen, pointF1, pointF2);
            PopTransform();
        }

        public void DrawCircle(Vector3 point, float size)
        {
            _model = GetTransform();

            var pointF1 = PointF.Subtract(ProjectVector(point), new SizeF(size / 2.0f, size / 2.0f));
            
            _graphics.FillEllipse(_pen.Brush, pointF1.X, pointF1.Y, size, size);
        }

        public void Clear(Color color)
        {
            _graphics.Clear(color);
        }

        public void Scale(Vector3 scale)
        {
            _model *= Matrix4x4.CreateScale(scale);
        }

        public void Rotation(Vector3 axis, float angle)
        {
            Rotation(Quaternion.CreateFromAxisAngle(axis, angle));
        }

        public void Rotation(Quaternion rotation)
        {
            rotation = Quaternion.Normalize(rotation);
            _model = Matrix4x4.Transform(_model, rotation);
        }

        public void Translate(Vector3 position)
        {
            _model *= Matrix4x4.CreateTranslation(position);
        }

        public void PushTransform()
        {
            _transformations.Push(_model);
            _model = Matrix4x4.Identity;
        }

        public void PopTransform()
        {
            _model = _transformations.Pop();
        }

        internal void ApplyTransform(IDrawable drawable)
        {
            var transform = drawable.Transform;

            Translate(transform.Origin);
            Scale(transform.Scaling);
            Rotation(transform.Rotation);
            Translate(transform.Position);
        }

        private Vector3 ApplyTransformToVector(Vector3 vector, Matrix4x4 matrix)
        {
            return Vector3.Transform(vector, matrix);
        }

        private PointF ProjectVector(Vector3 vector)
        {
            vector = ApplyTransformToVector(vector, _model);

            var point = new PointF();
            point.X = vector.X * _z0 / (_z0 + vector.Z) + _halfBoundSize.Width;
            point.Y = -vector.Y * _z0 / (_z0 + vector.Z) + _halfBoundSize.Height;

            return point;
        }

        private Matrix4x4 GetTransform()
        {
            Matrix4x4 result = Matrix4x4.Identity;

            foreach (var transform in _transformations)
            {
                result *= transform;
            }

            return result;
        }
    }
}
