using Microsoft.VisualStudio.TestTools.UnitTesting;

using Archimedes;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class VectorTests
    {
        [TestMethod ()]
        public void IndexerGetTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            double expected = 8;

            double actual = v [3];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IndexerSetTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            v [3] = 7;

            double expected = 7;

            double actual = v [3];

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            int expected = 4;

            int actual = v.Dimension;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComponentsTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            double [] expected = new double [] { 2, 3, 5, 8 };

            double [] actual = v.Components;

            Assert.AreEqual (true, expected.Equals<double> (actual));
        }

        [TestMethod ()]
        public void ConstructorTest_Dimension ()
        {
            Vector v = new Vector (5);

            int expected = 5;

            int actual = v.Dimension;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ConstructorTest_Array ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            Assert.AreEqual (4, v.Dimension);
            Assert.AreEqual (2, v [0]);
            Assert.AreEqual (3, v [1]);
            Assert.AreEqual (5, v.Components [2]);
            Assert.AreEqual (8, v.Components [3]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetHashCodeTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void DotProductTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void VectorTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void VectorTest2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void CloneTest1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest3 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetHashCodeTest1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void DotProductTest1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetNorm2Test1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetLengthTest1 ()
        {
            Assert.Fail ();
        }        

        [TestMethod ()]
        public void VectorTest3 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void CloneTest2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest4 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest5 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetHashCodeTest2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void DotProductTest2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetNorm2Test2 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetLengthTest2 ()
        {
            Assert.Fail ();
        }
    }
}