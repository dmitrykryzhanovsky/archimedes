using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class QuaternionTests
    {
        [TestMethod ()]
        public void ATest_Get ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);

            Assert.AreEqual (2, q.A);
        }

        [TestMethod ()]
        public void ATest_Set ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);

            q.A = 4;

            Assert.AreEqual (4, q.A);
        }

        [TestMethod ()]
        public void BTest_Get ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);

            Assert.AreEqual (3, q.B);
        }

        [TestMethod ()]
        public void BTest_Set ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);

            q.B = 9;

            Assert.AreEqual (9, q.B);
        }

        [TestMethod ()]
        public void CTest_Get ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);

            Assert.AreEqual (5, q.C);
        }

        [TestMethod ()]
        public void CTest_Set ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);

            q.C = 25;

            Assert.AreEqual (25, q.C);
        }

        [TestMethod ()]
        public void DTest_Get ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);

            Assert.AreEqual (8, q.D);
        }

        [TestMethod ()]
        public void DTest_Set ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);

            q.D = 64;

            Assert.AreEqual (64, q.D);
        }

        [TestMethod ()]
        public void UTest ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);

            Vector3 u = q.U;

            Assert.AreEqual ( 7, u [0]);
            Assert.AreEqual (11, u [1]);
            Assert.AreEqual (13, u [2]);
        }

        [TestMethod ()]
        public void IsScalarTest_True ()
        {
            Quaternion q = new Quaternion (5, 0, 0, 0);

            bool expected = true;

            bool actual = q.IsScalar;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsScalarTest_False ()
        {
            Quaternion q = new Quaternion (5, 0, 0, 8);

            bool expected = false;

            bool actual = q.IsScalar;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsComplexTest_True ()
        {
            Quaternion q = new Quaternion (5, 0, 0, 0);

            bool expected = true;

            bool actual = q.IsComplex;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsComplexTest_False ()
        {
            Quaternion q = new Quaternion (5, 0, 0, 8);

            bool expected = false;

            bool actual = q.IsComplex;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsVectorTest_True ()
        {
            Quaternion q = new Quaternion (0, 5, 8, 13);

            bool expected = true;

            bool actual = q.IsVector;

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void IsVectorTest_False ()
        {
            Quaternion q = new Quaternion (5, 0, 0, 0);

            bool expected = false;

            bool actual = q.IsVector;

            Assert.AreEqual (expected, actual);
        }

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
        public void EqualsTest_Quaternion_Equal ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            Quaternion p = new Quaternion (5, 7, 11, 13);

            bool expected = true;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Quaternion_NotEqual ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            Quaternion p = new Quaternion (5, 7, 11, 12);

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_Equal ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            Quaternion p = new Quaternion (5, 7, 11, 13);

            bool expected = true;

            bool actual = (q == p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opEqualTest_NotEqual ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            Quaternion p = new Quaternion (5, 7, 10, 12);

            bool expected = false;

            bool actual = (q == p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_Equal ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            Quaternion p = new Quaternion (5, 7, 11, 13);

            bool expected = false;

            bool actual = (q != p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opNotEqualTest_NotEqual ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            Quaternion p = new Quaternion (5, 6, 10, 12);

            bool expected = true;

            bool actual = (q != p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectQuaternion_Equal ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            object p = new Quaternion (5, 7, 11, 13);

            bool expected = true;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectQuaternion_NotEqual ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            object p = new Quaternion (4, 6, 10, 12);

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectVector_Equal ()
        {
            Quaternion q = new Quaternion (0, 7, 11, 13);
            object p = new Vector (7, 11, 13);

            bool expected = true;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectVector_NotEqual_ANotZero ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            object p = new Vector (7, 11, 13);

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectVector_NotEqual_DimensionNotThree ()
        {
            Quaternion q = new Quaternion (0, 7, 11, 13);
            object p = new Vector (7, 11, 13, 17);

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectVector_NotEqual_DifferentComponents ()
        {
            Quaternion q = new Quaternion (0, 7, 11, 13);
            object p = new Vector (7, 11, 12);

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectVector3_Equal ()
        {
            Quaternion q = new Quaternion (0, 7, 11, 13);
            object p = new Vector3 (7, 11, 13);

            bool expected = true;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectVector3_NotEqual_ANotZero ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            object p = new Vector3 (7, 11, 13);

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }        

        [TestMethod ()]
        public void EqualsTest_ObjectVector3_NotEqual_DifferentComponents ()
        {
            Quaternion q = new Quaternion (0, 7, 11, 13);
            object p = new Vector3 (7, 11, 12);

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectComplex_Equal ()
        {
            Quaternion q = new Quaternion (5, 7, 0, 0);
            object p = new Complex (5, 7);

            bool expected = true;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectComplex_NotEqual_CDNotZero ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            object p = new Complex (5, 7);

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectComplex_NotEqual_DifferentComponents ()
        {
            Quaternion q = new Quaternion (4, 6, 0, 0);
            object p = new Complex (7, 11);

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectDouble_Equal ()
        {
            Quaternion q = new Quaternion (5, 0, 0, 0);
            double p = 5.0;

            bool expected = true;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectDouble_NotEqual_BCDNotZero ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            double p = 5.0;

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectDouble_NotEqual_DifferentComponents ()
        {
            Quaternion q = new Quaternion (4, 0, 0, 0);
            double p = 5.0;

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectInt32_Equal ()
        {
            Quaternion q = new Quaternion (5, 0, 0, 0);
            int p = 5;

            bool expected = true;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectInt32_NotEqual_BCDNotZero ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            int p = 5;

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectInt32_NotEqual_DifferentComponents ()
        {
            Quaternion q = new Quaternion (4, 0, 0, 0);
            int p = 5;

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectUInt32_Equal ()
        {
            Quaternion q = new Quaternion (5, 0, 0, 0);
            uint p = 5;

            bool expected = true;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectUInt32_NotEqual_BCDNotZero ()
        {
            Quaternion q = new Quaternion (5, 7, 11, 13);
            uint p = 5;

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_ObjectUInt32_NotEqual_DifferentComponents ()
        {
            Quaternion q = new Quaternion (4, 0, 0, 0);
            uint p = 5;

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_Object_NotEqual_NotAppropriateType ()
        {
            Quaternion q = new Quaternion (4, 0, 0, 0);
            string p = "Kapysh";

            bool expected = false;

            bool actual = q.Equals (p);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void opImplicitTest_Double ()
        {
            double p = 5;

            Quaternion q = (Quaternion)p;

            Assert.AreEqual (5, q.A);
            Assert.AreEqual (0, q.B);
            Assert.AreEqual (0, q.C);
            Assert.AreEqual (0, q.D);
        }

        [TestMethod ()]
        public void opImplicitTest_Complex ()
        {
            Complex p = new Complex (3, 4);

            Quaternion q = (Quaternion)p;

            Assert.AreEqual (3, q.A);
            Assert.AreEqual (4, q.B);
            Assert.AreEqual (0, q.C);
            Assert.AreEqual (0, q.D);
        }

        [TestMethod ()]
        public void opImplicitTest_Vector3 ()
        {
            Vector3 p = new Vector3 (3, 4, 7);

            Quaternion q = (Quaternion)p;

            Assert.AreEqual (0, q.A);
            Assert.AreEqual (3, q.B);
            Assert.AreEqual (4, q.C);
            Assert.AreEqual (7, q.D);
        }

        [TestMethod ()]
        public void opImplicitTest_Vector_DimensionThree ()
        {
            Vector p = new Vector (3, 4, 7);

            Quaternion q = (Quaternion)p;

            Assert.AreEqual (0, q.A);
            Assert.AreEqual (3, q.B);
            Assert.AreEqual (4, q.C);
            Assert.AreEqual (7, q.D);
        }

        [TestMethod ()]
        public void opImplicitTest_Vector_DimensionNotThree ()
        {
            Vector p = new Vector (3, 4, 7, 11);

            bool invalidCastException = false;

            try
            {
                Quaternion q = (Quaternion)p;
            }

            catch (InvalidCastException)
            {
                invalidCastException = true;
            }

            Assert.AreEqual (true, invalidCastException);
        }

        [TestMethod ()]
        public void ConjugateTest ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);
            Quaternion p = Quaternion.Conjugate (q);

            Assert.AreEqual ( 2, p.A);
            Assert.AreEqual (-3, p.B);
            Assert.AreEqual (-5, p.C);
            Assert.AreEqual (-8, p.D);
        }

        [TestMethod ()]
        public void ReciprocalTest ()
        {
            Quaternion q = new Quaternion (double.Sqrt (2.0), 3, 5, 8);
            Quaternion p = Quaternion.Reciprocal (q);

            Assert.AreEqual (double.Sqrt (2.0) / 100.0, p.A);
            Assert.AreEqual (-0.03, p.B);
            Assert.AreEqual (-0.05, p.C);
            Assert.AreEqual (-0.08, p.D);
        }

        [TestMethod ()]
        public void oppAddTest_QuaternionQuaternion ()
        {
            Quaternion q = new Quaternion ( 2,  3,  5,  8);
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Quaternion expected = new Quaternion (15, 24, 39, 63);

            Quaternion actual = q + p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppAddTest_QuaternionComplex ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);
            Complex p = new Complex (13, 21);

            Quaternion expected = new Quaternion (15, 24, 5, 8);

            Quaternion actual = q + p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppAddTest_ComplexQuaternion ()
        {
            Complex q = new Complex (2, 3);
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Quaternion expected = new Quaternion (15, 24, 34, 55);

            Quaternion actual = q + p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppAddTest_QuaternionDouble ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);
            double p = 13;

            Quaternion expected = new Quaternion (15, 3, 5, 8);

            Quaternion actual = q + p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppAddTest_DoubleQuaternion ()
        {
            double q = 2;
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Quaternion expected = new Quaternion (15, 21, 34, 55);

            Quaternion actual = q + p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppSubtractTest_QuaternionQuaternion ()
        {
            Quaternion q = new Quaternion ( 2,  3,  5,  8);
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Quaternion expected = new Quaternion (-11, -18, -29, -47);

            Quaternion actual = q - p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppSubtractTest_QuaternionComplex ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);
            Complex p = new Complex (13, 21);

            Quaternion expected = new Quaternion (-11, -18, 5, 8);

            Quaternion actual = q - p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppSubtractTest_ComplexQuaternion ()
        {
            Complex q = new Complex (2, 3);
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Quaternion expected = new Quaternion (-11, -18, -34, -55);

            Quaternion actual = q - p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppSubtractTest_QuaternionDouble ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);
            double p = 13;

            Quaternion expected = new Quaternion (-11, 3, 5, 8);

            Quaternion actual = q - p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppSubtractTest_DoubleQuaternion ()
        {
            double q = 2;
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Quaternion expected = new Quaternion (-11, -21, -34, -55);

            Quaternion actual = q - p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppNegateTes ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);

            Quaternion expected = new Quaternion (-2, -3, -5, -8);

            Quaternion actual = -q;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_OneByOne()
        {
            Quaternion q = Quaternion.One;
            Quaternion p = Quaternion.One;

            Quaternion expected = Quaternion.One;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_OneByI ()
        {
            Quaternion q = Quaternion.One;
            Quaternion p = Quaternion.I;

            Quaternion expected = Quaternion.I;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_OneByJ ()
        {
            Quaternion q = Quaternion.One;
            Quaternion p = Quaternion.J;

            Quaternion expected = Quaternion.J;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_OneByK ()
        {
            Quaternion q = Quaternion.One;
            Quaternion p = Quaternion.K;

            Quaternion expected = Quaternion.K;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_IByOne ()
        {
            Quaternion q = Quaternion.I;
            Quaternion p = Quaternion.One;

            Quaternion expected = Quaternion.I;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_IByI ()
        {
            Quaternion q = Quaternion.I;
            Quaternion p = Quaternion.I;

            Quaternion expected = -Quaternion.One;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_IByJ ()
        {
            Quaternion q = Quaternion.I;
            Quaternion p = Quaternion.J;

            Quaternion expected = Quaternion.K;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_IByK ()
        {
            Quaternion q = Quaternion.I;
            Quaternion p = Quaternion.K;

            Quaternion expected = -Quaternion.J;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_JByOne ()
        {
            Quaternion q = Quaternion.J;
            Quaternion p = Quaternion.One;

            Quaternion expected = Quaternion.J;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_JByI ()
        {
            Quaternion q = Quaternion.J;
            Quaternion p = Quaternion.I;

            Quaternion expected = -Quaternion.K;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_JByJ ()
        {
            Quaternion q = Quaternion.J;
            Quaternion p = Quaternion.J;

            Quaternion expected = -Quaternion.One;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_JByK ()
        {
            Quaternion q = Quaternion.J;
            Quaternion p = Quaternion.K;

            Quaternion expected = Quaternion.I;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_KByOne ()
        {
            Quaternion q = Quaternion.K;
            Quaternion p = Quaternion.One;

            Quaternion expected = Quaternion.K;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_KByI ()
        {
            Quaternion q = Quaternion.K;
            Quaternion p = Quaternion.I;

            Quaternion expected = Quaternion.J;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_KByJ ()
        {
            Quaternion q = Quaternion.K;
            Quaternion p = Quaternion.J;

            Quaternion expected = -Quaternion.I;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_KByK ()
        {
            Quaternion q = Quaternion.K;
            Quaternion p = Quaternion.K;

            Quaternion expected = -Quaternion.One;

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_QuaternionQuaternion ()
        {
            Quaternion q = new Quaternion ( 2,  3,  5,  8);
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Quaternion expected = new Quaternion (-647, 84, 136, 211);

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_QuaternionComplex ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);
            Complex p = new Complex (13, 21);

            Quaternion expected = new Quaternion (-37, 81, 233, -1);

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_ComplexQuaternion ()
        {
            Complex q = new Complex (2, 3);
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Quaternion expected = new Quaternion (-37, 81, -97, 212);

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_QuaternionDouble ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);
            double p = 13;

            Quaternion expected = new Quaternion (26, 39, 65, 104);

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_DoubleQuaternion ()
        {
            double q = 2;
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Quaternion expected = new Quaternion (26, 42, 68, 110);

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_QuaternionVector ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);
            Vector3 p = new Vector3 (21, 34, 55);

            Quaternion expected = new Quaternion (-673, 45, 71, 107);

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void oppMultiplyTest_VectorQuaternion ()
        {
            Vector3 q = new Vector3 (3, 5, 8);
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Quaternion expected = new Quaternion (-673, 42, 68, 101);

            Quaternion actual = q * p;

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void EuclideanProductTest ()
        {
            Quaternion q = new Quaternion ( 2,  3,  5,  8);
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Quaternion expected = new Quaternion (699, 0, 0, 9);

            Quaternion actual = Quaternion.EuclideanProduct (q, p);

            Assert.AreEqual (expected.A, actual.A);
            Assert.AreEqual (expected.B, actual.B);
            Assert.AreEqual (expected.C, actual.C);
            Assert.AreEqual (expected.D, actual.D);
        }

        [TestMethod ()]
        public void ScalarProductTest ()
        {
            Quaternion q = new Quaternion ( 2,  3,  5,  8);
            Quaternion p = new Quaternion (13, 21, 34, 55);

            double expected = 699;

            Quaternion actual = Quaternion.ScalarProduct (q, p);

            Assert.AreEqual (expected, actual);
        }
    
        [TestMethod ()]
        public void OuterProductTest ()
        {
            Quaternion q = new Quaternion ( 2,  3,  5,  8);
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Vector3 expected = new Vector3 (0, 0, 9);

            Vector3 actual = Quaternion.OuterProduct (q, p);

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
        }

        [TestMethod ()]
        public void CrossProductTest ()
        {
            Quaternion q = new Quaternion  (2,  3,  5,  8);
            Quaternion p = new Quaternion (13, 21, 34, 55);

            Vector3 expected = new Vector3 (3, 3, -3);

            Vector3 actual = Quaternion.CrossProduct (q, p);

            Assert.AreEqual (expected [0], actual [0]);
            Assert.AreEqual (expected [1], actual [1]);
            Assert.AreEqual (expected [2], actual [2]);
        }

        [TestMethod ()]
        public void GetNorm2Test ()
        {
            Quaternion q = new Quaternion (2, 3, 5, 8);

            double expected = 102;

            double actual = q.GetNorm2 ();

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void GetNormTest ()
        {
            Quaternion q = new Quaternion (double.Sqrt (2.0), 3, 5, 8);

            double expected = 10.0;

            double actual = q.GetNorm ();

            Assert.AreEqual (expected, actual);
        }
    }
}