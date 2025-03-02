namespace Archimedes
{
    public abstract class Angle : ICloneable
    {
        public double Value { get; set; }

        public abstract EAngularUnit Unit { get; }

        protected Angle (double value)
        {
            Value = value;
        }

        public abstract object Clone ();

        public abstract DegAngle ToDeg ();

        public abstract HourAngle ToHour ();

        public abstract RadAngle ToRad ();

        public abstract OrbitAngle ToOrbit ();

        public static bool AreEqualPhase (Angle angle1, Angle angle2)
        {
            throw new NotImplementedException ();
        }
    }
}