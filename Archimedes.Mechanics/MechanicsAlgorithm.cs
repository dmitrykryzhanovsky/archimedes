using System;

namespace Archimedes.Mechanics
{
    public static class MechanicsAlgorithm
    {
        public static Vector2 CenterOfMass (double [] mass, Vector2 [] r)
        {
            double mx = 0.0, my = 0.0, m = 0.0;

            for (int i = 0; i < mass.Length; i++)
            {
                mx += mass [i] * r [i].X;
                my += mass [i] * r [i].Y;
                m  += mass [i];
            }

            return new Vector2 (mx / m, my / m);
        }
    }
}