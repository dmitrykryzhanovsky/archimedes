namespace Archimedes
{
    public class OrbitAngle : Angle, IEquatable<OrbitAngle>, IComparable<OrbitAngle>
    {
        public override EAngularUnit Unit
        {
            get => EAngularUnit.Orbit;
        }

        public override double Phase => throw new NotImplementedException ();

        public override int Periods => throw new NotImplementedException ();

        public OrbitAngle (double value) : base (value)
        {
        }

        public override object Clone ()
        {
            throw new NotImplementedException ();
        }

        public bool Equals (OrbitAngle? other)
        {
            throw new NotImplementedException ();
        }

        public int CompareTo (OrbitAngle? other)
        {
            throw new NotImplementedException ();
        }

        public static bool AreEqualPhase (OrbitAngle angle1, OrbitAngle angle2)
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