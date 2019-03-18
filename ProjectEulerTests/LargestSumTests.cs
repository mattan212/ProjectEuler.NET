using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class LargestSumTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var testNumbers = new List<string>
            {
                "123",
                "234",
                "345",
                "456"
            };

            int n = 3;
            int expected = 115;

            //Act
            var res = LargestSum.Solve(testNumbers, n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 10;
            long expected = 5537376230;

            //Act
            var res = LargestSum.Solve(LargestSum.Numbers, n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
