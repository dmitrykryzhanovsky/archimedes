using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace Archimedes.Tests
{
    [TestClass ()]
    public class TrigonometryTests
    {
        [TestMethod ()]
        public void DegToRadTest ()
        {
            double deg = 60.0;

            Assert.AreEqual (Math.PI / 3.0, Trigonometry.DegToRad (deg));
        }

        [TestMethod ()]
        public void SecToRadTest ()
        {
            double sec = 216000.0;

            Assert.AreEqual (Math.PI / 3.0, Trigonometry.SecToRad (sec));
        }
    }
}