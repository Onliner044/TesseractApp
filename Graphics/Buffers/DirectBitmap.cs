using Graphics.Extensions;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Graphics.Buffers
{
    internal class DirectBitmap : ScreenBuffer<int>, IDisposable
    {
        public Color Background { get; set; }
        public System.Drawing.Graphics Graphics { get; private set; }
        public Bitmap Bitmap { get; private set; }
        public ZBuffer ZBuffer { get; private set; }
        public AlphaBuffer AlphaBuffer { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public DirectBitmap(Size size)
            : base(size)
        {
            ZBuffer = new ZBuffer(size);
            AlphaBuffer = new AlphaBuffer(size);

            BitsHandle = GCHandle.Alloc(_buffer, GCHandleType.Pinned);
            Bitmap = new Bitmap(Size.Width, Size.Height, Size.Width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
            Graphics = System.Drawing.Graphics.FromImage(Bitmap);
        }

        public void DrawTransparent()
        {
            var aBuffer = AlphaBuffer.Buffer;
            var zBuffer = ZBuffer.Buffer;
            var rBuffer = Buffer;

            for (int i = 0; i < Buffer.Length; i++)
            {
                Color transparent = Color.FromArgb(0);

                aBuffer[i].Sort((a, b) => (int)(b.Depth - a.Depth));

                for (int j = aBuffer[i].Count - 1; j >= 0; j--)
                {
                    var surface = aBuffer[i][j];

                    if (surface.Depth > zBuffer[i])
                    {
                        transparent = surface.Color.Blend(transparent);
                    }
                }

                if (aBuffer[i].Count != 0)
                {
                    Color color = Color.FromArgb(rBuffer[i]);
                    Color finalColor = transparent.Blend(color);

                    rBuffer[i] = finalColor.ToArgb();
                }
            }
        }

        public void SetPixel(float x, float y, Color color, float z = 0)
        {
            Point p = new Point((int)x, (int)y);
            int index = p.X + (p.Y * Size.Width);

            if (!Graphics.VisibleClipBounds.Contains(x, y))
            {
                return;
            }

            if (color.A < 255)
            {
                AlphaBuffer.Buffer[index].Add(new PixelInfo(z, color));
            }
            else if (ZBuffer.Test(p, ZBuffer.Enabled ? z : 0))
            {
                SetBuffer(index, color.ToArgb());
            }
        }

        public Color GetPixel(int x, int y)
        {
            int col = GetBuffer(x, y);
            return Color.FromArgb(col);
        }

        public override void Resize(Size size)
        {
            base.Resize(size);

            Dispose();

            BitsHandle = GCHandle.Alloc(_buffer, GCHandleType.Pinned);
            Bitmap = new Bitmap(Size.Width, Size.Height, Size.Width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
            Graphics = System.Drawing.Graphics.FromImage(Bitmap);

            ZBuffer.Resize(size);
            AlphaBuffer.Resize(size);
        }

        public override void Clear()
        {
            Graphics.Clear(Background);
            AlphaBuffer.Clear();
            ZBuffer.Clear();
        }

        public void Dispose()
        {
            Bitmap.Dispose();
            Graphics.Dispose();
            BitsHandle.Free();
        }
    }
}
