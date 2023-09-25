namespace Archimedes
{
    public static class VectorAlgorithm
    {
        public static bool AreSuitableForAlgebra (Vector v1, Vector v2)
        {
            return (v1.Dimension == v2.Dimension);
        }
    }
}