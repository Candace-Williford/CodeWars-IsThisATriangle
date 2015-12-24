using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars_IsThisATriangle.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
        {
            Assert.IsTrue(Triangle.IsTriangle(5, 7, 10));
        }
    }
}
