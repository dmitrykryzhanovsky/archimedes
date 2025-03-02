namespace Archimedes
{
    public class HourAngle : Angle, IEquatable<HourAngle>, IComparable<HourAngle>
    {
        public override EAngularUnit Unit
        {
            get => EAngularUnit.Hour;
        }

        public override double Phase => throw new NotImplementedException ();

        public override int Periods => throw new NotImplementedException ();

        public HourAngle (double value) : base (value)
        {
        }

        public override object Clone ()
        {
            throw new NotImplementedException ();
        }

        public bool Equals (HourAngle? other)
        {
            throw new NotImplementedException ();
        }

        public int CompareTo (HourAngle? other)
        {
            throw new NotImplementedException ();
        }

        public static bool AreEqualPhase (HourAngle angle1, HourAngle angle2)
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