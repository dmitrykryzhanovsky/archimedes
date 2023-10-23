namespace Archimedes
{
    /// <summary>
    /// Настройки вычислений.
    /// </summary>
    internal static class ComputingSettings
    {
        /// <summary>
        /// Если используется этот параметр, то числа, меньшие чем 1.0e-12, будут считаться равными 0.
        /// </summary>
        internal const double ZeroAccuracy = 1.0e-12;
    }
}