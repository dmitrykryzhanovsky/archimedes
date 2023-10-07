using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace Archimedes.Numerical.Tests
{
    [TestClass ()]
    public class DiffEquationTests
    {
        [TestMethod ()]
        public void RungeKuttaTest_Parabola ()
        {
            DiffEquationDelegate equation = DiffEquationFunction_RungeKuttaTest_Parabola;

            double [] param = new double [] { 30, -10 };
            double x0 = 0.0;
            double y0 = 0.0;
            double step = 1.0;
            int iterations = 6;

            double [] y = DiffEquation.RungeKutta (equation, param, x0, y0, step, iterations);

            Assert.AreEqual (0, y [0]);
            Assert.AreEqual (25, y [1]);
            Assert.AreEqual (40, y [2]);
            Assert.AreEqual (45, y [3]);
            Assert.AreEqual (40, y [4]);
            Assert.AreEqual (25, y [5]);
            Assert.AreEqual (0, y [6]);
        }

        [TestMethod ()]
        public void RungeKuttaTest_Exponent ()
        {
            DiffEquationDelegate equation = DiffEquationFunction_RungeKuttaTest_Exponent;

            double [] param = null;
            double x0 = 0.0;
            double y0 = 1.0;
            double step = 1.0e-6;
            int iterations = 6000000;

            double [] y = DiffEquation.RungeKutta (equation, param, x0, y0, step, iterations);

            Assert.AreEqual (1.0, y [0]);
            Assert.AreEqual (7.38905609893065, y [1000000], 1.0e-10);
            Assert.AreEqual (54.5981500331442, y [2000000], 1.0e-8);
            Assert.AreEqual (403.428793492735, y [3000000], 1.0e-8);
            Assert.AreEqual (2980.95798704173, y [4000000], 1.0e-6);
            Assert.AreEqual (22026.4657948067, y [5000000], 1.0e-4);
            Assert.AreEqual (162754.791419004, y [6000000], 1.0e-3);
        }

        [TestMethod ()]
        public void RungeKuttaTest_Cosine ()
        {
            DiffEquationDelegate equation = DiffEquationFunction_RungeKuttaTest_Cosine;

            double [] param = null;
            double x0 = 5.0 / 3.0;
            double y0 = 2.0;
            double step = Math.PI / 1800000.0;
            int iterations = 3600000;

            double [] y = DiffEquation.RungeKutta (equation, param, x0, y0, step, iterations);

            Assert.AreEqual (2.0, y [0]);
            Assert.AreEqual (1.0, y [200000], 1.0e-11);
            Assert.AreEqual (0.0, y [300000], 1.0e-11);
            Assert.AreEqual (-2.0, y [600000], 1.0e-9);
            Assert.AreEqual (0.0, y [900000], 1.0e-9);
        }

        private double DiffEquationFunction_RungeKuttaTest_Parabola (double x, double y, params double [] param)
        {
            return param [0] + param [1] * x;
        }

        private double DiffEquationFunction_RungeKuttaTest_Exponent (double x, double y, params double [] param)
        {
            return 2.0 * Math.Exp (2.0 * x);
        }

        private double DiffEquationFunction_RungeKuttaTest_Cosine (double x, double y, params double [] param)
        {
            return -6.0 * Math.Sin (3.0 * x - 5.0);
        }
    }
}