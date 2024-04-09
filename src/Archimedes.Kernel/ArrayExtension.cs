using System.Numerics;

namespace Archimedes
{
    public static class ArrayExtension
    {
        public static bool Equals<T> (this T [] collection1, T [] collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [] Add<T> (this T [] collection1, T [] collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [] Subtract<T> (this T [] collection1, T [] collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [] Negate<T> (this T [] collection) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [] Multiply<T> (this T [] collection, T coefficient) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T [] Divide<T> (this T [] collection, T coefficient) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }

        public static T InnerProduct<T> (this T [] collection1, T [] collection2) where T : INumber<T>
        {
            throw new NotImplementedException ();
        }
    }
}