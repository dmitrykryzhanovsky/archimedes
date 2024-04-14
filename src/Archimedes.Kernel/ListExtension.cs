using System.Numerics;

namespace Archimedes
{
    public static class ListExtension
    {
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

        public static List<T> Add<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            List<T> result = new List<T> (collection1.Count);

            for (int i = 0; i < collection1.Count; i++)
            {
                result.Add (collection1 [i] + collection2 [i]);
            }

            return result;
        }

        public static void AddTo<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            for (int i = 0; i < collection1.Count; i++)
            {
                collection1 [i] += collection2 [i];
            }
        }

        public static List<T> Subtract<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            List<T> result = new List<T> (collection1.Count);

            for (int i = 0; i < collection1.Count; i++)
            {
                result.Add (collection1 [i] - collection2 [i]);
            }

            return result;
        }

        public static void SubtractTo<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            for (int i = 0; i < collection1.Count; i++)
            {
                collection1 [i] -= collection2 [i];
            }
        }

        public static List<T> Negate<T> (this List<T> collection) where T : INumber<T>
        {
            List<T> result = new List<T> (collection.Count);

            for (int i = 0; i < collection.Count; i++)
            {
                result.Add (-collection [i]);
            }

            return result;
        }

        public static void NegateTo<T> (this List<T> collection) where T : INumber<T>
        {
            for (int i = 0; i < collection.Count; i++)
            {
                collection [i] = -collection [i];
            }
        }

        public static List<T> Multiply<T> (this List<T> collection, T coefficient) where T : INumber<T>
        {
            List<T> result = new List<T> (collection.Count);

            for (int i = 0; i < collection.Count; i++)
            {
                result.Add (collection [i] * coefficient);
            }

            return result;
        }

        public static void MultiplyTo<T> (this List<T> collection, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < collection.Count; i++)
            {
                collection [i] *= coefficient;
            }
        }

        public static List<T> Divide<T> (this List<T> collection, T coefficient) where T : INumber<T>
        {
            List<T> result = new List<T> (collection.Count);

            for (int i = 0; i < collection.Count; i++)
            {
                result.Add (collection [i] / coefficient);
            }

            return result;
        }

        public static void DivideTo<T> (this List<T> collection, T coefficient) where T : INumber<T>
        {
            for (int i = 0; i < collection.Count; i++)
            {
                collection [i] /= coefficient;
            }
        }

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