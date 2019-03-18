using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class PermutedMultiplesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 2;
            int expected = 125874;

            //Act
            var res = PermutedMultiples.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 6;
            int expected = 125874;

            //Act
            var res = PermutedMultiples.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
