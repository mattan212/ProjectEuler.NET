using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class ConsecutivePrimeSumTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 1000;
            int expected = 953;

            //Act
            var res = ConsecutivePrimeSum.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 1_000_000;
            int expected = 997651;

            //Act
            var res = ConsecutivePrimeSum.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
