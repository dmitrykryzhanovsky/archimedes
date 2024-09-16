using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Vector3Tests
    {
        [TestMethod ()]
        public void opMultiplyTest ()
        {
            Vector3 v1 = new Vector3 (2, 3, 5);
            Vector3 v2 = new Vector3 (5, 8, 13);

            double expected = 99;

            double actual = v1 * v2;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Vector3 v = new Vector3 (6, 8, 10);

            double expected = 200;

            double actual = v.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }
    }
}