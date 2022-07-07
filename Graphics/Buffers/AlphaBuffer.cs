using System.Collections.Generic;
using System.Drawing;

namespace Graphics.Buffers
{
    internal class AlphaBuffer : ScreenBuffer<List<PixelInfo>>
    {
        public AlphaBuffer(Size size)
            : base(size)
        {
            for (int i = 0; i < _buffer.Length; i++)
            {
                SetBuffer(i, new List<PixelInfo>());
            }
        }

        public override void Resize(Size size)
        {
            base.Resize(size);

            for (int i = 0; i < _buffer.Length; i++)
            {
                SetBuffer(i, new List<PixelInfo>());
            }
        }

        public override void Clear()
        {
            for (int i = 0; i < _buffer.Length; i++)
            {
                _buffer[i].Clear();
            }
        }
    }
}
