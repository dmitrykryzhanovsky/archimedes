using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Numerical.Tests
{
    [TestClass ()]
    public class EquationTests
    {
        [TestMethod ()]
        public void NewtonTest ()
        {
            EquationDelegate equation   = NewtonTest_Equation;
            EquationDelegate derivative = NewtonTest_Derivative;

            double halfEpsilon = 5.0e-13;
            double x0 = -5.5;

            double x = Equation.Newton (equation, derivative, halfEpsilon, x0);

            Assert.AreEqual (-8, x);
        }

        private double NewtonTest_Equation (double x, params double [] param)
        {
            return x * x * x * x + 4 * x * x * x - 43 * x * x - 58 * x + 240;
        }

        private double NewtonTest_Derivative (double x, params double [] param)
        {
            return 4 * x * x * x + 12 * x * x - 86 * x - 58;
        }
    }
}