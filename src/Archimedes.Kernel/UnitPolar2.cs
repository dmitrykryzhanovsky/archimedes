namespace Archimedes
{
    public class UnitPolar2 : Polar2
    {
        public UnitPolar2 (double heading) : base ()
        {
            _r       = 1.0;
            _heading = heading;
        }
        
        public new UnitVector2 ToCartesian ()
        {
            if ((_heading == 0.0) || (_heading == double.Tau)) return UnitVector2.CreateDirect (1.0, 0.0);
            else if (_heading == MathConst.M_PI_2) return UnitVector2.CreateDirect (0.0, 1.0);
            else if ((_heading == double.Pi) || (_heading == -double.Pi)) return UnitVector2.CreateDirect (-1.0, 0.0);
            else if ((_heading == -MathConst.M_PI_2) || (_heading == 3.0 * MathConst.M_PI_2)) return UnitVector2.CreateDirect (0.0, -1.0);

            (double sin, double cos) = double.SinCos (_heading);

            return UnitVector2.CreateDirect (cos, sin);
        }
    }
}