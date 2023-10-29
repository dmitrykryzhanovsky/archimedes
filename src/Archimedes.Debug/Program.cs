namespace Archimedes.Debug
{
    internal static class Program
    {
        private static void Main (string [] args)
        {
            Random random = new Random ();

            SortComputing.Sort4Performance (random);

            Console.ReadKey ();
        }
    }
}