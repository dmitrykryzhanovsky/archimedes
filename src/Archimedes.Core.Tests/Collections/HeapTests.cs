using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class HeapTests
    {
        [TestMethod ()]
        public void IndexerTest_Get ()
        {
            List<int> keyList   = new List<int> { 60, 37, 27, 20, 14, 10 };
            List<int> valueList = new List<int> {  2,  3,  5,  7, 11, 13 };

            BinaryMinHeap<int, int> heap = new BinaryMinHeap<int, int> (keyList, valueList);

            Assert.AreEqual ((37, 3), heap [4]);
        }

        [TestMethod ()]
        public void InsertTest_TwoVariables_BinaryMaxHeap ()
        {
            List<int> keyList   = new List<int> { 72, 7, 27, 61, 83, 47,  1 };
            List<int> valueList = new List<int> {  2, 3,  5,  7, 11, 13, 17 };

            BinaryMaxHeap<int, int> heap = new BinaryMaxHeap<int, int> (keyList, valueList);

            heap.Insert (36, 19);

            Assert.AreEqual ((83, 11), heap [0]);
            Assert.AreEqual ((72,  2), heap [1]);
            Assert.AreEqual ((47, 13), heap [2]);
            Assert.AreEqual ((61,  7), heap [3]);
            Assert.AreEqual (( 7,  3), heap [4]);
            Assert.AreEqual ((27,  5), heap [5]);
            Assert.AreEqual (( 1, 17), heap [6]);
            Assert.AreEqual ((36, 19), heap [7]);
        }

        [TestMethod ()]
        public void InsertTest_Tuple_BinaryMaxHeap ()
        {
            List<int> keyList   = new List<int> { 72, 7, 27, 61, 83, 47,  1 };
            List<int> valueList = new List<int> {  2, 3,  5,  7, 11, 13, 17 };

            BinaryMaxHeap<int, int> heap = new BinaryMaxHeap<int, int> (keyList, valueList);

            heap.Insert ((36, 19));

            Assert.AreEqual ((83, 11), heap [0]);
            Assert.AreEqual ((72,  2), heap [1]);
            Assert.AreEqual ((47, 13), heap [2]);
            Assert.AreEqual ((61,  7), heap [3]);
            Assert.AreEqual (( 7,  3), heap [4]);
            Assert.AreEqual ((27,  5), heap [5]);
            Assert.AreEqual (( 1, 17), heap [6]);
            Assert.AreEqual ((36, 19), heap [7]);
        }

        [TestMethod ()]
        public void InsertTest_TwoVariables_BinaryMinHeap ()
        {
            List<int> keyList   = new List<int> { 72, 7, 27, 61, 83, 47,  1 };
            List<int> valueList = new List<int> {  2, 3,  5,  7, 11, 13, 17 };

            BinaryMinHeap<int, int> heap = new BinaryMinHeap<int, int> (keyList, valueList);

            heap.Insert (36, 19);

            Assert.AreEqual ( (1, 17), heap [0]);
            Assert.AreEqual (( 7,  3), heap [1]);
            Assert.AreEqual ((27,  5), heap [2]);
            Assert.AreEqual ((36, 19), heap [3]);
            Assert.AreEqual ((83, 11), heap [4]);
            Assert.AreEqual ((47, 13), heap [5]);
            Assert.AreEqual ((72,  2), heap [6]);
            Assert.AreEqual ((61,  7), heap [7]);
        }

        [TestMethod ()]
        public void InsertTest_Tuple_BinaryMinHeap ()
        {
            List<int> keyList   = new List<int> { 72, 7, 27, 61, 83, 47,  1 };
            List<int> valueList = new List<int> {  2, 3,  5,  7, 11, 13, 17 };

            BinaryMinHeap<int, int> heap = new BinaryMinHeap<int, int> (keyList, valueList);

            heap.Insert ((36, 19));

            Assert.AreEqual (( 1, 17), heap [0]);
            Assert.AreEqual (( 7,  3), heap [1]);
            Assert.AreEqual ((27,  5), heap [2]);
            Assert.AreEqual ((36, 19), heap [3]);
            Assert.AreEqual ((83, 11), heap [4]);
            Assert.AreEqual ((47, 13), heap [5]);
            Assert.AreEqual ((72,  2), heap [6]);
            Assert.AreEqual ((61,  7), heap [7]);
        }

        [TestMethod ()]
        public void RemoveAtTest_BinaryMaxHeap ()
        {
            List<int> keyList   = new List<int> { 15, 7, 9, 1,  2,  3,  8 };
            List<int> valueList = new List<int> {  2, 3, 5, 7, 11, 13, 17 };

            BinaryMaxHeap<int, int> heap = new BinaryMaxHeap<int, int> (keyList, valueList);

            heap.RemoveAt (4);

            Assert.AreEqual ((15,  2), heap [0]);
            Assert.AreEqual (( 8, 17), heap [1]);
            Assert.AreEqual (( 9,  5), heap [2]);
            Assert.AreEqual (( 1,  7), heap [3]);
            Assert.AreEqual (( 7,  3), heap [4]);
            Assert.AreEqual (( 3, 13), heap [5]);
        }

        [TestMethod ()]
        public void RemoveAtTest_BinaryMinHeap ()
        {
            List<int> keyList   = new List<int> { 15, 7, 9, 1,  2,  3,  8 };
            List<int> valueList = new List<int> {  2, 3, 5, 7, 11, 13, 17 };

            BinaryMinHeap<int, int> heap = new BinaryMinHeap<int, int> (keyList, valueList);

            heap.RemoveAt (4);

            Assert.AreEqual ((1,  7), heap [0]);
            Assert.AreEqual ((2, 11), heap [1]);
            Assert.AreEqual ((3, 13), heap [2]);
            Assert.AreEqual ((7,  3), heap [3]);
            Assert.AreEqual ((8, 17), heap [4]);
            Assert.AreEqual ((9,  5), heap [5]);
        }
    }
}