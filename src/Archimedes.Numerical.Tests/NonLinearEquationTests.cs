using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Numerical.Tests
{
    [TestClass ()]
    public class NonLinearEquationTests
    {
        [TestMethod ()]
        public void NewtonTest ()
        {
            NonLinearEquationDelegate equation = NonLinearEquationFunction_NewtonTest_Equation;
            NonLinearEquationDelegate derivative = NonLinearEquationFunction_NewtonTest_Derivative;

            double epsilon = 1.0e-12 / 2.0;
            double xcurrent = -5.5;

            double x = NonLinearEquation.Newton (equation, derivative, epsilon, xcurrent);

            Assert.AreEqual (-8, x);
        }

        private double NonLinearEquationFunction_NewtonTest_Equation (double x, params double [] param)
        {
            return x * x * x * x + 4 * x * x * x - 43 * x * x - 58 * x + 240;
        }

        private double NonLinearEquationFunction_NewtonTest_Derivative (double x, params double [] param)
        {
            return 4 * x * x * x + 12 * x * x - 86 * x - 58;
        }
    }
}