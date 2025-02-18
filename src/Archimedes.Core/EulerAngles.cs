namespace Archimedes
{
    /// <summary>
    /// Структура для хранения углов Эйлера.
    /// </summary>
    public struct EulerAngles
    {
        /// <summary>
        /// Угол прецессии.
        /// </summary>
        public double Alpha;

        /// <summary>
        /// Угол нутации.
        /// </summary>
        public double Beta;

        /// <summary>
        /// Угол собственного вращения.
        /// </summary>
        public double Gamma;

        public EulerAngles (double alpha, double beta, double gamma)
        {
            Alpha = alpha;
            Beta  = beta;
            Gamma = gamma;
        }
    }
}