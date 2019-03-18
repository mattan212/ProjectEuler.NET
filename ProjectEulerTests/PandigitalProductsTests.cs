using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class PandigitalProductsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int start = 1;
            int end = 9;
            int expected = 45228;

            //Act
            var res = PandigitalProducts.Solve(end);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
