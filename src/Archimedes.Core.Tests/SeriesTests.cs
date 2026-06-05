using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class SeriesTests
    {
        [TestMethod ()]
        public void SeriesXY02Test ()
        {
            double    x =  3;
            double    y = -5;
            double [] a =  new double [] { 2, 3, 5, 7, 11, 13 };

            double expected = 181;

            double actual = Series.SeriesXY02 (x, y, a);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SeriesXY13Test ()
        {
            double    x =  3;
            double    y = -5;
            double [] a =  new double [] { 2, 3, 5, 7, 11, 13 };

            double expected = -905;

            double actual = Series.SeriesXY13 (x, y, a);

            Assert.AreEqual (expected, actual);
        }
    }
}