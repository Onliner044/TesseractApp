namespace Graphics.Utils
{
    internal enum Extremum
    {
        Max,
        Min
    }

    internal static class MathEx
    {
        public static int Extremum(Extremum option, params int[] values)
        {
            int result = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                int val = values[i];

                if (option == Utils.Extremum.Max && result < val ||
                    option == Utils.Extremum.Min && result > val)
                {
                    result = val;
                }
            }

            return result;
        }
    }
}
