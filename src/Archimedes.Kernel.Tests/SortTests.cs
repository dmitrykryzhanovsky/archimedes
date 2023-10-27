using Archimedes;
using Archimedes.Kernel.Tests;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class SortTests
    {
        [TestMethod ()]
        public void Sort2Test_AB ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 58 };
            int    start = 3;

            array.Sort2 (start);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
        }

        [TestMethod ()]
        public void Sort2Test_BA ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 58 };
            int    start = 2;

            array.Sort2 (start);

            Assert.AreEqual (26, array [2]);
            Assert.AreEqual (59, array [3]);
        }

        [TestMethod ()]
        public void InsertionSortTest ()
        {
            int [] actual   = new int [] { 21, 41, 59, 26, 41, 58 };

            int [] expected = new int [] { 21, 26, 41, 41, 58, 59 };

            actual.InsertionSort ();

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void InsertionSortTestDesc ()
        {
            double [] actual   = new double [] { 21, 41, 59, 26, 41, 58 };

            double [] expected = new double [] { 59, 58, 41, 41, 26, 21 };

            actual.InsertionSortDesc ();

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void InsertionSortTest_Comparer ()
        {
            ModuloClassComparer comparer = new ModuloClassComparer ();

            ModuloClass [] actual   = new ModuloClass [] { new ModuloClass (21, 15),
                                                           new ModuloClass (41, 15),
                                                           new ModuloClass (59, 15),
                                                           new ModuloClass (26, 15),
                                                           new ModuloClass (41, 15),
                                                           new ModuloClass (58, 15) };

            ModuloClass [] expected = new ModuloClass [] { new ModuloClass (21, 15),
                                                           new ModuloClass (41, 15),
                                                           new ModuloClass (26, 15),
                                                           new ModuloClass (41, 15),
                                                           new ModuloClass (58, 15),
                                                           new ModuloClass (59, 15) };

            actual.InsertionSort (comparer);

            Assert.AreEqual (true, expected.Equals<ModuloClass> (actual));
        }

        [TestMethod ()]
        public void InsertionSortDescTest_Comparer ()
        {
            ModuloClassComparer comparer = new ModuloClassComparer ();

            ModuloClass [] actual   = new ModuloClass [] { new ModuloClass (21, 15),
                                                           new ModuloClass (41, 15),
                                                           new ModuloClass (59, 15),
                                                           new ModuloClass (26, 15),
                                                           new ModuloClass (41, 15),
                                                           new ModuloClass (58, 15) };

            ModuloClass [] expected = new ModuloClass [] { new ModuloClass (59, 15),
                                                           new ModuloClass (58, 15),
                                                           new ModuloClass (41, 15),
                                                           new ModuloClass (26, 15),
                                                           new ModuloClass (41, 15),
                                                           new ModuloClass (21, 15) };

            actual.InsertionSortDesc (comparer);

            Assert.AreEqual (true, expected.Equals<ModuloClass> (actual));
        }        
    }
}