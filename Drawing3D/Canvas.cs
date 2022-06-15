using Graphics.Contracts;
using Graphics.Primitives;
using System.Collections.Generic;
using System.Drawing;

namespace Graphics
{
    public class Canvas
    {
        private List<IDrawable> _drawables;
        private Graphics3D _graphics3D;
        private System.Drawing.Graphics _graphics;

        public Canvas(System.Drawing.Graphics graphics)
        {
            this._graphics = graphics;
            _drawables = new List<IDrawable>();
            _graphics3D = new Graphics3D(_graphics);
        }

        public void Add(Primitive drawable)
        {
            _drawables.Add(drawable);
        }

        public void Draw()
        {
            foreach (var drawable in _drawables)
            {
                drawable.Draw(_graphics3D);
            }
        }

        public void Clear(Color color)
        {
            _graphics.Clear(color);
        } 
    }
}
