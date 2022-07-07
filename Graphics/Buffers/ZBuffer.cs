using System.Drawing;

namespace Graphics.Buffers
{
    internal class ZBuffer : ScreenBuffer<float>
    {
        public bool Enabled { get; set; }

        public ZBuffer(Size size)
            : base(size)
        {
            Clear();
        }

        public override void Resize(Size size)
        {
            base.Resize(size);
            Clear();
        }

        public bool Test(Point point, float z, bool rewrite = true)
        {
            if (!Enabled)
            {
                return true;
            }

            int index = point.X + point.Y * Size.Width;
            float z0 = GetBuffer(index);

            if (z0 < z)
            {
                if (rewrite)
                {
                    SetBuffer(index, z);
                }

                return true;
            }

            return false;
        }

        public override void Clear()
        {
            for (int i = 0; i < _buffer.Length; i++)
            {
                SetBuffer(i, float.MinValue);
            }
        }
    }
}
