namespace Archimedes
{
    /// <summary>
    /// Настройки вычислений.
    /// </summary>
    internal static class ComputingSettings
    {
        /// <summary>
        /// Угол, по абсолютной величине меньший этого значения, считается равным 0.
        /// </summary>
        internal const double SmallAngleEpsilon = 1.0e-12;
    }
}