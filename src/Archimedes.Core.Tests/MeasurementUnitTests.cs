using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class MeasurementUnitTests
    {
        [TestMethod ()]
        public void SplitDegreeTest_Positive_D ()
        {
            double degree = 60.0;

            (double sign, int deg, int min, double sec) expected = MeasurementUnit.SplitDegree (degree);

            (double sign, int deg, int min, double sec) actual = (1.0, 60, 0, 0.0);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.deg, actual.deg);
            Assert.AreEqual (expected.min, actual.min);
            Assert.AreEqual (expected.sec, actual.sec);
        }

        [TestMethod ()]
        public void SplitDegreeTest_Positive_DM ()
        {
            double degree = 60.5;

            (double sign, int deg, int min, double sec) expected = MeasurementUnit.SplitDegree (degree);

            (double sign, int deg, int min, double sec) actual = (1.0, 60, 30, 0.0);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.deg, actual.deg);
            Assert.AreEqual (expected.min, actual.min);
            Assert.AreEqual (expected.sec, actual.sec);
        }

        [TestMethod ()]
        public void SplitDegreeTest_Positive_DMS ()
        {
            double degree = 60.51;

            (double sign, int deg, int min, double sec) expected = MeasurementUnit.SplitDegree (degree);

            (double sign, int deg, int min, double sec) actual = (1.0, 60, 30, 36.0);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.deg, actual.deg);
            Assert.AreEqual (expected.min, actual.min);
            Assert.AreEqual (expected.sec, actual.sec, 1.0e-11);
        }

        [TestMethod ()]
        public void SplitDegreeTest_Positive_DMSFloat ()
        {
            double degree = 60.512;

            (double sign, int deg, int min, double sec) expected = MeasurementUnit.SplitDegree (degree);

            (double sign, int deg, int min, double sec) actual = (1.0, 60, 30, 43.2);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.deg, actual.deg);
            Assert.AreEqual (expected.min, actual.min);
            Assert.AreEqual (expected.sec, actual.sec, 1.0e-10);
        }

        [TestMethod ()]
        public void SplitDegreeTest_Positive_0M ()
        {
            double degree = 0.5;

            (double sign, int deg, int min, double sec) expected = MeasurementUnit.SplitDegree (degree);

            (double sign, int deg, int min, double sec) actual = (1.0, 0, 30, 0.0);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.deg, actual.deg);
            Assert.AreEqual (expected.min, actual.min);
            Assert.AreEqual (expected.sec, actual.sec);
        }

        [TestMethod ()]
        public void SplitDegreeTest_Positive_0MS ()
        {
            double degree = 0.51;

            (double sign, int deg, int min, double sec) expected = MeasurementUnit.SplitDegree (degree);

            (double sign, int deg, int min, double sec) actual = (1.0, 0, 30, 36.0);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.deg, actual.deg);
            Assert.AreEqual (expected.min, actual.min);
            Assert.AreEqual (expected.sec, actual.sec, 1.0e-11);
        }

        [TestMethod ()]
        public void SplitDegreeTest_Positive_0MSFloat ()
        {
            double degree = 0.512;

            (double sign, int deg, int min, double sec) expected = MeasurementUnit.SplitDegree (degree);

            (double sign, int deg, int min, double sec) actual = (1.0, 0, 30, 43.2);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.deg, actual.deg);
            Assert.AreEqual (expected.min, actual.min);
            Assert.AreEqual (expected.sec, actual.sec, 1.0e-10);
        }

        [TestMethod ()]
        public void SplitDegreeTest_Positive_00S ()
        {
            double degree = 0.01;

            (double sign, int deg, int min, double sec) expected = MeasurementUnit.SplitDegree (degree);

            (double sign, int deg, int min, double sec) actual = (1.0, 0, 0, 36.0);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.deg, actual.deg);
            Assert.AreEqual (expected.min, actual.min);
            Assert.AreEqual (expected.sec, actual.sec, 1.0e-11);
        }

        [TestMethod ()]
        public void SplitDegreeTest_Positive_00SFloat ()
        {
            double degree = 0.012;

            (double sign, int deg, int min, double sec) expected = MeasurementUnit.SplitDegree (degree);

            (double sign, int deg, int min, double sec) actual = (1.0, 0, 0, 43.2);

            Assert.AreEqual (expected.sign, actual.sign);
            Assert.AreEqual (expected.deg, actual.deg);
            Assert.AreEqual (expected.min, actual.min);
            Assert.AreEqual (expected.sec, actual.sec, 1.0e-10);
        }

        // Добавить такие же тесты для отрицательных углов
        // Добавить тесты для 0

        //[TestMethod ()]
        //public void SplitHourTest ()
        //{
        //    Assert.Fail ();
        //}

        //[TestMethod ()]
        //public void AssembleDegreeTest ()
        //{
        //    Assert.Fail ();
        //}

        //[TestMethod ()]
        //public void AssembleHourTest ()
        //{
        //    Assert.Fail ();
        //}
    }
}