namespace Archimedes
{
    public class DegAngle : Angle, IEquatable<DegAngle>, IComparable<DegAngle>
    {
        public override EAngularUnit Unit
        {
            get => EAngularUnit.Deg;
        }

        public override double Phase => throw new NotImplementedException ();

        public override int Periods => throw new NotImplementedException ();

        public DegAngle (double value) : base (value)
        {
        }

        public override object Clone ()
        {
            throw new NotImplementedException ();
        }

        public bool Equals (DegAngle? other)
        {
            throw new NotImplementedException ();
        }

        public int CompareTo (DegAngle? other)
        {
            throw new NotImplementedException ();
        }

        public static bool AreEqualPhase (DegAngle angle1, DegAngle angle2)
        {
            throw new NotImplementedException ();
        }

        public override void NormalizeMinusPlus ()
        {
            throw new NotImplementedException ();
        }

        public override void NormalizePositive ()
        {
            throw new NotImplementedException ();
        }

        public override DegAngle ToDeg ()
        {
            throw new NotImplementedException ();
        }

        public override HourAngle ToHour ()
        {
            throw new NotImplementedException ();
        }

        public override RadAngle ToRad ()
        {
            throw new NotImplementedException ();
        }

        public override OrbitAngle ToOrbit ()
        {
            throw new NotImplementedException ();
        }
    }
}