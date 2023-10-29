using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.DeprecatedBranch.Tests
{
    [TestClass ()]
    public class SortTests
    {
        [TestMethod ()]
        public void Sort2Test_AB ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 58 };
            int    startIndex = 3;

            array.Sort2 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
        }

        [TestMethod ()]
        public void Sort2Test_BA ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 58 };
            int    startIndex = 2;

            array.Sort2 (startIndex);

            Assert.AreEqual (26, array [2]);
            Assert.AreEqual (59, array [3]);
        }

        [TestMethod ()]
        public void Sort2DescTest_AB ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 58 };
            int    startIndex = 3;

            array.Sort2Desc (startIndex);

            Assert.AreEqual (41, array [3]);
            Assert.AreEqual (26, array [4]);
        }

        [TestMethod ()]
        public void Sort2DescTest_BA ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 58 };
            int    startIndex = 2;

            array.Sort2Desc (startIndex);

            Assert.AreEqual (59, array [2]);
            Assert.AreEqual (26, array [3]);
        }

        [TestMethod ()]
        public void Sort3Test_ABC ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 58 };
            int    startIndex = 3;

            array.Sort3 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
        }

        [TestMethod ()]
        public void Sort3Test_ACB ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 58, 41 };
            int    startIndex = 3;

            array.Sort3 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
        }

        [TestMethod ()]
        public void Sort3Test_BAC ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 26, 58 };
            int    startIndex = 3;

            array.Sort3 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
        }

        [TestMethod ()]
        public void Sort3Test_BCA ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 58, 26 };
            int    startIndex = 3;

            array.Sort3 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
        }

        [TestMethod ()]
        public void Sort3Test_CAB ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 26, 41 };
            int    startIndex = 3;

            array.Sort3 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
        }

        [TestMethod ()]
        public void Sort3Test_CBA ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 41, 26 };
            int    startIndex = 3;

            array.Sort3 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
        }

        [TestMethod ()]
        public void Sort3DescTest_ABC ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 58 };
            int    startIndex = 3;

            array.Sort3Desc (startIndex);

            Assert.AreEqual (58, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (26, array [5]);
        }

        [TestMethod ()]
        public void Sort3DescTest_ACB ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 58, 41 };
            int    startIndex = 3;

            array.Sort3Desc (startIndex);

            Assert.AreEqual (58, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (26, array [5]);
        }

        [TestMethod ()]
        public void Sort3DescTest_BAC ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 26, 58 };
            int    startIndex = 3;

            array.Sort3Desc (startIndex);

            Assert.AreEqual (58, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (26, array [5]);
        }

        [TestMethod ()]
        public void Sort3DescTest_BCA ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 58, 26 };
            int    startIndex = 3;

            array.Sort3Desc (startIndex);

            Assert.AreEqual (58, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (26, array [5]);
        }

        [TestMethod ()]
        public void Sort3DescTest_CAB ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 26, 41 };
            int    startIndex = 3;

            array.Sort3Desc (startIndex);

            Assert.AreEqual (58, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (26, array [5]);
        }

        [TestMethod ()]
        public void Sort3DescTest_CBA ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 41, 26 };
            int    startIndex = 3;

            array.Sort3Desc (startIndex);

            Assert.AreEqual (58, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (26, array [5]);
        }

        [TestMethod ()]
        public void Sort4Test_ABCD ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 58, 73 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_ACBD ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 58, 41, 73 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_BACD ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 26, 58, 73 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_BCAD ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 58, 26, 73 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_CABD ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 26, 41, 73 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_CBAD ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 41, 26, 73 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_ABDC ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 73, 58 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_ACDB ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 58, 73, 41 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_BADC ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 26, 73, 58 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_BCDA ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 58, 73, 26 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_CDAB ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 73, 26, 41 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_CDBA ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 73, 41, 26 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_ADBC ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 73, 41, 58 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_ADCB ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 73, 58, 41 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_BDAC ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 73, 26, 58 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_BDCA ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 73, 58, 26 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_DCAB ()
        {
            int [] array = new int [] { 21, 41, 59, 73, 58, 26, 41 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_DCBA ()
        {
            int [] array = new int [] { 21, 41, 59, 73, 58, 41, 26 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_DABC ()
        {
            int [] array = new int [] { 21, 41, 59, 73, 26, 41, 58 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_DACB ()
        {
            int [] array = new int [] { 21, 41, 59, 73, 26, 58, 41 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_DBAC ()
        {
            int [] array = new int [] { 21, 41, 59, 73, 41, 26, 58 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_DBCA ()
        {
            int [] array = new int [] { 21, 41, 59, 73, 41, 58, 26 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_CADB ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 26, 73, 41 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4Test_CBDA ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 41, 73, 26 };
            int    startIndex = 3;

            array.Sort4 (startIndex);

            Assert.AreEqual (26, array [3]);
            Assert.AreEqual (41, array [4]);
            Assert.AreEqual (58, array [5]);
            Assert.AreEqual (73, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_ABCD ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 58, 73 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_ACBD ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 58, 41, 73 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_BACD ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 26, 58, 73 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_BCAD ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 58, 26, 73 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_CABD ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 26, 41, 73 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_CBAD ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 41, 26, 73 };
            int    startIndex = 3;
             
            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_ABDC ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 41, 73, 58 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_ACDB ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 58, 73, 41 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_BADC ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 26, 73, 58 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_BCDA ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 58, 73, 26 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_CDAB ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 73, 26, 41 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_CDBA ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 73, 41, 26 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_ADBC ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 73, 41, 58 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_ADCB ()
        {
            int [] array = new int [] { 21, 41, 59, 26, 73, 58, 41 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_BDAC ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 73, 26, 58 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_BDCA ()
        {
            int [] array = new int [] { 21, 41, 59, 41, 73, 58, 26 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_DCAB ()
        {
            int [] array = new int [] { 21, 41, 59, 73, 58, 26, 41 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_DCBA ()
        {
            int [] array = new int [] { 21, 41, 59, 73, 58, 41, 26 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_DABC ()
        {
            int [] array = new int [] { 21, 41, 59, 73, 26, 41, 58 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_DACB ()
        {
            int [] array = new int [] { 21, 41, 59, 73, 26, 58, 41 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_DBAC ()
        {
            int [] array = new int [] { 21, 41, 59, 73, 41, 26, 58 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_DBCA ()
        {
            int [] array = new int [] { 21, 41, 59, 73, 41, 58, 26 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_CADB ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 26, 73, 41 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }

        [TestMethod ()]
        public void Sort4DescTest_CBDA ()
        {
            int [] array = new int [] { 21, 41, 59, 58, 41, 73, 26 };
            int    startIndex = 3;

            array.Sort4Desc (startIndex);

            Assert.AreEqual (73, array [3]);
            Assert.AreEqual (58, array [4]);
            Assert.AreEqual (41, array [5]);
            Assert.AreEqual (26, array [6]);
        }
    }
}