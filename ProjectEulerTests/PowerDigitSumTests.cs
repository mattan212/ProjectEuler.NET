using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class PowerDigitSumTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var n = 15;
            var expected = 26;

            //Act
            var res = PowerDigitSum.Solve(15);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 1000;
            long expected = 1366;

            //Act
            var res = PowerDigitSum.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
