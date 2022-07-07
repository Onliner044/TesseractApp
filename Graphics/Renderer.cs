using Graphics.Buffers;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Graphics
{
    public class Renderer
    {
        public Control Canvas { get; }
        internal Projection Projection { get; }
        internal DirectBitmap DirectBitmap { get; }
        internal Rasterizer Rasterizer { get; }

        public Renderer(Control control)
        {
            Canvas = control;

            DirectBitmap = new DirectBitmap(Canvas.Size);
            Projection = new Projection(Canvas.Size);
            Rasterizer = new Rasterizer(DirectBitmap);
        }

        public void SetDoubleBuffered(bool enabled)
        {
            typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                | BindingFlags.Instance | BindingFlags.NonPublic, null,
                Canvas, new object[] { enabled });
        }

        public void SetZBuffer(bool enabled)
        {
            DirectBitmap.ZBuffer.Enabled = enabled;
        }

        public void SetBackgroundColor(Color color)
        {
            DirectBitmap.Background = color;
        }

        internal void Prerender()
        {
            DirectBitmap.DrawTransparent();
        }

        internal void Resize(Size size)
        {
            DirectBitmap.Resize(size);
            Projection.Resize(size);
        }

        internal void Clear()
        {
            DirectBitmap.Clear();
        }
    }
}
