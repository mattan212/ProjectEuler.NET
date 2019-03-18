using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class LargestPrimeFactorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var n = 100;
            var expected = 5;

            //Act
            var res = LargestPrimeFactor.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var n = 600851475143;
            var expected = 6857;

            //Act
            var res = LargestPrimeFactor.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
