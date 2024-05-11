﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MaxHeapTests
    {
        [TestMethod ()]
        public void MaxHeapTest_TwoLists ()
        {
            List<int> keyList   = new List<int> { 68, 43, 98, 22, 64, 80, 22, 83, 60, 24 };
            List<int> valueList = new List<int> {  2,  3,  5,  7, 11, 13, 17, 19, 23, 29 };

            MaxHeap<int, int> heap = new MaxHeap<int, int> (keyList, valueList);

            Assert.AreEqual ((98,  5), heap [0]);
            Assert.AreEqual ((83, 19), heap [1]);
            Assert.AreEqual ((80, 13), heap [2]);
            Assert.AreEqual ((60, 23), heap [3]);
            Assert.AreEqual ((64, 11), heap [4]);
            Assert.AreEqual ((68,  2), heap [5]);
            Assert.AreEqual ((22, 17), heap [6]);
            Assert.AreEqual ((22,  7), heap [7]);
            Assert.AreEqual ((43,  3), heap [8]);
            Assert.AreEqual ((24, 29), heap [9]);
        }

        [TestMethod ()]
        public void MaxHeapTest_TupleArray ()
        {
            MaxHeap<int, int> heap = new MaxHeap<int, int> ((68, 2), (43, 3), (98, 5), (22, 7), (64, 11), (80, 13), (22, 17), (83, 19),
                (60, 23), (24, 29));

            Assert.AreEqual ((98,  5), heap [0]);
            Assert.AreEqual ((83, 19), heap [1]);
            Assert.AreEqual ((80, 13), heap [2]);
            Assert.AreEqual ((60, 23), heap [3]);
            Assert.AreEqual ((64, 11), heap [4]);
            Assert.AreEqual ((68,  2), heap [5]);
            Assert.AreEqual ((22, 17), heap [6]);
            Assert.AreEqual ((22,  7), heap [7]);
            Assert.AreEqual ((43,  3), heap [8]);
            Assert.AreEqual ((24, 29), heap [9]);
        }

        [TestMethod ()]
        public void PopMaxTest ()
        {
            MaxHeap<int, int> heap = new MaxHeap<int, int> ((68, 2), (43, 3), (98, 5), (22, 7), (64, 11), (80, 13), (22, 17), (83, 19),
                (60, 23), (24, 29));

            heap.PopMax ();

            Assert.AreEqual ((83, 19), heap [0]);
            Assert.AreEqual ((64, 11), heap [1]);
            Assert.AreEqual ((80, 13), heap [2]);
            Assert.AreEqual ((60, 23), heap [3]);
            Assert.AreEqual ((24, 29), heap [4]);
            Assert.AreEqual ((68,  2), heap [5]);
            Assert.AreEqual ((22, 17), heap [6]);
            Assert.AreEqual ((22,  7), heap [7]);
            Assert.AreEqual ((43,  3), heap [8]);
        }

        [TestMethod ()]
        public void IncreaseKeyAt_TwoVariables ()
        {
            List<int> keyList   = new List<int> { 16, 14, 10, 8,  7,  9,  3,  2,  4,  1 };
            List<int> valueList = new List<int> {  2,  3,  5, 7, 11, 13, 17, 19, 23, 29 };

            int newKey    = 15;
            int newValue  = 31;
            int itemIndex =  8;

            MaxHeap<int, int> heap = new MaxHeap<int, int> (keyList, valueList);

            heap.IncreaseKeyAt (newKey, newValue, itemIndex);

            Assert.AreEqual ((16,  2), heap [0]);
            Assert.AreEqual ((15, 31), heap [1]);
            Assert.AreEqual ((10,  5), heap [2]);
            Assert.AreEqual ((14,  3), heap [3]);
            Assert.AreEqual (( 7, 11), heap [4]);
            Assert.AreEqual (( 9, 13), heap [5]);
            Assert.AreEqual (( 3, 17), heap [6]);
            Assert.AreEqual (( 2, 19), heap [7]);
            Assert.AreEqual (( 8,  7), heap [8]);
            Assert.AreEqual (( 1, 29), heap [9]);
        }

        [TestMethod ()]
        public void IncreaseKeyAt_Tuple ()
        {
            List<int> keyList   = new List<int> { 16, 14, 10, 8,  7,  9,  3,  2,  4,  1 };
            List<int> valueList = new List<int> {  2,  3,  5, 7, 11, 13, 17, 19, 23, 29 };

            int newKey    = 15;
            int newValue  = 31;
            int itemIndex =  8;

            MaxHeap<int, int> heap = new MaxHeap<int, int> (keyList, valueList);

            heap.IncreaseKeyAt ((newKey, newValue), itemIndex);

            Assert.AreEqual ((16,  2), heap [0]);
            Assert.AreEqual ((15, 31), heap [1]);
            Assert.AreEqual ((10,  5), heap [2]);
            Assert.AreEqual ((14,  3), heap [3]);
            Assert.AreEqual (( 7, 11), heap [4]);
            Assert.AreEqual (( 9, 13), heap [5]);
            Assert.AreEqual (( 3, 17), heap [6]);
            Assert.AreEqual (( 2, 19), heap [7]);
            Assert.AreEqual (( 8,  7), heap [8]);
            Assert.AreEqual (( 1, 29), heap [9]);
        }
    }
}