using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class CircularPrimesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 100;
            int expected = 13;

            //Act
            var res = CircularPrimes.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 1_000_000;
            int expected = 55;

            //Act
            var res = CircularPrimes.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
