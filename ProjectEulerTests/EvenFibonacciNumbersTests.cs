using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class EvenFibonacciNumbersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var cutoff = 100;
            var expected = 44;

            //Act
            var res = EvenFibonacciNumbers.Solve(cutoff);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var cutoff = 4_000_000;
            var expected = 4613732;

            //Act
            var res = EvenFibonacciNumbers.Solve(cutoff);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}


