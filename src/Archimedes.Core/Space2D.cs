namespace Archimedes
{
    public static class Space2D
    {
        public static (double r, double heading) PolarCoordinates (double x, double y)
        {
            double r       = double.Hypot (x, y);
            double heading = double.Atan2 (y, x);

            return (r, heading);
        }
    }
}