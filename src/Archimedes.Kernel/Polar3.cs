namespace Archimedes
{
    public class Polar3 : ICloneable, IEquatable<Polar3>
    {
        private double _r;

        private double _latitude;

        private double _longitude;

        /// <summary>
        /// Расстояние от начала координат.
        /// </summary>
        /// <remarks>Должно быть больше или равно 0.</remarks>
        public double R
        {
            get => _r;

            set
            {
                if (value >= 0.0) _r = value;

                else throw new ArgumentOutOfRangeException ();
            }
        }

        /// <summary>
        /// Широта.
        /// </summary>
        /// <remarks>Должна быть на отрезке [−π/2; + π/2].</remarks>
        public double Latitude
        {
            get => _latitude;

            set
            {
                if ((-MathConst.M_PI_2 <= _latitude) && (Latitude <= MathConst.M_PI_2)) _latitude = value;

                else throw new ArgumentOutOfRangeException ();
            }
        }

        /// <summary>
        /// Долгота.
        /// </summary>
        public double Longitude
        {
            get => _longitude;

            set => _longitude = value;
        }

        #region Constructors

        private Polar3 ()
        {
        }

        public Polar3 (double r, double latitude, double longitude)
        {
            R         = r;
            Latitude  = latitude;
            Longitude = longitude;
        }

        public Polar3 (Polar3 other)
        {
            _r         = other._r;
            _latitude  = other._latitude;
            _longitude = other._longitude;
        }

        public object Clone ()
        {
            return new Polar3 (this);
        }

        internal static Polar3 DirectInit (double r, double latitude, double longitude)
        {
            Polar3 output = new Polar3 ();

            output._r         = r;
            output._latitude  = latitude;
            output._longitude = longitude;

            return output;
        }

        #endregion

        #region Comparisons

        public bool Equals (Polar3? other)
        {
            return ((_r == other._r) && (((_latitude == other._latitude) && (Trigonometry.AreEqualAngles (_longitude, other._longitude)) || 
                                                                            ((_latitude == MathConst.M_PI_2) ||(_longitude == -MathConst.M_PI_2))) ||
                                         (_r == 0.0)));
        }

        public static bool operator == (Polar3 p1, Polar3 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (Polar3 p1, Polar3 p2)
        {
            return !p1.Equals (p2);
        }

        #endregion

        public Polar3 RotateAroundOX (double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateAroundOX (sinPhi, cosPhi);
        }

        public Polar3 RotateAroundOX (double sinPhi, double cosPhi)
        {
            (double sinB, double cosB) = double.SinCos (_latitude);
            (double sinL, double cosL) = double.SinCos (_longitude);

            double dx = cosB * cosL;
            double dy = cosB * sinL * cosPhi - sinB * sinPhi;
            double sinB1 = cosB * sinL * sinPhi + sinB * cosPhi;

            return Polar3.DirectInit (_r,
                Trigonometry.AsinSmall (sinB1, ComputingSettings.SmallAngleEpsilon),
                Trigonometry.Atan2Small (dx, dy, ComputingSettings.SmallAngleEpsilon));
        }

        public Polar3 RotateAroundOY (double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateAroundOY (sinPhi, cosPhi);
        }

        public Polar3 RotateAroundOY (double sinPhi, double cosPhi)
        {
            (double sinB, double cosB) = double.SinCos (_latitude);
            (double sinL, double cosL) = double.SinCos (_longitude);

            double dx = cosB * sinL * cosPhi + sinB * sinPhi;
            double dy = cosB * cosL;
            double sinB1 = -cosB * cosL * sinPhi + sinB * cosPhi;

            return Polar3.DirectInit (_r,
                Trigonometry.AsinSmall (sinB1, ComputingSettings.SmallAngleEpsilon),
                Trigonometry.Atan2Small (dx, dy, ComputingSettings.SmallAngleEpsilon));
        }

        public Polar3 RotateAroundOZ (double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return RotateAroundOZ (sinPhi, cosPhi);
        }

        public Polar3 RotateAroundOZ (double sinPhi, double cosPhi)
        {
            (double sinB, double cosB) = double.SinCos (_latitude);
            (double sinL, double cosL) = double.SinCos (_longitude);

            double dx = cosB * cosL * cosPhi - cosB * sinL * sinPhi; ;
            double dy = cosB * cosL * sinPhi + cosB * sinL * cosPhi;

            return Polar3.DirectInit (_r, _latitude,
                Trigonometry.Atan2Small (dx, dy, ComputingSettings.SmallAngleEpsilon));
        }

        /// <summary>
        /// Преобразование из полярных координат в декартовы.
        /// </summary>
        public Vector3 ToCartesian ()
        {
            (double sinB, double cosB) = double.SinCos (_latitude);
            (double sinL, double cosL) = double.SinCos (_longitude);

            double oxyProjection = _r * cosB;

            return new Vector3 (x: oxyProjection * cosL,
                                y: oxyProjection * sinL, 
                                z: _r * sinB);
        }
    }
}