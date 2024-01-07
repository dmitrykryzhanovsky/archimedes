namespace Archimedes
{
    /// <summary>
    /// Настройки вычислений.
    /// </summary>
    public static class ComputingSettings
    {
        /// <summary>
        /// Точность вычислений с типом double по-умолчанию.
        /// </summary>
        public const double DoublePrecision = 1.0e-16;

        /// <summary>
        /// Если используется этот параметр, то числа, меньшие чем ZeroAccuracy, будут считаться равными 0.
        /// </summary>
        internal const double ZeroAccuracy = 1.0e-12;
    }
}