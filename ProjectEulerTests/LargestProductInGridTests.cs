using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class LargestProductInGridTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 4;
            int expected = 70600674;

            //Act
            var res = LargestProductInGrid.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
