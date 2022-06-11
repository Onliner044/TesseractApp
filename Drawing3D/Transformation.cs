using System;
using System.Numerics;

namespace Drawing3D
{
    public enum Mode
    {
        Local,
        World
    }

    public class Transformation
    {
        public Matrix4x4 Local { get; set; }
        public Matrix4x4 World { get; set; }

        public Quaternion Rotation { get; set; }
        public Vector3 Origin { get; set; }
        public Vector3 Position { get; set; }
        public Vector3 Scaling { get; set; }

        public Transformation()
        {
            Local = Matrix4x4.Identity;
            World = Matrix4x4.Identity;
            Rotation = Quaternion.Identity;
            Position = Vector3.Zero;
            Scaling = Vector3.One;
        }

        public void Rotate(Vector3 axis, float angle, Mode mode)
        {
            if (mode == Mode.World)
                World = Matrix4x4.Transform(World, Quaternion.CreateFromAxisAngle(axis, angle));
            else
                Local = Matrix4x4.Transform(Local, Quaternion.CreateFromAxisAngle(axis, angle));

            //Rotation = Quaternion.CreateFromAxisAngle(axis, angle);
        }

        public void Scale(Vector3 scale, Mode mode)
        {
            if (mode == Mode.World)
                World *= Matrix4x4.CreateScale(scale);
            else
                Local *= Matrix4x4.CreateScale(scale);

            //Scaling *= scale;
        }

        public void Translate(Vector3 position, Mode mode)
        {
            if (mode == Mode.World)
                World *= Matrix4x4.CreateTranslation(position);
            else
                Local *= Matrix4x4.CreateTranslation(position);

            //Origin += Position;
            //Position += position;
        }
    }
}
