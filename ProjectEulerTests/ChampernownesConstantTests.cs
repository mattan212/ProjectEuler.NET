using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class ChampernownesConstantTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var n = new List<int> { 12 };
            int expected = 1;

            //Act
            var res = ChampernownesConstant.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var n = new List<int> { 1, 10, 100, 1000, 10000, 100000, 1000000 };
            int expected = 210;

            //Act
            var res = ChampernownesConstant.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
