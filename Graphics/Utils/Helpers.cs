using System.Drawing;

namespace Graphics.Utils
{
    internal static class Helpers
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static Rectangle GetTriangleBox(Point p1, Point p2, Point p3)
        {
            int maxX = MathEx.Extremum(Extremum.Max, p1.X, p2.X, p3.X);
            int maxY = MathEx.Extremum(Extremum.Max, p1.Y, p2.Y, p3.Y);
            int minX = MathEx.Extremum(Extremum.Min, p1.X, p2.X, p3.X);
            int minY = MathEx.Extremum(Extremum.Min, p1.Y, p2.Y, p3.Y);

            return new Rectangle(minX, minY, maxX - minX, maxY - minY);
        }
    }
}
