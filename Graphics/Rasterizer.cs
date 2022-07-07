using Graphics.Buffers;
using Graphics.Utils;
using System;
using System.Drawing;
using System.Numerics;

namespace Graphics
{
    internal class Rasterizer
    {
        public DirectBitmap DirectBitmap { get; }

        public Rasterizer(DirectBitmap directBitmap)
        {
            DirectBitmap = directBitmap;
        }

        public void FillTriangle(Vector3 p1, Vector3 p2, Vector3 p3, Color color)
        {
            Plane plane = Plane.CreateFromVertices(p1, p2, p3);
            Vector3 normal = plane.Normal;

            Point point1 = new Point((int)p1.X * 16, (int)p1.Y * 16);
            Point point2 = new Point((int)p2.X * 16, (int)p2.Y * 16);
            Point point3 = new Point((int)p3.X * 16, (int)p3.Y * 16);

            Point delta12 = new Point(point1.X - point2.X, point1.Y - point2.Y);
            Point delta23 = new Point(point2.X - point3.X, point2.Y - point3.Y);
            Point delta31 = new Point(point3.X - point1.X, point3.Y - point1.Y);

            Point fd12 = new Point(delta12.X << 4, delta12.Y << 4);
            Point fd23 = new Point(delta23.X << 4, delta23.Y << 4);
            Point fd31 = new Point(delta31.X << 4, delta31.Y << 4);

            Rectangle box = Helpers.GetTriangleBox(point1, point2, point3);
            box = Rectangle.FromLTRB(
                (box.X + 0xF) >> 4,
                (box.Y + 0xF) >> 4,
                (box.X + box.Width + 0xF) >> 4,
                (box.Y + box.Height + 0xF) >> 4);

            int C1 = delta12.Y * point1.X - delta12.X * point1.Y;
            int C2 = delta23.Y * point2.X - delta23.X * point2.Y;
            int C3 = delta31.Y * point3.X - delta31.X * point3.Y;

            if (delta12.Y < 0 || (delta12.Y == 0 && delta12.X > 0)) C1++;
            if (delta23.Y < 0 || (delta23.Y == 0 && delta23.X > 0)) C2++;
            if (delta31.Y < 0 || (delta31.Y == 0 && delta31.X > 0)) C3++;

            int CY1 = C1 + delta12.X * (box.Y << 4) - delta12.Y * (box.X << 4);
            int CY2 = C2 + delta23.X * (box.Y << 4) - delta23.Y * (box.X << 4);
            int CY3 = C3 + delta31.X * (box.Y << 4) - delta31.Y * (box.X << 4);

            for (int y = box.Y; y < box.Height + box.Y; y++)
            {
                int CX1 = CY1;
                int CX2 = CY2;
                int CX3 = CY3;

                for (int x = box.X; x < box.Width + box.X; x++)
                {
                    if (CX1 <= 0 && CX2 <= 0 && CX3 <= 0)
                    {
                        float z = (-normal.X * x - normal.Y * y - plane.D) / normal.Z;
                        DirectBitmap.SetPixel(x, y, color, z);
                    }

                    CX1 -= fd12.Y;
                    CX2 -= fd23.Y;
                    CX3 -= fd31.Y;
                }

                CY1 += fd12.X;
                CY2 += fd23.X;
                CY3 += fd31.X;
            }
        }

        public void DrawLine(Vector3 t0, Vector3 t1, Color color)
        {
            bool steep = false;

            if (Math.Abs(t0.X - t1.X) < Math.Abs(t0.Y - t1.Y))
            {
                Helpers.Swap(ref t0.X, ref t0.Y);
                Helpers.Swap(ref t1.X, ref t1.Y);

                steep = true;
            }

            if (t0.X > t1.X)
            {
                Helpers.Swap(ref t0, ref t1);
            }

            for (int i = (int)t0.X; i < t1.X; i++)
            {
                float t = (i - t0.X) / (t1.X - t0.X);
                float z = t * (t1.Z - t0.Z) + t0.Z;

                int x = i;
                int y = (int)(t0.Y * (1 - t) + t1.Y * t);

                if (steep)
                {
                    Helpers.Swap(ref x, ref y);
                }

                DirectBitmap.SetPixel(x, y, color, z + 5);
            }
        }

        public void DrawCircle(Vector3 point, float radius, Color color)
        {
            for (float x = -radius; x < radius + 1; x++)
            {
                int dy = (int)Math.Sqrt(radius * radius - x * x);

                for (int y = -dy; y < dy + 1; y++)
                {
                    DirectBitmap.SetPixel(point.X + x, point.Y + y, color, point.Z + radius * radius);
                }
            }
        }
    }
}
