using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class IntExtensionTests
    {
        [TestMethod ()]
        public void IsEvenTest_0 ()
        {
            int n = 0;

            bool expected = true;

            bool actual = n.IsEven ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsEvenTest_1 ()
        {
            int n = 1;

            bool expected = false;

            bool actual = n.IsEven ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsEvenTest_42 ()
        {
            int n = 42;

            bool expected = true;

            bool actual = n.IsEven ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsEvenTest_73 ()
        {
            int n = 73;

            bool expected = false;

            bool actual = n.IsEven ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsEvenTest_minus256 ()
        {
            int n = -256;

            bool expected = true;

            bool actual = n.IsEven ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsEvenTest_minus255 ()
        {
            int n = -255;

            bool expected = false;

            bool actual = n.IsEven ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsOddTest_0 ()
        {
            int n = 0;

            bool expected = false;

            bool actual = n.IsOdd ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsOddTest_1 ()
        {
            int n = 1;

            bool expected = true;

            bool actual = n.IsOdd ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsOddTest_42 ()
        {
            int n = 42;

            bool expected = false;

            bool actual = n.IsOdd ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsOddTest_73 ()
        {
            int n = 73;

            bool expected = true;

            bool actual = n.IsOdd ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsOddTest_minus256 ()
        {
            int n = -256;

            bool expected = false;

            bool actual = n.IsOdd ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsOddTest_minus255 ()
        {
            int n = -255;

            bool expected = true;

            bool actual = n.IsOdd ();

            Assert.AreEqual (expected, actual);
        }
    }
}