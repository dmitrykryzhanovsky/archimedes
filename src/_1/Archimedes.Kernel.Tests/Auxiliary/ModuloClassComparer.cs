namespace Archimedes.Tests
{
    /// <summary>
    /// Компаратор для ModuloClass.
    /// </summary>
    internal class ModuloClassComparer : IComparer<ModuloClass>
    {
        public int Compare (ModuloClass? x, ModuloClass? y)
        {
            if (x.Value > y.Value) return 1;
            else if (x.Value < y.Value) return -1;
            else return 0;
        }
    }
}