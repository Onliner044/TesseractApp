using System.Windows.Forms;

namespace Drawing3D
{
    public class Canvas : Control
    {
        public Canvas()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.ContainerControl |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor
                          , true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


        }
    }
}
