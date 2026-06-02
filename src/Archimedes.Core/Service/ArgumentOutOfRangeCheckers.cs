using System.Numerics;

namespace Archimedes
{
    /// <summary>
    /// Методы для проверки числовых значений на соответствие заданным диапазонам.
    /// </summary>
    public static class ArgumentOutOfRangeCheckers
    {
        /// <summary>
        /// Проверяет, равно ли число x числу a, и если нет, то генерирует исключение.
        /// </summary>
        public static void CheckEqual<T> (T x, T a) where T : INumber<T>
        {
            if (x != a) throw new ArgumentOutOfRangeException ();
        }

        /// <summary>
        /// Проверяет, является ли число x положительным, и если нет, то генерирует исключение.
        /// </summary>
        public static void CheckPositive<T> (T x) where T : INumber<T>
        {
            if ((T.IsNegative (x) || T.IsZero (x))) throw new ArgumentOutOfRangeException ();
        }

        /// <summary>
        /// Проверяет, является ли число x положительным или равным 0, и если нет, то генерирует исключение.
        /// </summary>
        public static void CheckNotNegative<T> (T x) where T : INumber<T>
        {
            if (T.IsNegative (x)) throw new ArgumentOutOfRangeException ();
        }

        /// <summary>
        /// Проверяет, что число x больше числа a, и если нет, то генерирует исключение.
        /// </summary>
        public static void CheckGreater<T> (T x, T a) where T : INumber<T>
        {
            if (x <= a) throw new ArgumentOutOfRangeException ();
        }

        /// <summary>
        /// Проверяет, что число x больше или равно числу a, и если нет, то генерирует исключение.
        /// </summary>
        public static void CheckGreaterEqual<T> (T x, T a) where T : INumber<T>
        {
            if (x < a) throw new ArgumentOutOfRangeException ();
        }

        /// <summary>
        /// Проверяет, лежит ли число x на интервале [a; b], и если нет, то генерирует исключение.
        /// </summary>
        public static void CheckInterval<T> (T x, T a, T b) where T : INumber<T>
        {
            if ((x < a) || (x > b)) throw new ArgumentOutOfRangeException (); 
        }

        /// <summary>
        /// Проверяет, лежит ли число x на полуинтервале [a; b), и если нет, то генерирует исключение.
        /// </summary>
        public static void CheckIntervalRightExcluded<T> (T x, T a, T b) where T : INumber<T>
        {
            if ((x < a) || (x >= b)) throw new ArgumentOutOfRangeException ();
        }         
   }
}