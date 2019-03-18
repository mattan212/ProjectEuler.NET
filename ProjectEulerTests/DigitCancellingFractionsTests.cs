using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class DigitCancellingFractionsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 2;
            var expected = 100;

            //Act
            var res = DigitCancellingFractions.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
