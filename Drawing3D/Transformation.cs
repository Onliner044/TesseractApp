using System;
using System.Numerics;

namespace Graphics
{
    public class Transformation
    {
        public Vector3 Origin { get; set; }
        public Vector3 Scaling { get; set; }
        public Vector3 Position { get; set; }
        public Quaternion Rotation { get; set; }

        public Transformation()
        {
            Origin = Vector3.Zero;
            Scaling = Vector3.One;
            Position = Vector3.Zero;
            Rotation = Quaternion.Identity;
        }

        public void Rotate(Vector3 axis, float angle)
        {
            Rotation *= Quaternion.Normalize(Quaternion.CreateFromAxisAngle(axis, angle));
        }

        public void Scale(Vector3 scale)
        {
            Scaling *= scale;
        }

        public void Translate(Vector3 position)
        {
            Position += position;
        }
    }
}
