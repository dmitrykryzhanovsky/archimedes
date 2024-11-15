﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class VectorTests
    {
        [TestMethod ()]
        public void opMultiplyTest ()
        {
            Vector v1 = new Vector (2, 3, 5, 8);
            Vector v2 = new Vector (3, 4, 6, 9);

            double expected = 120;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            double expected = 102;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Vector v = new Vector (2, 3, 5, 8);

            double expected = 10.0995049383620780;

            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetUnitTest ()
        {
            Vector v = new Vector (double.Sqrt (2.0), 3, 5, 8);

            Vector expected = new Vector (double.Sqrt (2.0) / 10.0, 0.3, 0.5, 0.8);

            Vector actual = v.GetUnit ();

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
            Assert.AreEqual (expected [3], actual [3]);
        }
    }
}