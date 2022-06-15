using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;

namespace Graphics.Contracts
{
    public interface IDrawable
    {
        Transformation Transform { get; }

        void Draw(Graphics3D graphics);
    }
}
