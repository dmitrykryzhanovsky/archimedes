namespace Archimedes
{
    /// <summary>
    /// Настройки вычислений.
    /// </summary>
    public static class ComputingSettings
    {
        internal const double NumericalEpsilonEpslion = 1.0e-15;

        public const double NumericalHalfEpsilon = NumericalEpsilonEpslion / 2.0;

        /// <summary>
        /// Угол в радианах, по абсолютной величине меньший этого значения, считается равным 0.
        /// </summary>
        internal const double ZeroAngleEpsilon = 1.0e-15;
    }
}