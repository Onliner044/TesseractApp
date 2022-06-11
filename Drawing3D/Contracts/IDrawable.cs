using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;

namespace Drawing3D.Contracts
{
    public interface IDrawable
    {
        Transformation Transform { get; }

        void Draw(Graphics3D graphics);
    }
}
