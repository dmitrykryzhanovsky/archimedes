using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Matrix2Tests
    {
        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);

            Assert.AreEqual (2, m.Height);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);

            Assert.AreEqual (2, m.Width);
        }

        [TestMethod ()]
        public void Matrix2Test_Items ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 7);

            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (2, m.Width);
            Assert.AreEqual (2, m [0, 0]);
            Assert.AreEqual (3, m [0, 1]);
            Assert.AreEqual (5, m [1, 0]);
            Assert.AreEqual (7, m [1, 1]);
        }

        [TestMethod ()]
        public void Matrix2Test1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EqualsTest1 ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetHashCodeTest ()
        {
            Assert.Fail ();
        }
    }
}