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

        /// <summary>
        /// Возвращает TRUE, если два массива поэлементно равны. В противном случае FALSE.
        /// </summary>
        /// <remarks>Размеры массивов <paramref name="collection1"/> и <paramref name="collection2"/> тоже должны совпадать. Например, 
        /// если массив <paramref name="collection1"/> будет иметь размеры 2 х 3, а массив <paramref name="collection2"/> 3 х 2 (то есть 
        /// их общие количества элементов будут совпадать, но при этом не будет совпадать их распределение по строкам и столбцам), и оба 
        /// массива будут содержать равные элементы в одинаковом порядке, массивы равными считаться не будут.</remarks>
        public static bool Equals<T> (this T [,] collection1, T [,] collection2) where T : INumber<T>
        {
            int height = collection1.GetLength (0);
            int width  = collection1.GetLength (1);

            if ((height == collection2.GetLength (0)) && 
                (width  == collection2.GetLength (1)))
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (collection1 [i, j] != collection2 [i, j]) return false;
                    }                    
                }

                return true;
            }

            else return false;
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