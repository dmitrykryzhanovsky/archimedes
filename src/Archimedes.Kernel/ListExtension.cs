using System.Numerics;

namespace Archimedes
{
    public static class ListExtension
    {
        /// <summary>
        /// Возвращает TRUE, если два списка поэлементно равны. В противном случае FALSE.
        /// </summary>
        public static bool Equals<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            if (collection1.Count == collection2.Count)
            {
                for (int i = 0; i < collection1.Count; i++)
                {
                    if (collection1 [i] != collection2 [i]) return false;
                }

                return true;
            }

            else return false;
        }

        /// <summary>
        /// Поэлементное сложение двух списков.
        /// </summary>
        /// <remarks>Проверка на равенство размеров списков <paramref name="collection1"/> и <paramref name="collection2"/> внутри 
        /// метода не производится, но если они неравны, результат работы метода может оказаться некорректным.</remarks>
        public static List<T> Add<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            List<T> result = new List<T> (collection1.Count);

            for (int i = 0; i < collection1.Count; i++)
            {
                result.Add (collection1 [i] + collection2 [i]);
            }

            return result;
        }

        /// <summary>
        /// Поэлементное прибавление списка <paramref name="collection2"/> к списку <paramref name="collection1"/>.
        /// </summary>
        /// <remarks>Проверка на равенство размеров списков <paramref name="collection1"/> и <paramref name="collection2"/> внутри 
        /// метода не производится, но если они неравны, результат работы метода может оказаться некорректным.</remarks>
        public static void AddTo<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            for (int i = 0; i < collection1.Count; i++)
            {
                collection1 [i] += collection2 [i];
            }
        }

        /// <summary>
        /// Поэлементное вычитание двух списков.
        /// </summary>
        /// <remarks>Проверка на равенство размеров списков <paramref name="collection1"/> и <paramref name="collection2"/> внутри 
        /// метода не производится, но если они неравны, результат работы метода может оказаться некорректным.</remarks>
        public static List<T> Subtract<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            List<T> result = new List<T> (collection1.Count);

            for (int i = 0; i < collection1.Count; i++)
            {
                result.Add (collection1 [i] - collection2 [i]);
            }

            return result;
        }

        /// <summary>
        /// Поэлементное вычитание списка <paramref name="collection2"/> из списка <paramref name="collection1"/>.
        /// </summary>
        /// <remarks>Проверка на равенство размеров списков <paramref name="collection1"/> и <paramref name="collection2"/> внутри 
        /// метода не производится, но если они неравны, результат работы метода может оказаться некорректным.</remarks>
        public static void SubtractTo<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            for (int i = 0; i < collection1.Count; i++)
            {
                collection1 [i] -= collection2 [i];
            }
        }

        /// <summary>
        /// Создаёт список, содержащий элементы, противоположные по значению элементам списка <paramref name="collection"/>.
        /// </summary>
        public static List<T> Negate<T> (this List<T> collection) where T : INumber<T>
        {
            List<T> result = new List<T> (collection.Count);

            for (int i = 0; i < collection.Count; i++)
            {
                result.Add (-collection [i]);
            }

            return result;
        }

        /// <summary>
        /// Заменяет элементы списка <paramref name="collection"/> на противоположные по значению.
        /// </summary>
        public static void NegateTo<T> (this List<T> collection) where T : INumber<T>
        {
            for (int i = 0; i < collection.Count; i++)
            {
                collection [i] = -collection [i];
            }
        }

        /// <summary>
        /// Поэлементное умножение списка <paramref name="collection"/> на коэффициент <paramref name="coefficient"/>.
        /// </summary>
        public static List<T> Multiply<T> (this List<T> collection, T coefficient) where T : INumber<T>
        {
            List<T> result = new List<T> (collection.Count);

            for (int i = 0; i < collection.Count; i++)
            {
                result.Add (collection [i] * coefficient);
            }

            return result;
        }

        /// <summary>
        /// Поэлементное умножение списка <paramref name="collection"/> на коэффициент <paramref name="coefficient"/>.
        /// </summary>
        public static void MultiplyTo<T> (this List<T> collection, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < collection.Count; i++)
            {
                collection [i] *= coefficient;
            }
        }

        /// <summary>
        /// Поэлементное деление списка <paramref name="collection"/> на коэффициент <paramref name="coefficient"/>.
        /// </summary>
        public static List<T> Divide<T> (this List<T> collection, T coefficient) where T : INumber<T>
        {
            List<T> result = new List<T> (collection.Count);

            for (int i = 0; i < collection.Count; i++)
            {
                result.Add (collection [i] / coefficient);
            }

            return result;
        }

        /// <summary>
        /// Поэлементное деление списка <paramref name="collection"/> на коэффициент <paramref name="coefficient"/>.
        /// </summary>
        public static void DivideTo<T> (this List<T> collection, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < collection.Count; i++)
            {
                collection [i] /= coefficient;
            }
        }

        /// <summary>
        /// Внутреннее (скалярное) произведение двух списков.
        /// </summary>
        /// <remarks>Проверка на равенство размеров списков <paramref name="collection1"/> и <paramref name="collection2"/> внутри 
        /// метода не производится, но если они неравны, результат работы метода может оказаться некорректным.</remarks>
        public static T InnerProduct<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            T result = T.Zero;

            for (int i = 0; i < collection1.Count; i++)
            {
                result += collection1 [i] * collection2 [i];
            }

            return result;
        }
    }
}