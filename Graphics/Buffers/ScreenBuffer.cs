using Graphics.Contracts;
using System.Drawing;

namespace Graphics.Buffers
{
    internal abstract class ScreenBuffer<T> : IScreenBuffer<T>
    {
        public Size Size => _size;
        public virtual T[] Buffer => _buffer;

        protected Size _size;
        protected T[] _buffer;

        public ScreenBuffer(Size size)
        {
            _size = size;
            _buffer = new T[_size.Width * _size.Height];
        }

        public virtual void Resize(Size size)
        {
            _size = size;
            _buffer = new T[_size.Width * _size.Height];
        }

        public virtual void SetBuffer(int x, int y, T value)
        {
            _buffer[x + y * Size.Width] = value;
        }

        public virtual void SetBuffer(int index, T value)
        {
            _buffer[index] = value;
        }

        public virtual T GetBuffer(int x, int y)
        {
            return _buffer[x + y * Size.Width];
        }

        public virtual T GetBuffer(int index)
        {
            return _buffer[index];
        }

        public abstract void Clear();
    }
}
