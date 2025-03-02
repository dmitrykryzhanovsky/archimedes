namespace Archimedes
{
    public class RadAngle : Angle
    {
        public override EAngularUnit Unit
        {
            get => EAngularUnit.Rad;
        }

        public RadAngle (double value) : base (value)
        {
        }

        public override object Clone ()
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