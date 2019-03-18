using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class _10001stPrimeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 6;
            int expected = 13;

            //Act
            var res = _10001stPrime.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 10001;
            int expected = 104743;

            //Act
            var res = _10001stPrime.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
