using Archimedes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ArrayExtensionTests
    {
        [TestMethod ()]
        public void EqualsTest_EqualItems ()
        {
            double [] array1 = new double [] { 2, 3, 5, 8, 13, 21 };
            double [] array2 = new double [] { 2, 3, 5, 8, 13, 21 };

            Assert.AreEqual (true, ArrayExtension.Equals (array1, array2));
        }

        [TestMethod ()]
        public void EqualsTest_NotEqualItems ()
        {
            double [] array1 = new double [] { 2, 3, 5, 8, 13, 21 };
            double [] array2 = new double [] { 2, 4, 8, 16, 32, 64 };

            Assert.AreEqual (false, ArrayExtension.Equals (array1, array2));
        }

        [TestMethod ()]
        public void EqualsFourItemsTest_EqualItems ()
        {
            double [] array1 = new double [] { 2, 3, 5, 8 };
            double [] array2 = new double [] { 2, 3, 5, 8 };

            Assert.AreEqual (true, array1.EqualsFourItems (array2));
        }

        [TestMethod ()]
        public void EqualsFourItemsTest_NotEqualItems ()
        {
            double [] array1 = new double [] { 2, 3, 5, 8 };
            double [] array2 = new double [] { 2, 4, 8, 16 };

            Assert.AreEqual (false, array1.EqualsFourItems (array2));
        }

        [TestMethod ()]
        public void EqualsNineItemsTest_EqualItems ()
        {
            double [] array1 = new double [] { 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            double [] array2 = new double [] { 2, 3, 5, 8, 13, 21, 34, 55, 89 };

            Assert.AreEqual (true, array1.EqualsNineItems (array2));
        }

        [TestMethod ()]
        public void EqualsNineItemsTest_NotEqualItems ()
        {
            double [] array1 = new double [] { 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            double [] array2 = new double [] { 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            Assert.AreEqual (false, array1.EqualsNineItems (array2));
        }

        [TestMethod ()]
        public void AddTest ()
        {
            double [] array1 = new double [] { 2, 3, 5, 8, 13 };
            double [] array2 = new double [] { 2, 4, 8, 16, 32 };

            double [] sum = new double [array1.Length];

            sum.Add (array1, array2);

            Assert.AreEqual (4, sum [0]);
            Assert.AreEqual (7, sum [1]);
            Assert.AreEqual (13, sum [2]);
            Assert.AreEqual (24, sum [3]);
            Assert.AreEqual (45, sum [4]);
        }

        [TestMethod ()]
        public void SubtractTest ()
        {
            double [] array1 = new double [] { 2, 3, 5, 8, 13 };
            double [] array2 = new double [] { 2, 4, 8, 16, 32 };

            double [] difference = new double [array1.Length];

            difference.Subtract (array1, array2);

            Assert.AreEqual (0, difference [0]);
            Assert.AreEqual (-1, difference [1]);
            Assert.AreEqual (-3, difference [2]);
            Assert.AreEqual (-8, difference [3]);
            Assert.AreEqual (-19, difference [4]);
        }

        [TestMethod ()]
        public void NegateTest ()
        {
            double [] array = new double [] { 2, 3, 5, 8, 13 };

            double [] negation = new double [array.Length];

            negation.Negate (array);

            Assert.AreEqual (-2, negation [0]);
            Assert.AreEqual (-3, negation [1]);
            Assert.AreEqual (-5, negation [2]);
            Assert.AreEqual (-8, negation [3]);
            Assert.AreEqual (-13, negation [4]);
        }

        [TestMethod ()]
        public void MultiplyTest ()
        {
            double [] array = new double [] { 2, 3, 5, 8, 13 };
            double coefficient = 42;

            double [] product = new double [array.Length];

            product.Multiply (array, coefficient);

            Assert.AreEqual (84, product [0]);
            Assert.AreEqual (126, product [1]);
            Assert.AreEqual (210, product [2]);
            Assert.AreEqual (336, product [3]);
            Assert.AreEqual (546, product [4]);
        }

        [TestMethod ()]
        public void DivideTest ()
        {
            double [] array = new double [] { 2, 3, 5, 8, 13 };
            double coefficient = 60;

            double [] quotient = new double [array.Length];

            quotient.Divide (array, coefficient);

            Assert.AreEqual (0.03333333333333333, quotient [0]);
            Assert.AreEqual (0.05, quotient [1]);
            Assert.AreEqual (0.08333333333333333, quotient [2]);
            Assert.AreEqual (0.13333333333333333, quotient [3]);
            Assert.AreEqual (0.21666666666666667, quotient [4]);
        }

        [TestMethod ()]
        public void InnerProductTest ()
        {
            double [] array1 = new double [] { 2, 3, 5, 8, 13 };
            double [] array2 = new double [] { 2, 3, 5, 7, 11 };

            double innerProduct = array1.InnerProduct (array2);

            Assert.AreEqual (237, innerProduct);
        }
    }
}