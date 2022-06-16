using System;

namespace Graphics.Utils
{
    public static class Converter
    {
        public static float RadToDeg(float rad)
        {
            return rad * 180 / (float)Math.PI;
        }

        public static float DegToRad(float deg)
        {
            return deg * (float)Math.PI / 180;
        }
    }
}
