using System;
using System.Numerics;

namespace Drawing3D
{
    public class Transformation
    {
        public Quaternion Rotation { get; set; }
        public Vector3 Origin { get; set; }
        public Vector3 Position { get; set; }
        public Vector3 Scaling { get; set; }

        public Transformation()
        {
            Rotation = Quaternion.Identity;
            Position = Vector3.Zero;
            Scaling = Vector3.One;
        }

        public void Rotate(Vector3 axis, float angle)
        {
            Quaternion rotation = Quaternion.Normalize(Quaternion.CreateFromAxisAngle(axis, angle));
            Rotation *= rotation;
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
