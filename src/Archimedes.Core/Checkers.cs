namespace Archimedes
{
    internal static class Checkers
    {
        internal static void CheckR (double r)
        {
            if (r < 0.0) throw new ArgumentOutOfRangeException (nameof (r));
        }

        internal static void CheckLatitude (double latitude)
        {
            if ((latitude < -MathConst.M_PI_2) || (latitude > MathConst.M_PI_2)) throw new ArgumentOutOfRangeException (nameof (latitude));
        }
    }
}