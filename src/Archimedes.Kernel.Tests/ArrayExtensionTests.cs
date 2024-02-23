using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void EqualsTest_NotEqualLength ()
        {
            int [] array1 = new int [] { 2, 3, 5 };
            int [] array2 = new int [] { 2, 3, 5, 7 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualLength_NotEqualItems ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 2, 3, 4, 7 };

            bool expected = false;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualLength_EqualItems ()
        {
            int [] array1 = new int [] { 2, 3, 5, 7 };
            int [] array2 = new int [] { 2, 3, 5, 7 };

            bool expected = true;

            bool actual = array1.Equals<int> (array2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void FindMinIndexTest ()
        {
            int [] array      = new int [] { 14, 27, 60, 10, 10, 37 };
            int    beginIndex = 0;
            int    endIndex   = 2;

            int expected = 0;

            int actual = array.FindMinIndex (beginIndex, endIndex);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_2AA ()
        {
            int [] array  = new int [] { 0, 1, 1, 2, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;

            int expected = 1;

            int actual = array.MaxIndex (index1, index2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_2AB ()
        {
            int [] array  = new int [] { 0, 1, 1, 2, 3, 5 };
            int    index1 = 2;
            int    index2 = 3;

            int expected = 3;

            int actual = array.MaxIndex (index1, index2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_2BA ()
        {
            int [] array  = new int [] { 0, 1, 1, 2, 3, 5 };
            int    index1 = 3;
            int    index2 = 2;

            int expected = 3;

            int actual = array.MaxIndex (index1, index2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3AAA ()
        {
            int [] array  = new int [] { 0, 1, 1, 1, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 1;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3ABB ()
        {
            int [] array  = new int [] { 0, 1, 2, 2, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 2;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3BAA ()
        {
            int [] array  = new int [] { 0, 2, 1, 1, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 1;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3AAB ()
        {
            int [] array  = new int [] { 0, 1, 1, 2, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 3;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3BBA ()
        {
            int [] array  = new int [] { 0, 2, 2, 1, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 1;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3ABA ()
        {
            int [] array  = new int [] { 0, 1, 2, 1, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 2;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3BAB ()
        {
            int [] array  = new int [] { 0, 2, 1, 2, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 1;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3ABC ()
        {
            int [] array  = new int [] { 0, 1, 2, 3, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 3;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3ACB ()
        {
            int [] array  = new int [] { 0, 1, 3, 2, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 2;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3BAC ()
        {
            int [] array  = new int [] { 0, 2, 1, 3, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 3;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3BCA ()
        {
            int [] array  = new int [] { 0, 2, 3, 1, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 2;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3CAB ()
        {
            int [] array  = new int [] { 0, 3, 1, 2, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 1;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3CBA ()
        {
            int [] array  = new int [] { 0, 3, 2, 1, 3, 5 };
            int    index1 = 1;
            int    index2 = 2;
            int    index3 = 3;

            int expected = 1;

            int actual = array.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }
    }
}