﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class HeapAlgorithmTests
    {
        [TestMethod ()]
        public void MaxHeapifyTest_Array ()
        {
            int [] array     = new int [] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int    firstLeaf = array.Length / 2;
            int    lastLeaf  = array.Length - 1;

            int [] expectedArray = new int [] { 27, 17, 10, 16, 13, 9, 1, 5, 7, 12, 4, 8, 3, 0 };

            array.MaxHeapify (2, firstLeaf, lastLeaf);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void MaxHeapifyTest_List ()
        {
            List<int> list      = new List<int> { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int       firstLeaf = list.Count / 2;
            int       lastLeaf  = list.Count - 1;

            List<int> expectedList = new List<int> { 27, 17, 10, 16, 13, 9, 1, 5, 7, 12, 4, 8, 3, 0 };

            list.MaxHeapify (2, firstLeaf, lastLeaf);

            Assert.AreEqual (true, expectedList.Equals<int> (list));
        }

        [TestMethod ()]
        public void MinHeapifyTest_Array ()
        {
            int [] array     = new int [] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int    firstLeaf = array.Length / 2;
            int    lastLeaf  = array.Length - 1;

            int [] expectedArray = new int [] { 27, 17, 1, 16, 13, 10, 0, 5, 7, 12, 4, 8, 9, 3 };

            array.MinHeapify (2, firstLeaf, lastLeaf);

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void MinHeapifyTest_List ()
        {
            List<int> list      = new List<int> { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };
            int       firstLeaf = list.Count / 2;
            int       lastLeaf  = list.Count - 1;

            List<int> expectedList = new List<int> { 27, 17, 1, 16, 13, 10, 0, 5, 7, 12, 4, 8, 9, 3 };

            list.MinHeapify (2, firstLeaf, lastLeaf);

            Assert.AreEqual (true, expectedList.Equals<int> (list));
        }

        [TestMethod ()]
        public void BuildMaxHeapTest_Array ()
        {
            int [] array = new int [] { 5, 3, 17, 10, 84, 19, 6, 22, 9 };

            int [] expectedArray = new int [] { 84, 22, 19, 10, 3, 17, 6, 5, 9 };

            array.BuildMaxHeap ();

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void BuildMaxHeapTest_List ()
        {
            List<int> list = new List<int> { 5, 3, 17, 10, 84, 19, 6, 22, 9 };

            List<int> expectedList = new List<int> { 84, 22, 19, 10, 3, 17, 6, 5, 9 };

            list.BuildMaxHeap ();

            Assert.AreEqual (true, expectedList.Equals<int> (list));
        }

        [TestMethod ()]
        public void BuildMinHeapTest_Array ()
        {
            int [] array = new int [] { 5, 3, 17, 10, 84, 19, 6, 22, 9 };

            int [] expectedArray = new int [] { 3, 5, 6, 9, 84, 19, 17, 22, 10 };

            array.BuildMinHeap ();

            Assert.AreEqual (true, expectedArray.Equals<int> (array));
        }

        [TestMethod ()]
        public void BuildMinHeapTest_List ()
        {
            List<int> list = new List<int> { 5, 3, 17, 10, 84, 19, 6, 22, 9 };

            List<int> expectedList = new List<int> { 3, 5, 6, 9, 84, 19, 17, 22, 10 };

            list.BuildMinHeap ();

            Assert.AreEqual (true, expectedList.Equals<int> (list));
        }

        [TestMethod ()]
        public void GetFirstLeafIndexTest_Length_1 ()
        {
            int length = 1;

            int actual = 0;

            int expected = HeapAlgorithm.GetFirstLeafIndex (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexTest_Length_2 ()
        {
            int length = 2;

            int actual = 1;

            int expected = HeapAlgorithm.GetFirstLeafIndex (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexTest_Length_3 ()
        {
            int length = 3;

            int actual = 1;

            int expected = HeapAlgorithm.GetFirstLeafIndex (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexTest_Length_Even ()
        {
            int length = 6;

            int actual = 3;

            int expected = HeapAlgorithm.GetFirstLeafIndex (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetFirstLeafIndexTest_Length_Odd ()
        {
            int length = 7;

            int actual = 3;

            int expected = HeapAlgorithm.GetFirstLeafIndex (length);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLeftChildIndexTest ()
        {
            int index = 3;

            int expected = 7;

            int actual = HeapAlgorithm.GetLeftChildIndex (index);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetRightChildIndexTest ()
        {
            int index = 3;

            int expected = 8;

            int actual = HeapAlgorithm.GetRightChildIndex (index);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetParentIndexTest_Odd ()
        {
            int index = 7;

            int expected = 3;

            int actual = HeapAlgorithm.GetParentIndex (index);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetParentIndexTest_Even ()
        {
            int index = 8;

            int expected = 3;

            int actual = HeapAlgorithm.GetParentIndex (index);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HowManyChildrenTest_OddNodes_TwoChildren ()
        {
            int index     = 2;
            int length    = 9;
            int firstLeaf = 5;

            int expected = 2;

            int actual = HeapAlgorithm.HowManyChildren (index, length, firstLeaf);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HowManyChildrenTest_OddNodes_Leaf ()
        {
            int index     = 5;
            int length    = 9;
            int firstLeaf = 5;

            int expected = 0;

            int actual = HeapAlgorithm.HowManyChildren (index, length, firstLeaf);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HowManyChildrenTest_EvenNodes_TwoChildren ()
        {
            int index     = 2;
            int length    = 14;
            int firstLeaf = 7;

            int expected = 2;

            int actual = HeapAlgorithm.HowManyChildren (index, length, firstLeaf);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HowManyChildrenTest_EvenNodes_OneChildren ()
        {
            int index     = 6;
            int length    = 14;
            int firstLeaf = 7;

            int expected = 1;

            int actual = HeapAlgorithm.HowManyChildren (index, length, firstLeaf);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HowManyChildrenTest_EvenNodes_Leaf ()
        {
            int index     = 8;
            int length    = 14;
            int firstLeaf = 7;

            int expected = 0;

            int actual = HeapAlgorithm.HowManyChildren (index, length, firstLeaf);

            Assert.AreEqual (expected, actual);
        }
    }
}//TODO: furstleaf и другие проблемы