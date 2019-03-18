using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class DigitFifthPowersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 4;
            int expected = 19316;

            //Act
            var res = DigitFifthPowers.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 5;
            int expected = 443839;

            //Act
            var res = DigitFifthPowers.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
