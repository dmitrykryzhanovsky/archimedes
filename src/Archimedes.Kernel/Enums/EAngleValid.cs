namespace Archimedes
{
    /// <summary>
    /// Валидность значения угла.
    /// </summary>
    public enum EAngleValid
    {
        /// <summary>
        /// Невалидное значение.
        /// </summary>
        Invalid,

        /// <summary>
        /// Валидное, но ненормализованное.
        /// </summary>
        /// <remarks>В зависимости от предметной области нормализованным считается угол, приведённый в диапазон [0°; 360°) или 
        /// (-180°; +180°].</remarks>
        NotNormalized,

        /// <summary>
        /// Валидное и нормализованное.
        /// </summary>
        Normalized
    }
}