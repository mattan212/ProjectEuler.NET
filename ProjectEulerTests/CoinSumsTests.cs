using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class CoinSumsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var targetAmount = 0.2;
            int expected = 41;

            //Act
            var res = CoinSums.Solve(0.2);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var targetAmount = 2;
            int expected = 73682;

            //Act
            var res = CoinSums.Solve(targetAmount);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
