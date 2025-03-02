namespace Archimedes
{
    public abstract class Angle : ICloneable, IEquatable<Angle>, IComparable<Angle>
    {
        public abstract EAngularUnit Unit { get; }

        public double Value { get; set; }

        public abstract double Phase { get; }

        public abstract int Periods { get; }

        protected Angle (double value)
        {
            Value = value;
        }

        public abstract object Clone ();

        public bool Equals (Angle? other)
        {
            throw new NotImplementedException ();
        }

        public int CompareTo (Angle? other)
        {
            throw new NotImplementedException ();
        }

        public static bool AreEqualPhase (Angle angle1, Angle angle2)
        {
            throw new NotImplementedException ();
        }

        public abstract void NormalizeMinusPlus ();

        public abstract void NormalizePositive ();

        public abstract DegAngle ToDeg ();

        public abstract HourAngle ToHour ();

        public abstract RadAngle ToRad ();

        public abstract OrbitAngle ToOrbit ();        
    }
}