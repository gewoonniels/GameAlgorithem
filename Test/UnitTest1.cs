using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteeringCS;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Normalize()
        {
            Vector2D normalizeVector = new Vector2D(4,5);
            Vector2D result = new Vector2D(0.62, 0.78);

            normalizeVector = normalizeVector.Normalize();

            Assert.AreEqual(normalizeVector, result);

        }

        [TestMethod]
        public void Divide()
        {
            Vector2D normalizeVector = new Vector2D(4, 5);
            Vector2D result = new Vector2D(0.62, 0.78);

            normalizeVector = normalizeVector.divide(6.403);

            Assert.AreEqual(normalizeVector, result);

        }
    }
}
