using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class DistinctPrimesFactorsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 2;
            int expected = 14;

            //Act
            var res = DistinctPrimesFactors.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 3;
            int expected = 644;

            //Act
            var res = DistinctPrimesFactors.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int n = 4;
            int expected = 134043;

            //Act
            var res = DistinctPrimesFactors.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
