using Graphics.Utils;
using System;
using System.Drawing;
using System.Numerics;

namespace Graphics
{
    internal class Projection
    {
        private float _z0;
        private float _resolution;
        private float _fieldOfView;
        private SizeF _halfBoundSize;

        public Projection(SizeF size)
        {
            SetBounds(size);
        }

        internal void SetBounds(SizeF size)
        {
            _resolution = size.Height;
            _fieldOfView = Converter.DegToRad(70.0f);
            _z0 = (_resolution / 2.0f) / (float)Math.Tan((_fieldOfView / 2.0f) * (float)Math.PI / 180.0f);

            _halfBoundSize = new SizeF(size.Width / 2, size.Height / 2);
        }

        internal PointF ProjectVector(Vector3 vector)
        {
            PointF point = new PointF();
            point.X = vector.X * _z0 / (_z0 + vector.Z) + _halfBoundSize.Width;
            point.Y = -vector.Y * _z0 / (_z0 + vector.Z) + _halfBoundSize.Height;

            return point;
        }
    }
}
