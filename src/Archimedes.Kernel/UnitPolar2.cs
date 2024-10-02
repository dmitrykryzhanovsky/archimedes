namespace Archimedes
{
    public class UnitPolar2 : Polar2, IEquatable<UnitPolar2>
    {
        public override double R
        {
            set
            {
                throw new InvalidOperationException ();
            }
        }

        #region Constructors

        public UnitPolar2 (double heading) : base ()
        {
            _r       = 1.0;
            _heading = heading;
        }

        public UnitPolar2 (UnitPolar2 other) : base (other)
        {
        }

        public override object Clone ()
        {
            return new UnitPolar2 (this);
        }

        #endregion

        #region Comparisons

        public bool Equals (UnitPolar2? other)
        {
            return (Trigonometry.AreEqualAngles (_heading, other._heading));
        }

        public static bool operator == (UnitPolar2 p1, UnitPolar2 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (UnitPolar2 p1, UnitPolar2 p2)
        {
            return !p1.Equals (p2);
        }

        #endregion

        public new UnitPolar2 Rotate (double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return Rotate (sinPhi, cosPhi);
        }

        public new UnitPolar2 Rotate (double sinPhi, double cosPhi)
        {
            (double sinHeading, double cosHeading) = double.SinCos (_heading);

            double dx = cosHeading * cosPhi - sinHeading * sinPhi;
            double dy = cosHeading * sinPhi + sinHeading * cosPhi;

            return new UnitPolar2 (Trigonometry.Atan2Small (dx, dy, ComputingSettings.SmallAngleEpsilon));
        }

        /// <summary>
        /// Преобразование из полярных координат в декартовы.
        /// </summary>
        public override Vector2 ToCartesian ()
        {
            (double sin, double cos) = double.SinCos (_heading);

            return new Vector2 (x: cos, 
                                y: sin);
        }        
    }
}