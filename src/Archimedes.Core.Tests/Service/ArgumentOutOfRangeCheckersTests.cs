using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArgumentOutOfRangeCheckersTests
    {
        [TestMethod ()]
        public void CheckPositiveTest_Positive ()
        {
            int x = 42;

            bool flag = true;

            try
            {
                ArgumentOutOfRangeCheckers.CheckPositive (x);
            }

            catch
            {
                flag = false;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckPositiveTest_Zero ()
        {
            int x = 0;

            bool flag = false;

            try
            {
                ArgumentOutOfRangeCheckers.CheckPositive (x);
            }

            catch (ArgumentOutOfRangeException)
            {
                flag = true;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckPositiveTest_Negative ()
        {
            int x = -42;

            bool flag = false;

            try
            {
                ArgumentOutOfRangeCheckers.CheckPositive (x);
            }

            catch (ArgumentOutOfRangeException)
            {
                flag = true;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckNotNegativeTest_Positive ()
        {
            int x = 42;

            bool flag = true;

            try
            {
                ArgumentOutOfRangeCheckers.CheckNotNegative (x);
            }

            catch
            {
                flag = false;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckNotNegativeTest_Zero ()
        {
            int x = 0;

            bool flag = true;

            try
            {
                ArgumentOutOfRangeCheckers.CheckNotNegative (x);
            }

            catch
            {
                flag = false;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckNotNegativeTest_Negative ()
        {
            int x = -42;

            bool flag = false;

            try
            {
                ArgumentOutOfRangeCheckers.CheckNotNegative (x);
            }

            catch (ArgumentOutOfRangeException)
            {
                flag = true;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckGreaterTest_Greater ()
        {
            int x = 73;
            int a = 42;

            bool flag = true;

            try
            {
                ArgumentOutOfRangeCheckers.CheckGreater (x, a);
            }

            catch
            {
                flag = false;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckGreaterTest_Equal ()
        {
            int x = 42;
            int a = 42;

            bool flag = false;

            try
            {
                ArgumentOutOfRangeCheckers.CheckGreater (x, a);
            }

            catch (ArgumentOutOfRangeException)
            {
                flag = true;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckGreaterTest_Less ()
        {
            int x = -42;
            int a =  42;

            bool flag = false;

            try
            {
                ArgumentOutOfRangeCheckers.CheckGreater (x, a);
            }

            catch (ArgumentOutOfRangeException)
            {
                flag = true;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckIntervalTest_Less ()
        {
            double x = -1.0;
            double a =  0.0;
            double b =  1.0;

            bool flag = false;

            try
            {
                ArgumentOutOfRangeCheckers.CheckInterval (x, a, b);
            }

            catch (ArgumentOutOfRangeException)
            {
                flag = true;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckIntervalTest_LeftBound ()
        {
            double x = 0.0;
            double a = 0.0;
            double b = 1.0;

            bool flag = true;

            try
            {
                ArgumentOutOfRangeCheckers.CheckInterval (x, a, b);
            }

            catch
            {
                flag = false;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckIntervalTest_InInterval ()
        {
            double x = 0.5;
            double a = 0.0;
            double b = 1.0;

            bool flag = true;

            try
            {
                ArgumentOutOfRangeCheckers.CheckInterval (x, a, b);
            }

            catch
            {
                flag = false;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckIntervalTest_RightBound ()
        {
            double x = 1.0;
            double a = 0.0;
            double b = 1.0;

            bool flag = true;

            try
            {
                ArgumentOutOfRangeCheckers.CheckInterval (x, a, b);
            }

            catch (ArgumentOutOfRangeException)
            {
                flag = false;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckIntervalTest_Greater ()
        {
            double x = 2.0;
            double a = 0.0;
            double b = 1.0;

            bool flag = false;

            try
            {
                ArgumentOutOfRangeCheckers.CheckInterval (x, a, b);
            }

            catch (ArgumentOutOfRangeException)
            {
                flag = true;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckIntervalRightExcludedTest_Less ()
        {
            double x = -1.0;
            double a =  0.0;
            double b =  1.0;

            bool flag = false;

            try
            {
                ArgumentOutOfRangeCheckers.CheckIntervalRightExcluded (x, a, b);
            }

            catch (ArgumentOutOfRangeException)
            {
                flag = true;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckIntervalRightExcludedTest_LeftBound ()
        {
            double x = 0.0;
            double a = 0.0;
            double b = 1.0;

            bool flag = true;

            try
            {
                ArgumentOutOfRangeCheckers.CheckIntervalRightExcluded (x, a, b);
            }

            catch
            {
                flag = false;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckIntervalRightExcludedTest_InInterval ()
        {
            double x = 0.5;
            double a = 0.0;
            double b = 1.0;

            bool flag = true;

            try
            {
                ArgumentOutOfRangeCheckers.CheckIntervalRightExcluded (x, a, b);
            }

            catch
            {
                flag = false;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckIntervalRightExcludedTest_RightBound ()
        {
            double x = 1.0;
            double a = 0.0;
            double b = 1.0;

            bool flag = false;

            try
            {
                ArgumentOutOfRangeCheckers.CheckIntervalRightExcluded (x, a, b);
            }

            catch (ArgumentOutOfRangeException)
            {
                flag = true;
            }

            Assert.IsTrue (flag);
        }

        [TestMethod ()]
        public void CheckIntervalRightExcludedTest_Greater ()
        {
            double x = 2.0;
            double a = 0.0;
            double b = 1.0;

            bool flag = false;

            try
            {
                ArgumentOutOfRangeCheckers.CheckIntervalRightExcluded (x, a, b);
            }

            catch (ArgumentOutOfRangeException)
            {
                flag = true;
            }

            Assert.IsTrue (flag);
        }
    }
}