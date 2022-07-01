using System.Drawing;
using System.Numerics;

namespace Graphics
{
    internal class Projection
    {
        private SizeF _halfBoundSize;

        public Projection(SizeF size)
        {
            SetBounds(size);
        }

        internal void SetBounds(SizeF size)
        {
            _halfBoundSize = new SizeF(size.Width / 2, size.Height / 2);
        }

        internal PointF OrthographicProjection(Vector3 vector)
        {
            PointF point = new PointF();
            point.X = vector.X + _halfBoundSize.Width;
            point.Y = vector.Y + _halfBoundSize.Height;

            return point;
        }
    }
}
