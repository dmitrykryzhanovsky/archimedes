using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class SortTests
    {
        [TestMethod ()]
        public void InsertionSortTest_Ascending ()
        {
            int [] actual = new int [] { 21, 41, 59, 26, 41, 58 };

            int [] expected = new int [] { 21, 26, 41, 41, 58, 59 };

            actual.InsertionSort ();

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void InsertionSortTest_Descending ()
        {
            double [] actual = new double [] { 21, 41, 59, 26, 41, 58 };

            double [] expected = new double [] { 59, 58, 41, 41, 26, 21 };

            actual.InsertionSortDesc ();

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void InsertionSortTest_ComparerAscending ()
        {
            ModuloClassComparer comparer = new ModuloClassComparer ();

            ModuloClass [] actual = new ModuloClass [] { new ModuloClass (21, 15),
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
        public void InsertionSortTest_ComparerDescending ()
        {
            ModuloClassComparer comparer = new ModuloClassComparer ();

            ModuloClass [] actual = new ModuloClass [] { new ModuloClass (21, 15),
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

        [TestMethod ()]
        public void SelectionSortTest_Common ()
        {
            int [] actual = new int [] { 21, 41, 59, 26, 41, 58 };

            int [] expected = new int [] { 21, 26, 41, 41, 58, 59 };

            actual.SelectionSort ();

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void SelectionSortTest_LastItemIsSmallest ()
        {
            int [] actual = new int [] { 21, 41, 59, 26, 41, -58 };

            int [] expected = new int [] { -58, 21, 26, 41, 41, 59 };

            actual.SelectionSort ();

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }

        [TestMethod ()]
        public void SelectionSortTest_LastItemIsBiggest ()
        {
            int [] actual = new int [] { 21, 41, 59, 26, 41, 158 };

            int [] expected = new int [] { 21, 26, 41, 41, 59, 158 };

            actual.SelectionSort ();

            Assert.AreEqual (true, expected.Equals<int> (actual));
        }
    }
}