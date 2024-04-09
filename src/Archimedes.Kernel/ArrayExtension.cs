using System.Numerics;

namespace Archimedes
{
    public static class ArrayExtension
    {
        public static void CopyTo<T> (this T [] source, T [,] destination)
        {
            throw new NotImplementedException ();
        }

        public static void CopyTo<T> (this T [,] source, T [,] destination)
        {
            throw new NotImplementedException ();
        }

        /// <summary>
        /// Возвращает TRUE, если два массива поэлементно равны. В противном случае FALSE.
        /// </summary>
        public static bool Equals<T> (this T [] collection1, T [] collection2) where T : INumber<T>
        {
            if (collection1.Length == collection2.Length)
            {
                for (int i = 0; i < collection1.Length; i++)
                {
                    if (collection1 [i] != collection2 [i]) return false;
                }

                return true;
            }

            else return false;
        }

        public static bool Equals<T> (this T [,] collection1, T [,] collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [] Add<T> (this T [] collection1, T [] collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [,] Add<T> (this T [,] collection1, T [,] collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [] Subtract<T> (this T [] collection1, T [] collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [,] Subtract<T> (this T [,] collection1, T [,] collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [] Negate<T> (this T [] collection) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [,] Negate<T> (this T [,] collection) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [] Multiply<T> (this T [] collection, T coefficient) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [,] Multiply<T> (this T [,] collection, T coefficient) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [] Divide<T> (this T [] collection, T coefficient) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [,] Divide<T> (this T [,] collection, T coefficient) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T InnerProduct<T> (this T [] collection1, T [] collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }
    }
}