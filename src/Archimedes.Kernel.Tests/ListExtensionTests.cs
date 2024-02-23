using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ListExtensionTests
    {
        [TestMethod ()]
        public void EqualsTest_NotEqualLength ()
        {
            List<int> list1 = new List<int> { 2, 3, 5 };
            List<int> list2 = new List<int> { 2, 3, 5, 7 };

            bool expected = false;

            bool actual = list1.Equals<int> (list2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualLength_NotEqualItems ()
        {
            List<int> list1 = new List<int> { 2, 3, 5, 7 };
            List<int> list2 = new List<int> { 2, 3, 4, 7 };

            bool expected = false;

            bool actual = list1.Equals<int> (list2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualLength_EqualItems ()
        {
            List<int> list1 = new List<int> { 2, 3, 5, 7 };
            List<int> list2 = new List<int> { 2, 3, 5, 7 };

            bool expected = true;

            bool actual = list1.Equals<int> (list2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_2AA ()
        {
            List<int> list   = new List<int> { 0, 1, 1, 2, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;

            int expected = 1;

            int actual = list.MaxIndex (index1, index2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_2AB ()
        {
            List<int> list   = new List<int> { 0, 1, 1, 2, 3, 5 };
            int       index1 = 2;
            int       index2 = 3;

            int expected = 3;

            int actual = list.MaxIndex (index1, index2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_2BA ()
        {
            List<int> list   = new List<int> { 0, 1, 1, 2, 3, 5 };
            int       index1 = 3;
            int       index2 = 2;

            int expected = 3;

            int actual = list.MaxIndex (index1, index2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3AAA ()
        {
            List<int> list   = new List<int> { 0, 1, 1, 1, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 1;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3ABB ()
        {
            List<int> list   = new List<int> { 0, 1, 2, 2, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 2;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3BAA ()
        {
            List<int> list   = new List<int> { 0, 2, 1, 1, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 1;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3AAB ()
        {
            List<int> list   = new List<int> { 0, 1, 1, 2, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 3;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3BBA ()
        {
            List<int> list   = new List<int> { 0, 2, 2, 1, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 1;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3ABA ()
        {
            List<int> list   = new List<int> { 0, 1, 2, 1, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 2;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3BAB ()
        {
            List<int> list   = new List<int> { 0, 2, 1, 2, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 1;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3ABC ()
        {
            List<int> list   = new List<int> { 0, 1, 2, 3, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 3;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3ACB ()
        {
            List<int> list   = new List<int> { 0, 1, 3, 2, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 2;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3BAC ()
        {
            List<int> list   = new List<int> { 0, 2, 1, 3, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 3;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3BCA ()
        {
            List<int> list   = new List<int> { 0, 2, 3, 1, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 2;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3CAB ()
        {
            List<int> list   = new List<int> { 0, 3, 1, 2, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 1;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MaxIndexTest_3CBA ()
        {
            List<int> list   = new List<int> { 0, 3, 2, 1, 3, 5 };
            int       index1 = 1;
            int       index2 = 2;
            int       index3 = 3;

            int expected = 1;

            int actual = list.MaxIndex (index1, index2, index3);

            Assert.AreEqual (expected, actual);
        }
    }
}