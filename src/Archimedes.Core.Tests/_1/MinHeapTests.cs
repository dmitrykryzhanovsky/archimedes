﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Core.Tests._1
{
    [TestClass()]
    public class MinHeapTests
    {
        [TestMethod()]
        public void MinHeapTest_FromList()
        {
            List<int> list = new List<int> { 68, 43, 98, 22, 64, 80, 22, 83, 60, 24 };

            MinHeap<int> heap = new MinHeap<int>(list);

            Assert.AreEqual(22, heap[0]);
            Assert.AreEqual(24, heap[1]);
            Assert.AreEqual(22, heap[2]);
            Assert.AreEqual(43, heap[3]);
            Assert.AreEqual(64, heap[4]);
            Assert.AreEqual(80, heap[5]);
            Assert.AreEqual(98, heap[6]);
            Assert.AreEqual(83, heap[7]);
            Assert.AreEqual(60, heap[8]);
            Assert.AreEqual(68, heap[9]);
        }

        [TestMethod()]
        public void MinHeapTest_FromArray()
        {
            int[] values = new int[] { 68, 43, 98, 22, 64, 80, 22, 83, 60, 24 };

            MinHeap<int> heap = new MinHeap<int>(values);

            Assert.AreEqual(22, heap[0]);
            Assert.AreEqual(24, heap[1]);
            Assert.AreEqual(22, heap[2]);
            Assert.AreEqual(43, heap[3]);
            Assert.AreEqual(64, heap[4]);
            Assert.AreEqual(80, heap[5]);
            Assert.AreEqual(98, heap[6]);
            Assert.AreEqual(83, heap[7]);
            Assert.AreEqual(60, heap[8]);
            Assert.AreEqual(68, heap[9]);
        }
    }
}