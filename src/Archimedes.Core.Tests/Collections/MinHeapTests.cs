﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MinHeapTests
    {
        [TestMethod ()]
        public void PopMinTest_Binary ()
        {
            BinaryMinHeap<int, int> heap = new BinaryMinHeap<int, int> ((68, 2), (43, 3), (98, 5), (22, 7), (64, 11), (80, 13), 
                (22, 17), (83, 19), (60, 23), (24, 29));

            heap.PopMin ();

            Assert.AreEqual ((22, 17), heap [0]);
            Assert.AreEqual ((24, 29), heap [1]);
            Assert.AreEqual ((68,  2), heap [2]);
            Assert.AreEqual ((43,  3), heap [3]);
            Assert.AreEqual ((64, 11), heap [4]);
            Assert.AreEqual ((80, 13), heap [5]);
            Assert.AreEqual ((98,  5), heap [6]);
            Assert.AreEqual ((83, 19), heap [7]);
            Assert.AreEqual ((60, 23), heap [8]);
        }

        [TestMethod ()]
        public void PopMinTest_Dary ()
        {
            int d = 4;

            DaryMinHeap<int, int> heap = new DaryMinHeap<int, int> (d, (68, 2), (43, 3), (98, 5), (22, 7), (64, 11), (80, 13),
                (22, 17), (83, 19), (60, 23), (24, 29));

            heap.PopMin ();

            Assert.AreEqual ((22,  7), heap [0]);
            Assert.AreEqual ((43,  3), heap [1]);
            Assert.AreEqual ((24, 29), heap [2]);
            Assert.AreEqual ((98,  5), heap [3]);
            Assert.AreEqual ((64, 11), heap [4]);
            Assert.AreEqual ((80, 13), heap [5]);
            Assert.AreEqual ((68,  2), heap [6]);
            Assert.AreEqual ((83, 19), heap [7]);
            Assert.AreEqual ((60, 23), heap [8]);            
        }

        [TestMethod ()]
        public void DecreaseKeyAt_TwoVariables_Binary ()
        {
            List<int> keyList   = new List<int> { 16, 14, 10, 8,  7,  9,  3,  2,  4,  1 };
            List<int> valueList = new List<int> {  2,  3,  5, 7, 11, 13, 17, 19, 23, 29 };

            int newKey    = -15;
            int newValue  =  31;
            int itemIndex =   8;

            BinaryMinHeap<int, int> heap = new BinaryMinHeap<int, int> (keyList, valueList);

            heap.DecreaseKeyAt (newKey, newValue, itemIndex);

            Assert.AreEqual ((-15, 31), heap [0]);
            Assert.AreEqual ((  1, 29), heap [1]);
            Assert.AreEqual ((  3, 17), heap [2]);
            Assert.AreEqual ((  2, 19), heap [3]);
            Assert.AreEqual ((  7, 11), heap [4]);
            Assert.AreEqual ((  9, 13), heap [5]);
            Assert.AreEqual (( 10,  5), heap [6]);
            Assert.AreEqual ((  8,  7), heap [7]);
            Assert.AreEqual ((  4, 23), heap [8]);
            Assert.AreEqual (( 14,  3), heap [9]);
        }

        [TestMethod ()]
        public void DecreaseKeyAt_Tuple_Binary ()
        {
            List<int> keyList   = new List<int> { 16, 14, 10, 8,  7,  9,  3,  2,  4,  1 };
            List<int> valueList = new List<int> {  2,  3,  5, 7, 11, 13, 17, 19, 23, 29 };

            int newKey    = -15;
            int newValue  =  31;
            int itemIndex =   8;

            BinaryMinHeap<int, int> heap = new BinaryMinHeap<int, int> (keyList, valueList);

            heap.DecreaseKeyAt (newKey, newValue, itemIndex);

            Assert.AreEqual ((-15, 31), heap [0]);
            Assert.AreEqual ((  1, 29), heap [1]);
            Assert.AreEqual ((  3, 17), heap [2]);
            Assert.AreEqual ((  2, 19), heap [3]);
            Assert.AreEqual ((  7, 11), heap [4]);
            Assert.AreEqual ((  9, 13), heap [5]);
            Assert.AreEqual (( 10,  5), heap [6]);
            Assert.AreEqual ((  8,  7), heap [7]);
            Assert.AreEqual ((  4, 23), heap [8]);
            Assert.AreEqual (( 14,  3), heap [9]);
        }

        [TestMethod ()]
        public void DecreaseKeyAt_TwoVariables_Dary ()
        {
            List<int> keyList   = new List<int> { 16, 14, 10, 8,  7,  9,  3,  2,  4,  1 };
            List<int> valueList = new List<int> {  2,  3,  5, 7, 11, 13, 17, 19, 23, 29 };

            int d = 4;

            int newKey    = -15;
            int newValue  =  31;
            int itemIndex =   8;

            DaryMinHeap<int, int> heap = new DaryMinHeap<int, int> (d, keyList, valueList);

            heap.DecreaseKeyAt (newKey, newValue, itemIndex);

            Assert.AreEqual ((-15, 31), heap [0]);
            Assert.AreEqual ((  1, 29), heap [1]);
            Assert.AreEqual (( 10,  5), heap [2]);
            Assert.AreEqual ((  8,  7), heap [3]);
            Assert.AreEqual ((  7, 11), heap [4]);
            Assert.AreEqual ((  9, 13), heap [5]);
            Assert.AreEqual ((  3, 17), heap [6]);
            Assert.AreEqual (( 14,  3), heap [7]);
            Assert.AreEqual ((  2, 19), heap [8]);
            Assert.AreEqual (( 16,  2), heap [9]);            
        }

        [TestMethod ()]
        public void DecreaseKeyAt_Tuple_Dary ()
        {
            List<int> keyList   = new List<int> { 16, 14, 10, 8,  7,  9,  3,  2,  4,  1 };
            List<int> valueList = new List<int> {  2,  3,  5, 7, 11, 13, 17, 19, 23, 29 };

            int d = 4;

            int newKey    = -15;
            int newValue  =  31;
            int itemIndex =   8;

            DaryMinHeap<int, int> heap = new DaryMinHeap<int, int> (d, keyList, valueList);

            heap.DecreaseKeyAt (newKey, newValue, itemIndex);

            Assert.AreEqual ((-15, 31), heap [0]);
            Assert.AreEqual ((  1, 29), heap [1]);
            Assert.AreEqual (( 10,  5), heap [2]);
            Assert.AreEqual ((  8,  7), heap [3]);
            Assert.AreEqual ((  7, 11), heap [4]);
            Assert.AreEqual ((  9, 13), heap [5]);
            Assert.AreEqual ((  3, 17), heap [6]);
            Assert.AreEqual (( 14,  3), heap [7]);
            Assert.AreEqual ((  2, 19), heap [8]);
            Assert.AreEqual (( 16,  2), heap [9]);
        }
    }
}