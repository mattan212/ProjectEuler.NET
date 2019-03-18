using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class FactorialDigitSumTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 10;
            int expected = 27;

            //Act
            var res = FactorialDigitSum.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }


        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 100;
            int expected = 648;

            //Act
            var res = FactorialDigitSum.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
