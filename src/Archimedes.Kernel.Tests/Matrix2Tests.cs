using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class Matrix2Tests
    {
        [TestMethod ()]
        public void HeightTest ()
        {
            Matrix2 m = new Matrix2 ();

            Assert.AreEqual (2, m.Height);
        }

        [TestMethod ()]
        public void WidthTest ()
        {
            Matrix2 m = new Matrix2 ();

            Assert.AreEqual (2, m.Width);
        }

        [TestMethod ()]
        public void ConstructorTest_NoParams ()
        {
            Matrix2 m = new Matrix2 ();

            Assert.AreEqual (4, m.Items.Length);
            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (2, m.Width);
        }

        [TestMethod ()]
        public void ConstructorTest_FourItems ()
        {
            Matrix2 m = new Matrix2 (2, 3, 5, 8);

            Assert.AreEqual (4, m.Items.Length);
            Assert.AreEqual (2, m.Height);
            Assert.AreEqual (2, m.Width);

            Assert.AreEqual (2, m [0, 0]);
            Assert.AreEqual (3, m [0, 1]);
            Assert.AreEqual (5, m [1, 0]);
            Assert.AreEqual (8, m [1, 1]);

            Assert.AreEqual (2, m.Items [0]);
            Assert.AreEqual (3, m.Items [1]);
            Assert.AreEqual (5, m.Items [2]);
            Assert.AreEqual (8, m.Items [3]);
        }

        [TestMethod ()]
        public void ConstructorTest_Copying ()
        {
            Matrix2 source = new Matrix2 (2, 3, 5, 8);
            Matrix2 copy = new Matrix2 (source);

            Assert.AreEqual (4, copy.Items.Length);
            Assert.AreEqual (2, copy.Height);
            Assert.AreEqual (2, copy.Width);

            Assert.AreEqual (2, copy [0, 0]);
            Assert.AreEqual (3, copy [0, 1]);
            Assert.AreEqual (5, copy [1, 0]);
            Assert.AreEqual (8, copy [1, 1]);

            Assert.AreEqual (2, copy.Items [0]);
            Assert.AreEqual (3, copy.Items [1]);
            Assert.AreEqual (5, copy.Items [2]);
            Assert.AreEqual (8, copy.Items [3]);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Matrix2 source = new Matrix2 (2, 3, 5, 8);
            Matrix2 clone = (Matrix2)source.Clone ();

            Assert.AreEqual (4, clone.Items.Length);
            Assert.AreEqual (2, clone.Height);
            Assert.AreEqual (2, clone.Width);

            Assert.AreEqual (2, clone [0, 0]);
            Assert.AreEqual (3, clone [0, 1]);
            Assert.AreEqual (5, clone [1, 0]);
            Assert.AreEqual (8, clone [1, 1]);

            Assert.AreEqual (2, clone.Items [0]);
            Assert.AreEqual (3, clone.Items [1]);
            Assert.AreEqual (5, clone.Items [2]);
            Assert.AreEqual (8, clone.Items [3]);
        }

        [TestMethod ()]
        public void EqualsTest_EqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 3, 5, 8);

            Assert.AreEqual (true, m1.Equals (m2));
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualItems ()
        {
            Matrix2 m1 = new Matrix2 (2, 3, 5, 8);
            Matrix2 m2 = new Matrix2 (2, 4, 8, 16);

            Assert.AreEqual (false, m1.Equals (m2));
        }
    }
}