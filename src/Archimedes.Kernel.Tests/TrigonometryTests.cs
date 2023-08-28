using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

using Archimedes;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    {
        [TestMethod ()]
        public void DegToRadTest ()
        {
            double deg = 60.0;

            double expected = MathConst.PI_3;

            double actual = Trigonometry.DegToRad (deg);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void MinToRadTest ()
        {
            double min = 3600.0;

            double expected = MathConst.PI_3;

            double actual = Trigonometry.MinToRad (min);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void SecToRadTest ()
        {
            double sec = 216000.0;

            double expected = MathConst.PI_3;

            double actual = Trigonometry.SecToRad (sec);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HourToRadTest ()
        {
            double hour = 4.0;

            double expected = MathConst.PI_3;

            double actual = Trigonometry.HourToRad (hour);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HMinToRadTest ()
        {
            double hmin = 240.0;

            double expected = MathConst.PI_3;

            double actual = Trigonometry.HMinToRad (hmin);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void HSecToRadTest ()
        {
            double hsec = 14400.0;

            double expected = MathConst.PI_3;

            double actual = Trigonometry.HSecToRad (hsec);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RadToDegTest ()
        {
            double rad = MathConst.PI_3;

            double expected = 60.0;

            double actual = Trigonometry.RadToDeg (rad);

            Assert.AreEqual (expected, actual, 1.0e-14);
        }

        [TestMethod ()]
        public void RadToMinTest ()
        {
            double rad = MathConst.PI_3;

            double expected = 3600.0;

            double actual = Trigonometry.RadToMin (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void RadToSecTest ()
        {
            double rad = MathConst.PI_3;

            double expected = 216000.0;

            double actual = Trigonometry.RadToSec (rad);

            Assert.AreEqual (expected, actual, 1.0e-10);
        }

        [TestMethod ()]
        public void RadToHourTest ()
        {
            double rad = MathConst.PI_3;

            double expected = 4.0;

            double actual = Trigonometry.RadToHour (rad);

            Assert.AreEqual (expected, actual, 1.0e-15);
        }

        [TestMethod ()]
        public void RadToHMinTest ()
        {
            double rad = MathConst.PI_3;

            double expected = 240.0;

            double actual = Trigonometry.RadToHMin (rad);

            Assert.AreEqual (expected, actual, 1.0e-13);
        }

        [TestMethod ()]
        public void RadToHSecTest ()
        {
            double rad = MathConst.PI_3;

            double expected = 14400.0;

            double actual = Trigonometry.RadToHSec (rad);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_Minus3PI ()
        {
            double x = -3.0 * Math.PI;

            double expected = Math.PI;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_RoundMinus1_Negative ()
        {
            double x = -9.0;

            double expected = -9.0 + Math.Tau;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_Minus2PI ()
        {
            double x = -Math.Tau;

            double expected = 0.0;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_RoundMinus1_Positive ()
        {
            double x = -4.0;

            double expected = -4.0 + Math.Tau;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_MinusPI ()
        {
            double x = -Math.PI;

            double expected = Math.PI;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_Round0_Negative ()
        {
            double x = -3.0;

            double expected = -3.0;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_0 ()
        {
            double x = 0.0;

            double expected = 0.0;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_Round0_Positive ()
        {
            double x = 3.0;

            double expected = 3.0;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_PlusPI ()
        {
            double x = Math.PI;

            double expected = Math.PI;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_RoundPlus1_Negative ()
        {
            double x = 4.0;

            double expected = 4.0 - Math.Tau;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_Plus2PI ()
        {
            double x = Math.Tau;

            double expected = 0.0;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_RoundPlus1_Positive ()
        {
            double x = 9.0;

            double expected = 9.0 - Math.Tau;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void NormalizePM180Test_Plus3PI ()
        {
            double x = 3.0 * Math.PI;

            double expected = Math.PI;

            double actual = Trigonometry.NormalizePM180 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_Minus3PI ()
        {
            double x = -3.0 * Math.PI;

            double expected = Math.PI;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_RoundMinus1_Negative ()
        {
            double x = -9.0;

            double expected = 2.0 * Math.Tau - 9.0;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_Minus2PI ()
        {
            double x = -Math.Tau;

            double expected = 0.0;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_RoundMinus1_Positive ()
        {
            double x = -4.0;

            double expected = Math.Tau - 4.0;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_MinusPI ()
        {
            double x = -Math.PI;

            double expected = Math.PI;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_Round0_Negative ()
        {
            double x = -3.0;

            double expected = Math.Tau - 3.0;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_0 ()
        {
            double x = 0.0;

            double expected = 0.0;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_Round0_Positive ()
        {
            double x = 3.0;

            double expected = 3.0;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_PlusPI ()
        {
            double x = Math.PI;

            double expected = Math.PI;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_RoundPlus1_Negative ()
        {
            double x = 4.0;

            double expected = 4.0;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_Plus2PI ()
        {
            double x = Math.Tau;

            double expected = 0.0;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_RoundPlus1_Positive ()
        {
            double x = 9.0;

            double expected = 9.0 - Math.Tau;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void Normalize360Test_Plus3PI ()
        {
            double x = 3.0 * Math.PI;

            double expected = Math.PI;

            double actual = Trigonometry.Normalize360 (x);

            Assert.AreEqual (expected, actual);
        }
    }
}