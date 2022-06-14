using Drawing3D.Contracts;
using Drawing3D.Primitives;
using Drawing3D.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;

namespace Drawing3D
{
    public class Canvas
    {
        private List<Primitive> _drawables;
        private Graphics3D _graphics3D;
        private Graphics _graphics;

        private Canvas()
        {
            _drawables = new List<Primitive>();
        }

        public Canvas(Graphics graphics)
            : this()
        {
            this._graphics = graphics;
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

        public void Clear(Color color) => _graphics.Clear(color);
    }
}
