using System;

namespace Archimedes
{
    /// <summary>
    /// Полярные координаты на 2-мерной плоскости.
    /// </summary>
    public class Polar2 : ICloneable
    {
        private readonly double _r;
        private readonly double _heading;

        /// <summary>
        /// Радиус.
        /// </summary>
        public double R
        {
            get => _r;
        }

        /// <summary>
        /// Полярный угол.
        /// </summary>
        public double Heading
        {
            get => _heading;
        }

        /// <summary>
        /// Проверяет радиус r на валидность.
        /// </summary>
        /// <remarks>Валидным является неотрицательное значение радиуса.</remarks>
        public static EValid CheckRadius (double r)
        {
            return (r >= 0.0) ? EValid.Valid : EValid.Invalid;
        }

        /// <summary>
        /// Проверяет полярный угол heading на валидность.
        /// </summary>
        /// <remarks>Любые значения полярного угла валидны, однако нормализованным считается значение в диапазоне (-180°; +180°] = 
        /// (–π; +π]. Значения вне этого диапазона считаются ненормализованными.</remarks>
        public static EAngleValid CheckHeading (double heading)
        {
            return ((-Math.PI < heading) && (heading <= Math.PI)) ? EAngleValid.Normalized :
                                                                    EAngleValid.NotNormalized;
        }

        #region Constructors

        public Polar2 (double r, double heading)
        {
            _r       = r;
            _heading = heading;
        }

        public Polar2 (Polar2 other) : this (other._r, other._heading)
        {
        }

        public object Clone ()
        {
            return new Polar2 (this);
        }

        #endregion

        /// <summary>
        /// Преобразует полярные координаты в декартовы.
        /// </summary>
        public Vector2 PolarToCartesian ()
        {
            (double sin, double cos) = Math.SinCos (_heading);

            return new Vector2 (_r * cos, _r * sin);
        }
    }
}