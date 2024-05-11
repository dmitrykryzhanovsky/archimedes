using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class DaryHeapAlgorithmTests
    {
        [TestMethod ()]
        public void GetFirstLeafIndexIndexTest_Length_1 ()
        {
            int length = 1;
            int d      = 4;

            int actual = 0;

            int expected = DaryHeapAlgorithm.GetFirstLeafIndex (length, d);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexIndexTest_Length_2 ()
        {
            int length = 2;
            int d      = 4;

            int actual = 1;

            int expected = DaryHeapAlgorithm.GetFirstLeafIndex (length, d);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexIndexTest_Length_3 ()
        {
            int length = 3;
            int d      = 4;

            int actual = 1;

            int expected = DaryHeapAlgorithm.GetFirstLeafIndex (length, d);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexIndexTest_Length_5 ()
        {
            int length = 5;
            int d      = 4;

            int actual = 1;

            int expected = DaryHeapAlgorithm.GetFirstLeafIndex (length, d);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexIndexTest_Length_6 ()
        {
            int length = 6;
            int d      = 4;

            int actual = 2;

            int expected = DaryHeapAlgorithm.GetFirstLeafIndex (length, d);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexIndexTest_Length_FullLevel ()
        {
            int length = 21;
            int d      = 4;

            int actual = 5;

            int expected = DaryHeapAlgorithm.GetFirstLeafIndex (length, d);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexIndexTest_Length_OneItemInLevel ()
        {
            int length = 22;
            int d      = 4;

            int actual = 6;

            int expected = DaryHeapAlgorithm.GetFirstLeafIndex (length, d);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetParentIndexTest ()
        {
            int index = 12;
            int d     = 4;

            int expected = 2;

            int actual = DaryHeapAlgorithm.GetParentIndex (index, d);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetChildIndexTest_0 ()
        {
            int index       = 3;
            int childNumber = 0;
            int d           = 4;

            int expected = 13;

            int actual = DaryHeapAlgorithm.GetChildIndex (index, childNumber, d);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetChildIndexTest_1 ()
        {
            int index       = 3;
            int childNumber = 1;
            int d           = 4;

            int expected = 14;

            int actual = DaryHeapAlgorithm.GetChildIndex (index, childNumber, d);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetChildIndexTest_dminus1 ()
        {
            int index       = 3;
            int childNumber = 3;
            int d           = 4;

            int expected = 16;

            int actual = DaryHeapAlgorithm.GetChildIndex (index, childNumber, d);

            Assert.AreEqual (expected, actual);
        }
    }
}