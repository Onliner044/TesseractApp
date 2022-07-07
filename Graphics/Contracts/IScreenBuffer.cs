using System.Drawing;

namespace Graphics.Contracts
{
    public interface IScreenBuffer<T>
    {
        Size Size { get; }
        T[] Buffer { get; }
    }
}
