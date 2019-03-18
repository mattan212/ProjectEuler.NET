using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class PentagonNumbersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 10000;
            int expected = 5482660;

            //Act
            var res = PentagonNumbers.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
