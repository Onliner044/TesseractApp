using Drawing3D.Contracts;
using Drawing3D.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Drawing3D
{
    public class Graphics3D
    {
        private Graphics _graphics;
        private Pen _pen;

        private float _resolution;
        private float _fieldOfView;
        private float z0;
        private SizeF _halfBoundSize;

        private Stack<Matrix4x4> _transform;
        public Matrix4x4 _model;
        private Matrix4x4 _projection;

        public Graphics3D(Graphics graphics)
        {
            _graphics = graphics;
            
            _pen = new Pen(Color.Black);

            _projection = Matrix4x4.CreatePerspectiveFieldOfView(Converter.DegToRad(70), 1.0f, 0.1f, 100.0f);
            _model = Matrix4x4.Identity;
            _transform = new Stack<Matrix4x4>();

            _resolution = 200;
            _fieldOfView = 30;
            z0 = (_resolution / 2.0f) / (float)Math.Tan((_fieldOfView / 2.0f) * (float)Math.PI / 180.0f);
            
            _halfBoundSize = graphics.VisibleClipBounds.Size;
            _halfBoundSize = new SizeF(_halfBoundSize.Width / 2, _halfBoundSize.Height / 2);
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
            _transform.Push(_model);
            _model = Matrix4x4.Identity;
        }

        public void PopTransform()
        {
            _model = _transform.Pop();
        }

        Vector3 ApplyTransformToVector(Vector3 vector, Matrix4x4 matrix)
        {
            return Vector3.Transform(vector, matrix);
        }

        PointF ProjectVector(Vector3 vector)
        {
            vector = ApplyTransformToVector(vector, /*_projection **/ GetModel());
            
            var point = new PointF();
            point.X = vector.X * z0 / (z0 + vector.Z) + _halfBoundSize.Width;
            point.Y = -vector.Y * z0 / (z0 + vector.Z) + _halfBoundSize.Height;
            
            return point;
        }

        Matrix4x4 GetModel()
        {
            Matrix4x4 result = Matrix4x4.Identity;

            foreach (var model in _transform)
            {
                result *= model;
            }

            return result;
        }
    }
}
