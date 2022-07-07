using System.Drawing;

namespace Graphics.Buffers
{
    internal struct PixelInfo
    {
        public Color Color { get; set; }
        public float Depth { get; set; }

        public PixelInfo(float depth, Color color)
        {
            Color = color;
            Depth = depth;
        }
    }
}
