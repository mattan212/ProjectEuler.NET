using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class TriangularPentagonalAndHexagonalTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 2;
            int expected = 40755;

            //Act
            var res = TriangularPentagonalAndHexagonal.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 3;
            int expected = 1533776805;

            //Act
            var res = TriangularPentagonalAndHexagonal.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
