using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class NumberSpiralDiagonalsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 5;
            int expected = 101;

            //Act
            var res = NumberSpiralDiagonals.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 1001;
            int expected = 669171001;

            //Act
            var res = NumberSpiralDiagonals.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
