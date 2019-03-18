using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class OneThousandDigitFibonacciNumberTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 3;
            int expected = 12;

            //Act
            var res = OneThousandDigitFibonacciNumber.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 1000;
            int expected = 4782;

            //Act
            var res = OneThousandDigitFibonacciNumber.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
