using System.Numerics;

namespace Archimedes
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Копирует элементы одномерного массива в двумерный массив.
        /// </summary>
        /// <remarks>Размеры массивов должны совпадать, то есть длина одномерного массив <paramref name="source"/> должна быть равна 
        /// общему размеру двумерного массива <paramref name="destination"/>. В противном случае корректная работа метода не 
        /// гарантируется: результат может быть некорректным, могут возникнуть исключения.</remarks>
        public static void CopyTo<T> (this T [] source, T [,] destination)
        {
            int sourceIterator = 0;

            for (int i = 0; i < destination.GetLength (0); i++)
            {
                for (int j = 0; j < destination.GetLength (1); j++)
                {
                    destination [i, j] = source [sourceIterator++];
                }
            }
        }

        /// <summary>
        /// Копирует элементы одного двумерного массива в другой двумерный массив.
        /// </summary>
        /// <remarks>Размеры массивов должны совпадать; в противном случае корректная работа метода не гарантируется: результат может 
        /// быть некорректным, также могут возникнуть исключения.</remarks>
        public static void CopyTo<T> (this T [,] source, T [,] destination)
        {
            for (int i = 0; i < destination.GetLength (0); i++)
            {
                for (int j = 0; j < destination.GetLength (1); j++)
                {
                    destination [i, j] = source [i, j];
                }
            }
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
            if ((collection1.GetLength (0) == collection2.GetLength (0)) && 
                (collection1.GetLength (1) == collection2.GetLength (1)))
            {
                for (int i = 0; i < collection1.GetLength (0); i++)
                {
                    for (int j = 0; j < collection1.GetLength (1); j++)
                    {
                        if (collection1 [i, j] != collection2 [i, j]) return false;
                    }                    
                }

                return true;
            }

            else return false;
        }

        /// <summary>
        /// Поэлементное сложение двух массивов.
        /// </summary>
        /// <remarks>Проверка на равенство размеров массивов <paramref name="collection1"/> и <paramref name="collection2"/> внутри 
        /// метода не производится, но если они неравны, результат работы метода может оказаться некорректным.</remarks>
        public static T [] Add<T> (this T [] collection1, T [] collection2) where T : INumber<T>
        {
            T [] result = new T [collection1.Length];

            for (int i = 0; i < collection1.Length; i++)
            {
                result [i] = collection1 [i] + collection2 [i];
            }

            return result;
        }

        /// <summary>
        /// Поэлементное сложение двух массивов.
        /// </summary>
        /// <remarks>Проверка на равенство размеров массивов <paramref name="collection1"/> и <paramref name="collection2"/> внутри 
        /// метода не производится, но если они неравны, результат работы метода может оказаться некорректным.</remarks>
        public static T [,] Add<T> (this T [,] collection1, T [,] collection2) where T : INumber<T>
        {
            T [,] result = new T [collection1.GetLength (0), collection1.GetLength (1)];

            for (int i = 0; i < collection1.GetLength (0); i++)
            {
                for (int j = 0; j < collection1.GetLength (1); j++)
                {
                    result [i, j] = collection1 [i, j] + collection2 [i, j];
                }
            }

            return result;
        }

        /// <summary>
        /// Поэлементное вычитание двух массивов.
        /// </summary>
        /// <remarks>Проверка на равенство размеров массивов <paramref name="collection1"/> и <paramref name="collection2"/> внутри 
        /// метода не производится, но если они неравны, результат работы метода может оказаться некорректным.</remarks>
        public static T [] Subtract<T> (this T [] collection1, T [] collection2) where T : INumber<T>
        {
            T [] result = new T [collection1.Length];

            for (int i = 0; i < collection1.Length; i++)
            {
                result [i] = collection1 [i] - collection2 [i];
            }

            return result;
        }

        /// <summary>
        /// Поэлементное вычитание двух массивов.
        /// </summary>
        /// <remarks>Проверка на равенство размеров массивов <paramref name="collection1"/> и <paramref name="collection2"/> внутри 
        /// метода не производится, но если они неравны, результат работы метода может оказаться некорректным.</remarks>
        public static T [,] Subtract<T> (this T [,] collection1, T [,] collection2) where T : INumber<T>
        {
            T [,] result = new T [collection1.GetLength (0), collection1.GetLength (1)];

            for (int i = 0; i < collection1.GetLength (0); i++)
            {
                for (int j = 0; j < collection1.GetLength (1); j++)
                {
                    result [i, j] = collection1 [i, j] - collection2 [i, j];
                }
            }

            return result;
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