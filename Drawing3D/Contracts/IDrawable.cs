namespace Graphics.Contracts
{
    public interface IDrawable
    {
        Transformation Transform { get; }

        void Draw(Graphics3D graphics);
    }
}
