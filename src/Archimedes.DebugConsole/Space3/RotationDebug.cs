using Archimedes;
using Archimedes.Space3;

namespace Archimedes.DebugConsole.Space3
{
    internal static class RotationDebug
    {
        internal static void EulerAnglesAlpha ()
        {
            double alpha = double.Pi / 3.0;
            double beta  = 0.0;
            double gamma = 0.0;

            Matrix3 aroundOZ = Rotation.GetRotationMatrix.Passive.AroundOZ.GetMatrix (alpha);

            Console.WriteLine ("{0} {1} {2}\n{3} {4} {5}\n{6} {7} {8}",
                aroundOZ [0, 0], aroundOZ [0, 1], aroundOZ [0, 2],
                aroundOZ [1, 0], aroundOZ [1, 1], aroundOZ [1, 2],
                aroundOZ [2, 0], aroundOZ [2, 1], aroundOZ [2, 2]);

            Matrix3 euler = Rotation.GetRotationMatrix.Passive.EulerAngles.GetMatrix (alpha, beta, gamma);

            Console.WriteLine ("\n{0} {1} {2}\n{3} {4} {5}\n{6} {7} {8}",
                euler [0, 0], euler [0, 1], euler [0, 2],
                euler [1, 0], euler [1, 1], euler [1, 2],
                euler [2, 0], euler [2, 1], euler [2, 2]);

            Vector3 v = new Vector3 (double.Sqrt (3.0) / 2.0, 0.5, 0);

            Vector3 transform1 = euler * v;

            Console.WriteLine ("\n{0} {1} {2}", transform1.X, transform1.Y, transform1.Z);

            Vector3 transform2 = Rotation.Apply.Passive.EulerAngles.RotateSpace (v, alpha, beta, gamma);

            Console.WriteLine ("\n{0} {1} {2}", transform2.X, transform2.Y, transform2.Z);
        }

        internal static void EulerAnglesBeta ()
        {
            double alpha = double.Pi / 3.0;
            double beta  = double.Pi / 2.0;
            double gamma = 0.0;

            Matrix3 euler = Rotation.GetRotationMatrix.Passive.EulerAngles.GetMatrix (alpha, beta, gamma);

            Console.WriteLine ("{0} {1} {2}\n{3} {4} {5}\n{6} {7} {8}",
                euler [0, 0], euler [0, 1], euler [0, 2],
                euler [1, 0], euler [1, 1], euler [1, 2],
                euler [2, 0], euler [2, 1], euler [2, 2]);

            Vector3 v = new Vector3 (double.Sqrt (3.0) / 2.0, 0.5, 0);

            Vector3 transform1 = euler * v;

            Console.WriteLine ("\n{0} {1} {2}", transform1.X, transform1.Y, transform1.Z);

            Vector3 transform2 = Rotation.Apply.Passive.EulerAngles.RotateSpace (v, alpha, beta, gamma);

            Console.WriteLine ("\n{0} {1} {2}", transform2.X, transform2.Y, transform2.Z);
        }

        internal static void EulerAnglesGamma ()
        {
            double alpha =  double.Pi / 3.0;
            double beta  =  double.Pi / 2.0;
            double gamma = -double.Pi / 2.0;

            Matrix3 euler = Rotation.GetRotationMatrix.Passive.EulerAngles.GetMatrix (alpha, beta, gamma);

            Console.WriteLine ("{0} {1} {2}\n{3} {4} {5}\n{6} {7} {8}",
                euler [0, 0], euler [0, 1], euler [0, 2],
                euler [1, 0], euler [1, 1], euler [1, 2],
                euler [2, 0], euler [2, 1], euler [2, 2]);

            Vector3 v = new Vector3 (double.Sqrt (3.0) / 2.0, 0.5, 0);

            Vector3 transform1 = euler * v;

            Console.WriteLine ("\n{0} {1} {2}", transform1.X, transform1.Y, transform1.Z);

            Vector3 transform2 = Rotation.Apply.Passive.EulerAngles.RotateSpace (v, alpha, beta, gamma);

            Console.WriteLine ("\n{0} {1} {2}", transform2.X, transform2.Y, transform2.Z);
        }

        internal static void EulerAnglesVectorPolarUnitPolar ()
        {
            double alpha =  double.Pi / 3.0;
            double beta  =  double.Pi / 6.0;
            double gamma = -double.Pi / 4.0;

            Matrix3 euler = Rotation.GetRotationMatrix.Passive.EulerAngles.GetMatrix (alpha, beta, gamma);

            Console.WriteLine ("{0} {1} {2}\n{3} {4} {5}\n{6} {7} {8}",
                euler [0, 0], euler [0, 1], euler [0, 2],
                euler [1, 0], euler [1, 1], euler [1, 2],
                euler [2, 0], euler [2, 1], euler [2, 2]);

            Vector3    v = new Vector3 (double.Sqrt (3.0) / 2.0, 0.5, 0);
            Polar3     p = new Polar3 (1.0, 0.0, double.Pi / 6.0);
            UnitPolar3 u = new UnitPolar3 (0.0, double.Pi / 6.0);

            Vector3 transform1 = euler * v;

            Console.WriteLine ("\n{0} {1} {2}", transform1.X, transform1.Y, transform1.Z);

            Vector3 transform2 = Rotation.Apply.Passive.EulerAngles.RotateSpace (v, alpha, beta, gamma);

            Console.WriteLine ("\n{0} {1} {2}", transform2.X, transform2.Y, transform2.Z);

            Polar3 transform3 = Rotation.Apply.Passive.EulerAngles.RotateSpace (p, alpha, beta, gamma);

            Console.WriteLine ("R = {0} phi = {1} l = {2}", transform3.R, transform3.Latitude, transform3.Longitude);

            UnitPolar3 transform4 = Rotation.Apply.Passive.EulerAngles.RotateSpace (u, alpha, beta, gamma);

            Console.WriteLine ("R = {0} phi = {1} l = {2}", transform4.R, transform4.Latitude, transform4.Longitude);
        }
    }
}