using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class AmicableNumbersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 10000;
            int expected = 31626;

            //Act
            var res = AmicableNumbers.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
