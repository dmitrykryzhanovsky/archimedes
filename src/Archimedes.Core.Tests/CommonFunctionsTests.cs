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

        [TestMethod ()]
        public void SplitHourBySecTest_Zero ()
        {
            double x = 0;

            (int, int, double) expected = (0, 0, 0);

            (int, int, double) actual = CommonFunctions.SplitHourBySec (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitHourBySecTest_Hour ()
        {
            double x = 13.0;

            (int, int, double) expected = (13, 0, 0);

            (int, int, double) actual = CommonFunctions.SplitHourBySec (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitHourBySecTest_HourMin ()
        {
            double x = 13.7;

            (int, int, double) expected = (13, 42, 0);

            (int, int, double) actual = CommonFunctions.SplitHourBySec (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitHourBySecTest_HourMinSec ()
        {
            double x = 13.71;

            (int, int, double) expected = (13, 42, 36);

            (int, int, double) actual = CommonFunctions.SplitHourBySec (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitHourBySecTest_HourMinSecFloat ()
        {
            double x = 13.711;

            (int, int, double) expected = (13, 42, 39.6);

            (int, int, double) actual = CommonFunctions.SplitHourBySec (x);

            Assert.AreEqual (expected.Item1, actual.Item1);
            Assert.AreEqual (expected.Item2, actual.Item2);
            Assert.AreEqual (expected.Item3, actual.Item3, 1.0e-10);
        }

        [TestMethod ()]
        public void SplitHourByMillisecTest_Zero ()
        {
            double x = 0;

            (int, int, int, double) expected = (0, 0, 0, 0);

            (int, int, int, double) actual = CommonFunctions.SplitHourByMillisec (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitHourByMillisecTest_Hour ()
        {
            double x = 13.0;

            (int, int, int, int) expected = (13, 0, 0, 0);

            (int, int, int, int) actual = CommonFunctions.SplitHourByMillisec (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitHourByMillisecTest_HourMin ()
        {
            double x = 13.7;

            (int, int, int, int) expected = (13, 42, 0, 0);

            (int, int, int, int) actual = CommonFunctions.SplitHourByMillisec (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitHourByMillisecTest_HourMinSec ()
        {
            double x = 13.71;

            (int, int, int, int) expected = (13, 42, 36, 0);

            (int, int, int, int) actual = CommonFunctions.SplitHourByMillisec (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SplitHourByMillisecTest_HourMinSecMillisec ()
        {
            double x = 13.711;

            (int, int, int, int) expected = (13, 42, 39, 600);

            (int, int, int, int) actual = CommonFunctions.SplitHourByMillisec (x);

            Assert.AreEqual (expected.Item1, actual.Item1);
            Assert.AreEqual (expected.Item2, actual.Item2);
            Assert.AreEqual (expected.Item3, actual.Item3, 1.0e-10);
        }

        [TestMethod ()]
        public void ComposeAngleTest_Zero ()
        {
            double expected = 0;

            double actual = CommonFunctions.ComposeAngle (1, 0, 0, 0);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeAngleTest_Positive_Deg ()
        {
            double expected = 73.0;

            double actual = CommonFunctions.ComposeAngle (1, 73, 0, 0);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeAngleTest_Positive_DegMin ()
        {
            double expected = 73.7;

            double actual = CommonFunctions.ComposeAngle (1, 73, 42, 0);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeAngleTest_Positive_DegMinSec ()
        {
            double expected = 73.71;

            double actual = CommonFunctions.ComposeAngle (1, 73, 42, 36);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeAngleTest_Positive_DegMinSecFloat ()
        {
            double expected = 73.711;

            double actual = CommonFunctions.ComposeAngle (1, 73, 42, 39.6);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeAngleTest_Negative_Deg ()
        {
            double expected = -73.0;

            double actual = CommonFunctions.ComposeAngle (-1, 73, 0, 0);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeAngleTest_Negative_DegMin ()
        {
            double expected = -73.7;

            double actual = CommonFunctions.ComposeAngle (-1, 73, 42, 0);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeAngleTest_Negative_DegMinSec ()
        {
            double expected = -73.71;

            double actual = CommonFunctions.ComposeAngle (-1, 73, 42, 36);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeAngleTest_Negative_DegMinSecFloat ()
        {
            double expected = -73.711;

            double actual = CommonFunctions.ComposeAngle (-1, 73, 42, 39.6);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeHourTest_HMS_Zero ()
        {
            double expected = 0;

            double actual = CommonFunctions.ComposeHour (0, 0, 0);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeHourTest_HMS_Hour ()
        {
            double expected = 13.0;

            double actual = CommonFunctions.ComposeHour (13, 0, 0);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeHourTest_HMS_HourMin ()
        {
            double expected = 13.7;

            double actual = CommonFunctions.ComposeHour (13, 42, 0);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeHourTest_HMS_HourMinSec ()
        {
            double expected = 13.71;

            double actual = CommonFunctions.ComposeHour (13, 42, 36);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeHourTest_HMS_HourMinSecFloat ()
        {
            double expected = 13.711;

            double actual = CommonFunctions.ComposeHour (13, 42, 39.6);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeHourTest_HMSM_Zero ()
        {
            double expected = 0;

            double actual = CommonFunctions.ComposeHour (0, 0, 0, 0);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeHourTest_HMSM_Hour ()
        {
            double expected = 13.0;

            double actual = CommonFunctions.ComposeHour (13, 0, 0, 0);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeHourTest_HMSM_HourMin ()
        {
            double expected = 13.7;

            double actual = CommonFunctions.ComposeHour (13, 42, 0, 0);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeHourTest_HMSM_HourMinSec ()
        {
            double expected = 13.71;

            double actual = CommonFunctions.ComposeHour (13, 42, 36, 0);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void ComposeHourTest_HMSM_HourMinSecMillisec ()
        {
            double expected = 13.711;

            double actual = CommonFunctions.ComposeHour (13, 42, 39, 600);

            Assert.AreEqual (expected, actual);
        }
    }
}