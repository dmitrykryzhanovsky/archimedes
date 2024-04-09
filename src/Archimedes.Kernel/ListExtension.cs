using System.Numerics;

namespace Archimedes
{
    public static class ListExtension
    {
        public static bool Equals<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static List<T> Add<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static List<T> Subtract<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static List<T> Negate<T> (this List<T> collection) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static List<T> Multiply<T> (this List<T> collection, T coefficient) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static List<T> Divide<T> (this List<T> collection, T coefficient) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T InnerProduct<T> (this List<T> collection1, List<T> collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }
    }
}