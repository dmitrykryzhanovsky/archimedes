using Microsoft.VisualStudio.TestTools.UnitTesting;

using Archimedes;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class CommonTests
    {
        [TestMethod ()]
        public void SplitNonNegativeIntoComponentsTest_2Components_Common ()
        {
            double x = 42.73;
            int unit0PerUnit1 = 60;

            (int unit0, double total1) expected = (42, 43.8);

            (int unit0, double total1) actual = Common.SplitNonNegativeIntoComponents (x, unit0PerUnit1);

            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.total1, actual.total1, 1.0e-12);
        }

        [TestMethod ()]
        public void SplitNonNegativeIntoComponentsTest_2Components_DegZero ()
        {
            double x = 0.73;
            int unit0PerUnit1 = 60;

            (int unit0, double total1) expected = (0, 43.8);

            (int unit0, double total1) actual = Common.SplitNonNegativeIntoComponents (x, unit0PerUnit1);

            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.total1, actual.total1);
        }

        [TestMethod ()]
        public void SplitNonNegativeIntoComponentsTest_2Components_DegZero_MinIntZero ()
        {
            double x = 0.01;
            int unit0PerUnit1 = 60;

            (int unit0, double total1) expected = (0, 0.6);

            (int unit0, double total1) actual = Common.SplitNonNegativeIntoComponents (x, unit0PerUnit1);

            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.total1, actual.total1);
        }

        [TestMethod ()]
        public void SplitNonNegativeIntoComponentsTest_2Components_Zero ()
        {
            double x = 0.0;
            int unit0PerUnit1 = 60;

            (int unit0, double total1) expected = (0, 0.0);

            (int unit0, double total1) actual = Common.SplitNonNegativeIntoComponents (x, unit0PerUnit1);

            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.total1, actual.total1);
        }

        [TestMethod ()]
        public void SplitIntoComponentsTest_2Components_Positive ()
        {
            double x = 73.426;
            int unit0PerUnit1 = 60;

            (ESign sign, int unit0, double total1) expected = (ESign.NonNegative, 73, 25.56);

            (ESign sign, int unit0, double total1) actual = Common.SplitIntoComponents (x, unit0PerUnit1);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.total1, actual.total1, 1.0e-12);
        }

        [TestMethod ()]
        public void SplitIntoComponentsTest_2Components_Zero ()
        {
            double x = 0.0;
            int unit0PerUnit1 = 60;

            (ESign sign, int unit0, double total1) expected = (ESign.NonNegative, 0, 0.0);

            (ESign sign, int unit0, double total1) actual = Common.SplitIntoComponents (x, unit0PerUnit1);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.total1, actual.total1);
        }

        [TestMethod ()]
        public void SplitIntoComponentsTest_2Components_Negative ()
        {
            double x = -0.426;
            int unit0PerUnit1 = 60;

            (ESign sign, int unit0, double total1) expected = (ESign.Negative, 0, 25.56);

            (ESign sign, int unit0, double total1) actual = Common.SplitIntoComponents (x, unit0PerUnit1);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.total1, actual.total1);
        }

        [TestMethod ()]
        public void SplitNonNegativeIntoComponentsTest_3Components_Common ()
        {
            double x = 42.35813;
            int unit0PerUnit1 = 60;
            int unit1PerUnit2 = 60;

            (int unit0, int unit1, double total2) expected = (42, 21, 29.268);

            (int unit0, int unit1, double total2) actual = Common.SplitNonNegativeIntoComponents (x, unit0PerUnit1, unit1PerUnit2);

            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.unit1, actual.unit1);
            Assert.AreEqual (expected.total2, actual.total2, 1.0e-11);
        }

        [TestMethod ()]
        public void SplitNonNegativeIntoComponentsTest_3Components_DegZero ()
        {
            double x = 0.35813;
            int unit0PerUnit1 = 60;
            int unit1PerUnit2 = 60;

            (int unit0, int unit1, double total2) expected = (0, 21, 29.268);

            (int unit0, int unit1, double total2) actual = Common.SplitNonNegativeIntoComponents (x, unit0PerUnit1, unit1PerUnit2);

            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.unit1, actual.unit1);
            Assert.AreEqual (expected.total2, actual.total2);
        }

        [TestMethod ()]
        public void SplitNonNegativeIntoComponentsTest_3Components_DegZeroMinZero ()
        {
            double x = 0.00813;
            int unit0PerUnit1 = 60;
            int unit1PerUnit2 = 60;

            (int unit0, int unit1, double total2) expected = (0, 0, 29.268);

            (int unit0, int unit1, double total2) actual = Common.SplitNonNegativeIntoComponents (x, unit0PerUnit1, unit1PerUnit2);

            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.unit1, actual.unit1);
            Assert.AreEqual (expected.total2, actual.total2);
        }

        [TestMethod ()]
        public void SplitNonNegativeIntoComponentsTest_3Components_DegZeroMinZeroSecIntZero ()
        {
            double x = 0.000075;
            int unit0PerUnit1 = 60;
            int unit1PerUnit2 = 60;

            (int unit0, int unit1, double total2) expected = (0, 0, 0.27);

            (int unit0, int unit1, double total2) actual = Common.SplitNonNegativeIntoComponents (x, unit0PerUnit1, unit1PerUnit2);

            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.unit1, actual.unit1);
            Assert.AreEqual (expected.total2, actual.total2, 1.0e-15);
        }

        [TestMethod ()]
        public void SplitNonNegativeIntoComponentsTest_3Components_Zero ()
        {
            double x = 0.0;
            int unit0PerUnit1 = 60;
            int unit1PerUnit2 = 60;

            (int unit0, int unit1, double total2) expected = (0, 0, 0.0);

            (int unit0, int unit1, double total2) actual = Common.SplitNonNegativeIntoComponents (x, unit0PerUnit1, unit1PerUnit2);

            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.unit1, actual.unit1);
            Assert.AreEqual (expected.total2, actual.total2, 1.0e-15);
        }

        [TestMethod ()]
        public void SplitIntoComponentsTest_3Components_Common ()
        {
            double x = 0.426;
            int unit0PerUnit1 = 60;
            int unit1PerUnit2 = 60;

            (ESign sign, int unit0, int unit1, double total2) expected = (ESign.NonNegative, 0, 25, 33.6);

            (ESign sign, int unit0, int unit1, double total2) actual = Common.SplitIntoComponents (x, unit0PerUnit1, unit1PerUnit2);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.unit1, actual.unit1);
            Assert.AreEqual (expected.total2, actual.total2, 1.0e-11);
        }

        [TestMethod ()]
        public void SplitIntoComponentsTest_3Components_Zero ()
        {
            double x = 0.0;
            int unit0PerUnit1 = 60;
            int unit1PerUnit2 = 60;

            (ESign sign, int unit0, int unit1, double total2) expected = (ESign.NonNegative, 0, 0, 0.0);

            (ESign sign, int unit0, int unit1, double total2) actual = Common.SplitIntoComponents (x, unit0PerUnit1, unit1PerUnit2);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.unit1, actual.unit1);
            Assert.AreEqual (expected.total2, actual.total2, 1.0e-11);
        }

        [TestMethod ()]
        public void SplitIntoComponentsTest_3Components_Negative ()
        {
            double x = -0.009;
            int unit0PerUnit1 = 60;
            int unit1PerUnit2 = 60;

            (ESign sign, int unit0, int unit1, double total2) expected = (ESign.Negative, 0, 0, 32.4);

            (ESign sign, int unit0, int unit1, double total2) actual = Common.SplitIntoComponents (x, unit0PerUnit1, unit1PerUnit2);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.unit0, actual.unit0);
            Assert.AreEqual (expected.unit1, actual.unit1);
            Assert.AreEqual (expected.total2, actual.total2, 1.0e-11);
        }
    }
}