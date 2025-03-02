namespace Archimedes
{
    public class RadAngle : Angle, IEquatable<RadAngle>, IComparable<RadAngle>
    {
        public override EAngularUnit Unit
        {
            get => EAngularUnit.Rad;
        }

        public override double Phase => throw new NotImplementedException ();

        public override int Periods => throw new NotImplementedException ();

        public RadAngle (double value) : base (value)
        {
        }

        public override object Clone ()
        {
            throw new NotImplementedException ();
        }

        public bool Equals (RadAngle? other)
        {
            throw new NotImplementedException ();
        }

        public int CompareTo (RadAngle? other)
        {
            throw new NotImplementedException ();
        }

        public static bool AreEqualPhase (RadAngle angle1, RadAngle angle2)
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