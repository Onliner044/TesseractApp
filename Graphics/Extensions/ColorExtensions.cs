using System.Drawing;

namespace Graphics.Extensions
{
    internal static class ColorExtensions
    {
        public static Color Blend(this Color src, Color bg)
        {
            float A = 255 - (255 - src.A) * (255 - bg.A) / 255.0f;
            float R = (src.R * src.A + bg.R * (255 - src.A)) / 255.0f;
            float G = (src.G * src.A + bg.G * (255 - src.A)) / 255.0f;
            float B = (src.B * src.A + bg.B * (255 - src.A)) / 255.0f;

            return Color.FromArgb((byte)A, (byte)R, (byte)G, (byte)B);
        }
    }
}
