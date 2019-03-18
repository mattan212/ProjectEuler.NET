using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class HighlyDivisibleTriangularNumberTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 6;
            int expected = 28;

            //Act
            var res = HighlyDivisibleTriangularNumber.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 500;
            int expected = 76576500;

            //Act
            var res = HighlyDivisibleTriangularNumber.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
