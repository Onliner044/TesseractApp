using Drawing3D.Contracts;
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
        private float _resolution;
        private float _fieldOfView;
        private float z0;
        private SizeF _halfBoundSize;

        private Stack<Matrix4x4> _transformLocal;
        private Stack<Matrix4x4> _transformWorld;
        public Matrix4x4 _local;
        public Matrix4x4 _world;

        public Graphics3D(Graphics graphics)
        {
            _graphics = graphics;
            _local = Matrix4x4.Identity;
            _world = Matrix4x4.Identity;
            _transformLocal = new Stack<Matrix4x4>();
            _transformWorld = new Stack<Matrix4x4>();

            _resolution = 200;
            _fieldOfView = 40;
            z0 = (_resolution / 2.0f) / (float)Math.Tan((_fieldOfView / 2.0f) * (float)Math.PI / 180.0f);
            
            _halfBoundSize = graphics.VisibleClipBounds.Size;
            _halfBoundSize = new SizeF(_halfBoundSize.Width / 2, _halfBoundSize.Height / 2);
        }

        public void DrawLine(Pen pen, Vector3 point1, Vector3 point2)
        {
            var pointF1 = ProjectVector(point1);
            var pointF2 = ProjectVector(point2);

            _graphics.DrawLine(pen, pointF1, pointF2);
        }

        public void PushLocal()
        {
            _transformLocal.Push(_local);
        }

        public void PushWorld()
        {
            _transformWorld.Push(_world);
        }

        public void PopLocal()
        {
            _local = _transformLocal.Pop();
        }

        public void PopWorld()
        {
            _world = _transformWorld.Pop();
        }

        public void ApplyLocal(IDrawable drawable)
        {
            //_local *= ApplyTransform(drawable, drawable.Transform.Local);

            _local *= Matrix4x4.CreateTranslation(-drawable.Transform.Origin);
            _local *= drawable.Transform.Local;
            _local *= Matrix4x4.CreateTranslation(drawable.Transform.Origin);

            //ApplyTransform(_local, drawable);
        }

        public void ApplyLocal(Matrix4x4 matrix)
        {
            _local = matrix;
        }

        public void ApplyWorld(IDrawable drawable)
        {
            _world *= Matrix4x4.CreateTranslation(-drawable.Transform.Origin);
            _world *= drawable.Transform.World;
            //_world *= Matrix4x4.CreateTranslation(drawable.Transform.Origin);
        }

        public void ApplyWorld(Matrix4x4 matrix)
        {
            _world = matrix;
        }

        Matrix4x4 ApplyTransform(IDrawable drawable, Matrix4x4 transform)
        {
            Matrix4x4 matrix = Matrix4x4.Identity;

            Vector3 position;
            Vector3 scale;
            Quaternion rotation;

            Matrix4x4.Decompose(transform, out scale, out rotation, out position);

            matrix *= Matrix4x4.CreateTranslation(drawable.Transform.Origin);
            matrix = Matrix4x4.Transform(matrix, rotation);
            matrix *= Matrix4x4.CreateTranslation(position);

            return matrix;
        }

        Vector3 ApplyTransformVector(Vector3 vector, Matrix4x4 matrix)
        {
            return Vector3.Transform(vector, matrix);
        }

        PointF ProjectVector(Vector3 vector)
        {
            vector = ApplyTransformVector(vector, _local * _world);

            var point = new PointF();
            point.X = vector.X * z0 / (z0 + vector.Z) + _halfBoundSize.Width;
            point.Y = -vector.Y * z0 / (z0 + vector.Z) + _halfBoundSize.Height;

            return point;
        }
    }
}
