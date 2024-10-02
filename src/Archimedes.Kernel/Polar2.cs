namespace Archimedes
{
    /// <summary>
    /// Полярные координаты на плоскости.
    /// </summary>
    public class Polar2 : ICloneable, IEquatable<Polar2>
    {
        protected double _r;

        protected double _heading;

        /// <summary>
        /// Расстояние от начала координат.
        /// </summary>
        /// <remarks>Должно быть больше или равно 0.</remarks>
        public virtual double R
        {
            get => _r;

            set
            {
                if (value >= 0.0) _r = value;

                else throw new ArgumentOutOfRangeException ();
            }
        }

        /// <summary>
        /// Полярный угол.
        /// </summary>
        public double Heading
        {
            get => _heading;

            set => _heading = value;
        }

        #region Constructors

        protected Polar2 ()
        {
        }

        public Polar2 (double r, double heading)
        {
            R       = r;
            Heading = heading;
        }

        public Polar2 (Polar2 other)
        {
            _r       = other._r;
            _heading = other._heading;
        }

        public virtual object Clone ()
        {
            return new Polar2 (this);
        }

        internal static Polar2 DirectInit (double r, double heading)
        {
            Polar2 output = new Polar2 ();

            output._r       = r;
            output._heading = heading;

            return output;
        }

        #endregion

        #region Comparisons

        public bool Equals (Polar2? other)
        {
            return ((_r == other._r) && ((Trigonometry.AreEqualAngles (_heading, other._heading)) || 
                                         (_r == 0.0)));
        }

        public static bool operator == (Polar2 p1, Polar2 p2)
        {
            return p1.Equals (p2);
        }

        public static bool operator != (Polar2 p1, Polar2 p2)
        {
            return !p1.Equals (p2);
        }

        #endregion

        public Polar2 Rotate (double phi)
        {
            (double sinPhi, double cosPhi) = double.SinCos (phi);

            return Rotate (sinPhi, cosPhi);
        }

        public Polar2 Rotate (double sinPhi, double cosPhi)
        {
            (double sinHeading, double cosHeading) = double.SinCos (_heading);

            double dx = cosHeading * cosPhi - sinHeading * sinPhi;
            double dy = cosHeading * sinPhi + sinHeading * cosPhi;

            return Polar2.DirectInit (_r, Trigonometry.Atan2Small (dx, dy, ComputingSettings.SmallAngleEpsilon));
        }

        /// <summary>
        /// Преобразование из полярных координат в декартовы.
        /// </summary>
        public virtual Vector2 ToCartesian ()
        {
            (double sin, double cos) = double.SinCos (_heading);

            return new Vector2 (x: _r * cos, 
                                y: _r * sin);
        }        
    }
}