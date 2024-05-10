using Archimedes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Core.Tests._1
{
    [TestClass()]
    public class HeapAlgorithmTests
    {
        

        [TestMethod()]
        public void MaxHeapifyTest_List()
        {
            List<int> list = new List<int> { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int firstLeafIndex = 7;
            int lastLeafIndex = 13;

            List<int> expectedList = new List<int> { 27, 17, 10, 16, 13, 9, 1, 5, 7, 12, 4, 8, 3, 0 };

            list.MaxHeapify(2, firstLeafIndex, lastLeafIndex);

            Assert.AreEqual(true, expectedList.Equals<int>(list));
        }

        [TestMethod()]
        public void MaxHeapifyTest_Pair_Array()
        {
            int[] keyArray = new int[] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int[] dataArray = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43 };
            int firstLeafIndex = 7;
            int lastLeafIndex = 13;

            int[] expectedKeyArray = new int[] { 27, 17, 10, 16, 13, 9, 1, 5, 7, 12, 4, 8, 3, 0 };
            int[] expectedDataArray = new int[] { 2, 3, 13, 7, 11, 41, 17, 19, 23, 29, 31, 37, 5, 43 };

            keyArray.MaxHeapify(dataArray, 2, firstLeafIndex, lastLeafIndex);

            Assert.AreEqual(true, expectedKeyArray.Equals<int>(keyArray));
            Assert.AreEqual(true, expectedDataArray.Equals<int>(dataArray));
        }

        [TestMethod()]
        public void MaxHeapifyTest_Pais_List()
        {
            List<int> keyList = new List<int> { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            List<int> dataList = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43 };
            int firstLeafIndex = 7;
            int lastLeafIndex = 13;

            List<int> expectedKeyList = new List<int> { 27, 17, 10, 16, 13, 9, 1, 5, 7, 12, 4, 8, 3, 0 };
            List<int> expectedDataList = new List<int> { 2, 3, 13, 7, 11, 41, 17, 19, 23, 29, 31, 37, 5, 43 };

            keyList.MaxHeapify(dataList, 2, firstLeafIndex, lastLeafIndex);

            Assert.AreEqual(true, expectedKeyList.Equals<int>(keyList));
            Assert.AreEqual(true, expectedDataList.Equals<int>(dataList));
        }

        [TestMethod()]
        public void MinHeapifyTest_Array()
        {
            int[] array = new int[] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int firstLeafIndex = 7;
            int lastLeafIndex = 13;

            int[] expectedArray = new int[] { 27, 17, 1, 16, 13, 10, 0, 5, 7, 12, 4, 8, 9, 3 };

            array.MinHeapify(2, firstLeafIndex, lastLeafIndex);

            Assert.AreEqual(true, expectedArray.Equals<int>(array));
        }

        [TestMethod()]
        public void MinHeapifyTest_List()
        {
            List<int> list = new List<int> { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int firstLeafIndex = 7;
            int lastLeafIndex = 13;

            List<int> expectedList = new List<int> { 27, 17, 1, 16, 13, 10, 0, 5, 7, 12, 4, 8, 9, 3 };

            list.MinHeapify(2, firstLeafIndex, lastLeafIndex);

            Assert.AreEqual(true, expectedList.Equals<int>(list));
        }

        [TestMethod()]
        public void MinHeapifyTest_Pair_Array()
        {
            int[] keyArray = new int[] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int[] dataArray = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43 };
            int firstLeafIndex = 7;
            int lastLeafIndex = 13;

            int[] expectedKeyArray = new int[] { 27, 17, 1, 16, 13, 10, 0, 5, 7, 12, 4, 8, 9, 3 };
            int[] expectedDataArray = new int[] { 2, 3, 17, 7, 11, 13, 43, 19, 23, 29, 31, 37, 41, 5 };

            keyArray.MinHeapify(dataArray, 2, firstLeafIndex, lastLeafIndex);

            Assert.AreEqual(true, expectedKeyArray.Equals<int>(keyArray));
            Assert.AreEqual(true, expectedDataArray.Equals<int>(dataArray));
        }

        [TestMethod()]
        public void MinHeapifyTest_Pair_List()
        {
            List<int> keyList = new List<int> { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            List<int> dataList = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43 };
            int firstLeafIndex = 7;
            int lastLeafIndex = 13;

            List<int> expectedKeyList = new List<int> { 27, 17, 1, 16, 13, 10, 0, 5, 7, 12, 4, 8, 9, 3 };
            List<int> expectedDataList = new List<int> { 2, 3, 17, 7, 11, 13, 43, 19, 23, 29, 31, 37, 41, 5 };

            keyList.MinHeapify(dataList, 2, firstLeafIndex, lastLeafIndex);

            Assert.AreEqual(true, expectedKeyList.Equals<int>(keyList));
            Assert.AreEqual(true, expectedDataList.Equals<int>(dataList));
        }

        

        [TestMethod()]
        public void BuildMaxHeapTest_List()
        {
            List<int> list = new List<int> { 5, 3, 17, 10, 84, 19, 6, 22, 9 };

            List<int> expectedList = new List<int> { 84, 22, 19, 10, 3, 17, 6, 5, 9 };

            list.BuildMaxHeap();

            Assert.AreEqual(true, expectedList.Equals<int>(list));
        }

        [TestMethod()]
        public void BuildMaxHeapTest_Pair_Array()
        {
            int[] keyArray = new int[] { 5, 3, 17, 10, 84, 19, 6, 22, 9 };
            int[] dataArray = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 };

            int[] expectedKeyArray = new int[] { 84, 22, 19, 10, 3, 17, 6, 5, 9 };
            int[] expectedDataArray = new int[] { 11, 19, 13, 7, 3, 5, 17, 2, 23 };

            keyArray.BuildMaxHeap(dataArray);

            Assert.AreEqual(true, expectedKeyArray.Equals<int>(keyArray));
            Assert.AreEqual(true, expectedDataArray.Equals<int>(dataArray));
        }

        [TestMethod()]
        public void BuildMaxHeapTest_Pair_List()
        {
            List<int> keyList = new List<int> { 5, 3, 17, 10, 84, 19, 6, 22, 9 };
            List<int> dataList = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23 };

            List<int> expectedKeyList = new List<int> { 84, 22, 19, 10, 3, 17, 6, 5, 9 };
            List<int> expectedDataList = new List<int> { 11, 19, 13, 7, 3, 5, 17, 2, 23 };

            keyList.BuildMaxHeap(dataList);

            Assert.AreEqual(true, expectedKeyList.Equals<int>(keyList));
            Assert.AreEqual(true, expectedDataList.Equals<int>(dataList));
        }

        [TestMethod()]
        public void BuildMinHeapTest_Array()
        {
            int[] array = new int[] { 5, 3, 17, 10, 84, 19, 6, 22, 9 };

            int[] expectedArray = new int[] { 3, 5, 6, 9, 84, 19, 17, 22, 10 };

            array.BuildMinHeap();

            Assert.AreEqual(true, expectedArray.Equals<int>(array));
        }

        [TestMethod()]
        public void BuildMinHeapTest_List()
        {
            List<int> list = new List<int> { 5, 3, 17, 10, 84, 19, 6, 22, 9 };

            List<int> expectedList = new List<int> { 3, 5, 6, 9, 84, 19, 17, 22, 10 };

            list.BuildMinHeap();

            Assert.AreEqual(true, expectedList.Equals<int>(list));
        }

        [TestMethod()]
        public void BuildMinHeapTest_Pair_Array()
        {
            int[] keyArray = new int[] { 5, 3, 17, 10, 84, 19, 6, 22, 9 };
            int[] dataArray = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 };

            int[] expectedKeyArray = new int[] { 3, 5, 6, 9, 84, 19, 17, 22, 10 };
            int[] expectedDataArray = new int[] { 3, 2, 17, 23, 11, 13, 5, 19, 7 };

            keyArray.BuildMinHeap(dataArray);

            Assert.AreEqual(true, expectedKeyArray.Equals<int>(keyArray));
            Assert.AreEqual(true, expectedDataArray.Equals<int>(dataArray));
        }

        [TestMethod()]
        public void BuildMinHeapTest_Pair_List()
        {
            List<int> keyList = new List<int> { 5, 3, 17, 10, 84, 19, 6, 22, 9 };
            List<int> dataList = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23 };

            List<int> expectedKeyList = new List<int> { 3, 5, 6, 9, 84, 19, 17, 22, 10 };
            List<int> expectedDataList = new List<int> { 3, 2, 17, 23, 11, 13, 5, 19, 7 };

            keyList.BuildMinHeap(dataList);

            Assert.AreEqual(true, expectedKeyList.Equals<int>(keyList));
            Assert.AreEqual(true, expectedDataList.Equals<int>(dataList));
        }

        

        [TestMethod()]
        public void InsertInMaxHeapTest()
        {
            List<int> list = new List<int> { 83, 72, 47, 61, 7, 27, 1 };

            list.InsertInMaxHeap(73);

            Assert.AreEqual(83, list[0]);
            Assert.AreEqual(73, list[1]);
            Assert.AreEqual(47, list[2]);
            Assert.AreEqual(72, list[3]);
            Assert.AreEqual(7, list[4]);
            Assert.AreEqual(27, list[5]);
            Assert.AreEqual(1, list[6]);
            Assert.AreEqual(61, list[7]);
        }

        [TestMethod()]
        public void InsertInMaxHeapTest_Pair()
        {
            List<int> keyList = new List<int> { 83, 72, 47, 61, 7, 27, 1 };
            List<int> dataList = new List<int> { 2, 3, 5, 7, 11, 13, 17 };

            keyList.InsertInMaxHeap(dataList, 73, 19);

            Assert.AreEqual(83, keyList[0]);
            Assert.AreEqual(73, keyList[1]);
            Assert.AreEqual(47, keyList[2]);
            Assert.AreEqual(72, keyList[3]);
            Assert.AreEqual(7, keyList[4]);
            Assert.AreEqual(27, keyList[5]);
            Assert.AreEqual(1, keyList[6]);
            Assert.AreEqual(61, keyList[7]);
        }

        [TestMethod()]
        public void InsertInMinHeapTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertInMinHeapTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteFromMaxHeapTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteFromMaxHeapTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteFromMinHeapTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteFromMinHeapTest1()
        {
            Assert.Fail();
        }
    }
}