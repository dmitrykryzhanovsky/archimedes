using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class QuaternionTests
    {
        [TestMethod ()]
        public void QuaternionTest_FourRealNumbers ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);

            Assert.AreEqual ( 5, q.A);
            Assert.AreEqual ( 7, q.B);
            Assert.AreEqual (11, q.C);
            Assert.AreEqual (13, q.D);
        }

        [TestMethod ()]
        public void QuaternionTest_Scalar ()
        {
            Quaternion q = new Quaternion (2);

            Assert.AreEqual (2, q.A);
            Assert.AreEqual (0, q.B);
            Assert.AreEqual (0, q.C);
            Assert.AreEqual (0, q.D);
        }

        [TestMethod ()]
        public void QuaternionTest_Complex ()
        {
            Quaternion q = new Quaternion (new Complex (3, 4));

            Assert.AreEqual (3, q.A);
            Assert.AreEqual (4, q.B);
            Assert.AreEqual (0, q.C);
            Assert.AreEqual (0, q.D);
        }

        [TestMethod ()]
        public void QuaternionTest_TwoComplexes ()
        {
            Quaternion q = new Quaternion (new Complex (5, 7), new Complex (11, 13));

            Assert.AreEqual ( 5, q.A);
            Assert.AreEqual ( 7, q.B);
            Assert.AreEqual (11, q.C);
            Assert.AreEqual (13, q.D);
        }

        [TestMethod ()]
        public void QuaternionTest_ScalarVector ()
        {
            Quaternion q = new Quaternion (5, new Vector3 (7, 11, 13));

            Assert.AreEqual ( 5, q.A);
            Assert.AreEqual ( 7, q.B);
            Assert.AreEqual (11, q.C);
            Assert.AreEqual (13, q.D);
        }

        [TestMethod ()]
        public void QuaternionTest_Vector ()
        {
            Quaternion q = new Quaternion (new Vector3 (7, 11, 13));

            Assert.AreEqual ( 0, q.A);
            Assert.AreEqual ( 7, q.B);
            Assert.AreEqual (11, q.C);
            Assert.AreEqual (13, q.D);
        }        

        [TestMethod ()]
        public void QuaternionTest_Copying ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            Quaternion p = new Quaternion (q);

            Assert.AreEqual ( 5, p.A);
            Assert.AreEqual ( 7, p.B);
            Assert.AreEqual (11, p.C);
            Assert.AreEqual (13, p.D);
        }

        [TestMethod ()]
        public void CloneTest ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            Quaternion p = (Quaternion)q.Clone ();

            Assert.AreEqual ( 5, p.A);
            Assert.AreEqual ( 7, p.B);
            Assert.AreEqual (11, p.C);
            Assert.AreEqual (13, p.D);
        }

        [TestMethod ()]
        public void EqualsTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void ConjugateTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void ReciprocalTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void EuclideanProductTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void ScalarProductTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void OuterProductTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void CrossProductTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void GetNormTest ()
        {
            Assert.Fail ();
        }

        [TestMethod ()]
        public void IsIntegerTest ()
        {
            Assert.Fail ();
        }
    }
}