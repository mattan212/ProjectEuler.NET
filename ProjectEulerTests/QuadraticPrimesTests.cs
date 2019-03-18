using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class QuadraticPrimesTests
    {
        [TestMethod]
        public void TestMethod0()
        {
            //Arrange
            int a = 1;
            int b = 41;

            //Act
            var res = QuadraticPrimes.ConsecutivePrimeNumbers(a, b);

            //Assert
            Assert.AreEqual(40, res);
        }

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 41;
            int expected = -41;

            //Act
            var res = QuadraticPrimes.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }


        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 1000;
            int expected = -59231;

            //Act
            var res = QuadraticPrimes.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
