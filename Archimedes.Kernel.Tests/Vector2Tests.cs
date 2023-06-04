using Microsoft.VisualStudio.TestTools.UnitTesting;

using Archimedes;
using System.Security.Cryptography.X509Certificates;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector2Tests
    {
        [TestMethod ()]
        public void IndexerTest ()
        {
            Vector2 v = new Vector2 (3, 5);

            Assert.AreEqual (3, v [0]);
            Assert.AreEqual (5, v [1]);

            v [0] = 7;
            v [1] = 11;

            Assert.AreEqual (7, v.X);
            Assert.AreEqual (11, v.Y);

            v.X = 13;
            v.Y = 19;

            Assert.AreEqual (13, v [0]);
            Assert.AreEqual (19, v [1]);
        }

        [TestMethod ()]
        public void Vector2ArrayTest ()
        {
            double [] x = new double [] { 3, 5 };
            Vector2 v = new Vector2 (x);

            Assert.AreEqual (v.X, 3);
            Assert.AreEqual (v.Y, 5);
        }

        [TestMethod ()]
        public void Vector2CopyTest ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            Vector2 v2 = new Vector2 (v1);

            bool expected = true;
            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            object v2 = v1.Clone ();

            bool expected = true;
            bool actual = v1.Equals (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_EqualsTest_True ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            Vector2 v2 = new Vector2 (3, 5);

            bool expected = true;
            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_EqualsTest_False_SameComponent ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            Vector2 v2 = new Vector2 (3, 8);

            bool expected = false;
            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_EqualsTest_False_DifferentComponents ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            Vector2 v2 = new Vector2 (5, 8);

            bool expected = false;
            bool actual = (v1 == v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_NotEqualsTest_True_DifferentComponents ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            Vector2 v2 = new Vector2 (5, 8);

            bool expected = true;
            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_NotEqualsTest_True_SameComponent ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            Vector2 v2 = new Vector2 (3, 8);

            bool expected = true;
            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_NotEqualsTest_False ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            Vector2 v2 = new Vector2 (3, 5);

            bool expected = false;
            bool actual = (v1 != v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_AddTest ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            Vector2 v2 = new Vector2 (5, 8);

            Vector2 expected = new Vector2 (8, 13);
            Vector2 actual = v1 + v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_SubtractTest ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            Vector2 v2 = new Vector2 (5, 8);

            Vector2 expected = new Vector2 (-2, -3);
            Vector2 actual = v1 - v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_NegateTest ()
        {
            Vector2 v = new Vector2 (3, 5);

            Vector2 expected = new Vector2 (-3, -5);
            Vector2 actual = -v;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_MultiplyByCoefficientTest1 ()
        {
            Vector2 v = new Vector2 (3, 5);
            double coefficient = 4;

            Vector2 expected = new Vector2 (12, 20);
            Vector2 actual = v * coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_MultiplyByCoefficientTest2 ()
        {
            Vector2 v = new Vector2 (3, 5);
            double coefficient = 4;

            Vector2 expected = new Vector2 (12, 20);
            Vector2 actual = coefficient * v;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_DivideByCoefficientTest ()
        {
            Vector2 v = new Vector2 (3, 5);
            double coefficient = 4;

            Vector2 expected = new Vector2 (0.75, 1.25);
            Vector2 actual = v / coefficient;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void op_DotProductTest ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            Vector2 v2 = new Vector2 (5, 8);

            double expected = 55;
            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void DotProductTest ()
        {
            Vector2 v1 = new Vector2 (3, 5);
            Vector2 v2 = new Vector2 (5, 8);

            double expected = 55;
            double actual = v1.DotProduct (v2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector2 v = new Vector2 (3, 4);

            double expected = 25;
            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetLengthTest ()
        {
            Vector2 v = new Vector2 (3, 4);

            double expected = 5;
            double actual = v.GetLength ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetAngleTest ()
        {
            Vector2 v = new Vector2 (-2, -1);

            double expected = -2.6779450445889871;
            double actual = v.GetAngle ();

            Assert.AreEqual (expected, actual);
        }
    }
}