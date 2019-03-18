using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class PrimeDigitReplacementsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int size = 7;
            int digits = 5;
            var expected = 56003;

            //Act
            var res = PrimeDigitReplacements.Solve(digits, size);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int size = 8;
            int digits = 6;
            var expected = 121313;

            //Act
            var res = PrimeDigitReplacements.Solve(digits, size);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
