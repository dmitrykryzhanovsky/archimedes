namespace Archimedes
{
    public class UnitPolar3 : Polar3, IEquatable<UnitPolar3>
    {
        public override double R
        {
            set
            {
                throw new InvalidOperationException ();
            }
        }

        #region Constructors

        public UnitPolar3 (double latitude, double longitude) : base ()
        {
            _r         = 1.0;
            _latitude  = latitude;
            _longitude = longitude;
        }

        public UnitPolar3 (UnitPolar3 other) : base (other)
        {
        }

        public override object Clone ()
        {
            return new UnitPolar3 (this);
        }

        #endregion

        #region Comparisons

        public bool Equals (UnitPolar3? other)
        {
            return (((_latitude == other._latitude) && (Trigonometry.AreEqualAngles (_longitude, other._longitude)) || 
                                                       ((_latitude == MathConst.M_PI_2) ||(_longitude == -MathConst.M_PI_2))));
        }

        public static bool operator == (UnitPolar3 p1, UnitPolar3 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (UnitPolar3 p1, UnitPolar3 p2)
        {
            return !p1.Equals (p2);
        }

        #endregion

        public new UnitPolar3 RotateAroundOX (double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateAroundOX (sinPhi, cosPhi);
        }

        public new UnitPolar3 RotateAroundOX (double sinPhi, double cosPhi)
        {
            (double sinB, double cosB) = double.SinCos (_latitude);
            (double sinL, double cosL) = double.SinCos (_longitude);

            double dx = cosB * cosL;
            double dy = cosB * sinL * cosPhi - sinB * sinPhi;
            double sinB1 = cosB * sinL * sinPhi + sinB * cosPhi;

            return new UnitPolar3 (Trigonometry.AsinSmall (sinB1, ComputingSettings.SmallAngleEpsilon),
                                   Trigonometry.Atan2Small (dx, dy, ComputingSettings.SmallAngleEpsilon));
        }

        public new UnitPolar3 RotateAroundOY (double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateAroundOY (sinPhi, cosPhi);
        }

        public new UnitPolar3 RotateAroundOY (double sinPhi, double cosPhi)
        {
            (double sinB, double cosB) = double.SinCos (_latitude);
            (double sinL, double cosL) = double.SinCos (_longitude);

            double dx = cosB * sinL * cosPhi + sinB * sinPhi;
            double dy = cosB * cosL;
            double sinB1 = -cosB * cosL * sinPhi + sinB * cosPhi;

            return new UnitPolar3 (Trigonometry.AsinSmall (sinB1, ComputingSettings.SmallAngleEpsilon),
                                   Trigonometry.Atan2Small (dx, dy, ComputingSettings.SmallAngleEpsilon));
        }

        public new UnitPolar3 RotateAroundOZ (double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateAroundOZ (sinPhi, cosPhi);
        }

        public new UnitPolar3 RotateAroundOZ (double sinPhi, double cosPhi)
        {
            double cosB = double.Cos (_latitude);
            (double sinL, double cosL) = double.SinCos (_longitude);

            double dx = cosB * cosL * cosPhi - cosB * sinL * sinPhi;
            double dy = cosB * cosL * sinPhi + cosB * sinL * cosPhi;

            return new UnitPolar3 (_latitude, Trigonometry.Atan2Small (dx, dy, ComputingSettings.SmallAngleEpsilon));
        }

        /// <summary>
        /// Преобразование из полярных координат в декартовы.
        /// </summary>
        public override Vector3 ToCartesian ()
        {
            (double sinB, double cosB) = double.SinCos (_latitude);
            (double sinL, double cosL) = double.SinCos (_longitude);

            return new Vector3 (x: cosB * cosL,
                                y: cosB * sinL, 
                                z: sinB);
        }
    }
}