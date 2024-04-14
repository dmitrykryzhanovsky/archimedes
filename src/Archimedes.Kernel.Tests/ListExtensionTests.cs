using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class ListExtensionTests
    {
        [TestMethod ()]
        public void EqualsTest_NotEqualLength ()
        {
            List<int> collection1 = new List<int> { 42, 73 };
            List<int> collection2 = new List<int> { 42, 73, 112 };

            bool expected = false;

            bool actual = ListExtension.Equals (collection1, collection2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualLength_NotEqualItems ()
        {
            List<int> collection1 = new List<int> { 2, 3, 5 };
            List<int> collection2 = new List<int> { 2, 3, 6 };

            bool expected = false;

            bool actual = ListExtension.Equals (collection1, collection2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void EqualsTest_EqualLength_EqualItems ()
        {
            List<int> collection1 = new List<int> { 2, 3, 5 };
            List<int> collection2 = new List<int> { 2, 3, 5 };

            bool expected = true;

            bool actual = ListExtension.Equals (collection1, collection2);

            Assert.AreEqual (expected, actual);
        }

        [TestMethod ()]
        public void AddTest ()
        {
            List<int> collection1 = new List<int> { 2, 3,  5,  8, 13,  21 };
            List<int> collection2 = new List<int> { 4, 7, 10, 15, 52, 102 };

            List<int> expected = new List<int> { 6, 10, 15, 23, 65, 123 };

            List<int> actual = collection1.Add (collection2);

            Assert.AreEqual (true, ListExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void AddToTest ()
        {
            List<int> collection1 = new List<int> { 2, 3,  5,  8, 13,  21 };
            List<int> collection2 = new List<int> { 4, 7, 10, 15, 52, 102 };

            List<int> expected = new List<int> { 6, 10, 15, 23, 65, 123 };

            collection1.AddTo (collection2);

            Assert.AreEqual (true, ListExtension.Equals (expected, collection1));
        }

        [TestMethod ()]
        public void SubtractTest ()
        {
            List<int> collection1 = new List<int> { 2, 3,  5,  8, 13,  21 };
            List<int> collection2 = new List<int> { 4, 7, 10, 15, 52, 102 };

            List<int> expected = new List<int> { -2, -4, -5, -7, -39, -81 };

            List<int> actual = collection1.Subtract (collection2);

            Assert.AreEqual (true, ListExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void SubtractToTest ()
        {
            List<int> collection1 = new List<int> { 2, 3,  5,  8, 13,  21 };
            List<int> collection2 = new List<int> { 4, 7, 10, 15, 52, 102 };

            List<int> expected = new List<int> { -2, -4, -5, -7, -39, -81 };

            collection1.SubtractTo (collection2);

            Assert.AreEqual (true, ListExtension.Equals (expected, collection1));
        }

        [TestMethod ()]
        public void NegateTest ()
        {
            List<int> collection = new List<int> { 2, 3, 5, 8, 13, 21 };

            List<int> expected = new List<int> { -2, -3, -5, -8, -13, -21 };

            List<int> actual = collection.Negate ();

            Assert.AreEqual (true, ListExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void NegateToTest ()
        {
            List<int> collection = new List<int> { 2, 3, 5, 8, 13, 21 };

            List<int> expected = new List<int> { -2, -3, -5, -8, -13, -21 };

            collection.NegateTo ();

            Assert.AreEqual (true, ListExtension.Equals (expected, collection));
        }

        [TestMethod ()]
        public void MultiplyTest ()
        {
            List<int> collection  = new List<int> { 2, 3, 5, 8, 13, 21 };
            int       coefficient = 3;

            List<int> expected = new List<int> { 6, 9, 15, 24, 39, 63 };

            List<int> actual = collection.Multiply (coefficient);

            Assert.AreEqual (true, ListExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void MultiplyToTest ()
        {
            List<int> collection  = new List<int> { 2, 3, 5, 8, 13, 21 };
            int       coefficient = 3;

            List<int> expected = new List<int> { 6, 9, 15, 24, 39, 63 };

            collection.MultiplyTo (coefficient);

            Assert.AreEqual (true, ListExtension.Equals (expected, collection));
        }

        [TestMethod ()]
        public void DivideTest ()
        {
            List<int> collection  = new List<int> { 2, 3, 5, 8, 13, 21 };
            int       coefficient = 5;

            List<int> expected = new List<int> { 0, 0, 1, 1, 2, 4 };

            List<int> actual = collection.Divide (coefficient);

            Assert.AreEqual (true, ListExtension.Equals (expected, actual));
        }

        [TestMethod ()]
        public void DivideToTest ()
        {
            List<int> collection  = new List<int> { 2, 3, 5, 8, 13, 21 };
            int       coefficient = 5;

            List<int> expected = new List<int> { 0, 0, 1, 1, 2, 4 };

            collection.DivideTo (coefficient);

            Assert.AreEqual (true, ListExtension.Equals (expected, collection));
        }

        [TestMethod ()]
        public void InnerProductTest ()
        {
            List<int> collection1 = new List<int> { 2, 3,  5,  8, 13,  21 };
            List<int> collection2 = new List<int> { 4, 7, 10, 15, 52, 102 };

            int expected = 3017;

            int actual = collection1.InnerProduct (collection2);

            Assert.AreEqual (true, ListExtension.Equals (expected, actual));
        }
    }
}