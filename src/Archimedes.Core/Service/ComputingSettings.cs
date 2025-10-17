namespace Archimedes
{
    /// <summary>
    /// Настройки вычислений.
    /// </summary>
    internal static class ComputingSettings
    {
        internal const double NumericalEpsilon = 1.0e-14;

        /// <summary>
        /// Угол в радианах, по абсолютной величине меньший этого значения, считается равным 0.
        /// </summary>
        internal const double ZeroAngleEpsilon = 1.0e-14;
    }
}