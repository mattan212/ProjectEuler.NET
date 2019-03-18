using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class SummationOfPrimesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 10;
            int expected = 17;

            //Act
            var res = SummationOfPrimes.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 2_000_000;
            long expected = 142913828922;

            //Act
            var res = SummationOfPrimes.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
