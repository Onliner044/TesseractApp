﻿using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace Graphics
{
    public class Graphics3D
    {
        public event PaintEventHandler Paint;

        private Pen _pen;
        private Projection _projection;
        private Control _control;
        private System.Drawing.Graphics _graphics;

        private Matrix4x4 _localTransform;
        private Matrix4x4 _globalTransform;
        private Stack<Matrix4x4> _transformations;

        public Graphics3D(Control control)
        {
            _control = control;
            _pen = new Pen(Color.Black);
            _projection = new Projection(SizeF.Empty);

            _localTransform = Matrix4x4.Identity;
            _globalTransform = Matrix4x4.Identity;
            _transformations = new Stack<Matrix4x4>();

            Paint += OnPaint;
            _control.Paint += _control_Paint;
        }

        public void Invalidate()
        {
            _control.Invalidate();
        }

        public void SetColor(Color color)
        {
            _pen.Color = color;
        }

        public void DrawLine(Vector3 point1, Vector3 point2)
        {
            PointF pointF1 = ProjectVector(point1);
            PointF pointF2 = ProjectVector(point2);

            _graphics.DrawLine(_pen, pointF1, pointF2);
        }

        public void DrawCircle(Vector3 point, float size)
        {
            PointF pointF = PointF.Subtract(ProjectVector(point), new SizeF(size / 2.0f, size / 2.0f));
            
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

        private void _control_Paint(object sender, PaintEventArgs e)
        {
            Paint?.Invoke(sender, e);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            _graphics = e.Graphics;
            _projection.SetBounds(_graphics.VisibleClipBounds.Size);
        }
    }
}
