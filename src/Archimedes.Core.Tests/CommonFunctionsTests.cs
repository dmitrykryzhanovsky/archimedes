using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class CommonFunctionsTests
    {
        [TestMethod ()]
        public void SplitAngleTest_Zero ()
        {
            double x = 0;

            (int, int, int, double) expected = (1, 0, 0, 0);

            (int, int, int, double) actual = CommonFunctions.SplitAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitAngleTest_Positive_Deg ()
        {
            double x = 73.0;

            (int, int, int, double) expected = (1, 73, 0, 0);

            (int, int, int, double) actual = CommonFunctions.SplitAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitAngleTest_Positive_DegMin ()
        {
            double x = 73.7;

            (int, int, int, double) expected = (1, 73, 42, 0);

            (int, int, int, double) actual = CommonFunctions.SplitAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitAngleTest_Positive_DegMinSec ()
        {
            double x = 73.71;

            (int, int, int, double) expected = (1, 73, 42, 36);

            (int, int, int, double) actual = CommonFunctions.SplitAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitAngleTest_Positive_DegMinSecFloat ()
        {
            double x = 73.711;

            (int, int, int, double) expected = (1, 73, 42, 39.6);

            (int, int, int, double) actual = CommonFunctions.SplitAngle (x);

            Assert.AreEqual (expected.Item1, actual.Item1);
            Assert.AreEqual (expected.Item2, actual.Item2);
            Assert.AreEqual (expected.Item3, actual.Item3);
            Assert.AreEqual (expected.Item4, actual.Item4, 1.0e-10);
        }

        [TestMethod ()]
        public void SplitAngleTest_Negative_Deg ()
        {
            double x = -73.0;

            (int, int, int, double) expected = (-1, 73, 0, 0);

            (int, int, int, double) actual = CommonFunctions.SplitAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitAngleTest_Negative_DegMin ()
        {
            double x = -73.7;

            (int, int, int, double) expected = (-1, 73, 42, 0);

            (int, int, int, double) actual = CommonFunctions.SplitAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitAngleTest_Negative_DegMinSec ()
        {
            double x = -73.71;

            (int, int, int, double) expected = (-1, 73, 42, 36);

            (int, int, int, double) actual = CommonFunctions.SplitAngle (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitAngleTest_Negative_DegMinSecFloat ()
        {
            double x = -73.711;

            (int, int, int, double) expected = (-1, 73, 42, 39.6);

            (int, int, int, double) actual = CommonFunctions.SplitAngle (x);

            Assert.AreEqual (expected.Item1, actual.Item1);
            Assert.AreEqual (expected.Item2, actual.Item2);
            Assert.AreEqual (expected.Item3, actual.Item3);
            Assert.AreEqual (expected.Item4, actual.Item4, 1.0e-10);
        }
    }
}