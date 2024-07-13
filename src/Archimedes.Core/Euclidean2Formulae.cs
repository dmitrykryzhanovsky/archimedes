namespace Archimedes
{
    public static class Euclidean2Formulae
    {
        public static (double x2, double y2) RotateVector (double sin, double cos, double x1, double y1)
        {
            return (x2: x1 * cos - y1 * sin,
                    y2: x1 * sin + y1 * cos);
        }
    }
}