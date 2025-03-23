﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector3Tests
    {
        [TestMethod ()]
        public void XTest_Get ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            Assert.AreEqual (3, v.X);
        }

        [TestMethod ()]
        public void XTest_Set ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            v.X = 5;

            Assert.AreEqual (5, v [0]);
            Assert.AreEqual (5, v.X);
        }

        [TestMethod ()]
        public void YTest_Get ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            Assert.AreEqual (4, v.Y);
        }

        [TestMethod ()]
        public void YTest_Set ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            v.Y = 5;

            Assert.AreEqual (5, v [1]);
            Assert.AreEqual (5, v.Y);
        }

        [TestMethod ()]
        public void ZTest_Get ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            Assert.AreEqual (7, v.Z);
        }

        [TestMethod ()]
        public void ZTest_Set ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            v.Z = 8;

            Assert.AreEqual (8, v [2]);
            Assert.AreEqual (8, v.Z);
        }

        [TestMethod ()]
        public void DimensionTest ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            int expected = 3;

            int actual = v.Dimension;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Vector3Test_Array ()
        {
            Vector3 v = new Vector3 (3, 4, 7);

            Assert.AreEqual (3, v.Dimension);
            Assert.AreEqual (3, v [0]);
            Assert.AreEqual (4, v [1]);
            Assert.AreEqual (7, v [2]);
        }

        [TestMethod ()]
        public void Vector3Test_Vector3 ()
        {
            Vector3 v1 = new Vector3 (3, 4, 7);
            Vector3 v2 = new Vector3 (v1);

            Assert.AreEqual (3, v2.Dimension);
            Assert.AreEqual (3, v2.X);
            Assert.AreEqual (4, v2.Y);
            Assert.AreEqual (7, v2.Z);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector3 v1 = new Vector3 (3, 4, 7);
            Vector3 v2 = (Vector3)v1.Clone ();

            Assert.AreEqual (3, v2.Dimension);
            Assert.AreEqual (3, v2.X);
            Assert.AreEqual (4, v2.Y);
            Assert.AreEqual (7, v2.Z);
        }
    }
}