namespace Archimedes
{
    /// <summary>
    /// Настройки вычислений.
    /// </summary>
    public static class ComputingSettings
    {
        /// <summary>
        /// Точность по умолчанию, с которой осуществляются приближённые вычисления.
        /// </summary>
        internal const double NumericalEpsilon = 1.0e-15;

        /// <summary>
        /// Полуточность по умолчанию, с которой осуществляются приближённые вычисления.
        /// </summary>
        public const double NumericalHalfEpsilon = NumericalEpsilon / 2.0;

        /// <summary>
        /// Угол в радианах, по абсолютной величине меньший этого значения, считается равным 0.
        /// </summary>
        internal const double ZeroAngleEpsilon = 1.0e-15;
    }
}