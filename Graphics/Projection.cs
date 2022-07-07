using System.Drawing;
using System.Numerics;

namespace Graphics
{
    internal class Projection
    {
        private SizeF _halfBoundSize;

        public Projection(SizeF size)
        {
            Resize(size);
        }

        public void Resize(SizeF size)
        {
            _halfBoundSize = new SizeF(size.Width / 2, size.Height / 2);
        }

        public Vector3 OrthographicProjection(Vector3 vector)
        {
            vector.X = vector.X + _halfBoundSize.Width;
            vector.Y = -vector.Y + _halfBoundSize.Height;

            return vector;
        }
    }
}
