using Graphics.Utils;
using System;
using System.Drawing;
using System.Numerics;

namespace Drawing3D
{
    internal class Projection
    {
        private float _z0;
        private float _resolution;
        private float _fieldOfView;
        private SizeF _halfBoundSize;

        public Projection(System.Drawing.Graphics graphics)
        {
            _resolution = graphics.VisibleClipBounds.Height;
            _fieldOfView = Converter.DegToRad(70.0f);
            _z0 = (_resolution / 2.0f) / (float)Math.Tan((_fieldOfView / 2.0f) * (float)Math.PI / 180.0f);

            _halfBoundSize = graphics.VisibleClipBounds.Size;
            _halfBoundSize = new SizeF(_halfBoundSize.Width / 2, _halfBoundSize.Height / 2);
        }

        internal PointF ProjectVector(Vector3 vector)
        {
            var point = new PointF();
            point.X = vector.X * _z0 / (_z0 + vector.Z) + _halfBoundSize.Width;
            point.Y = -vector.Y * _z0 / (_z0 + vector.Z) + _halfBoundSize.Height;

            return point;
        }
    }
}
