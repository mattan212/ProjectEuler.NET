using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class LargestProductInSeriesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 4;
            int expected = 5832;

            //Act
            var res = LargestProductInSeries.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 13;
            long expected = 23514624000;

            //Act
            var res = LargestProductInSeries.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
