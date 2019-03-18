using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class SmallestMultipleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 10;
            int expected = 2520;

            //Act
            var res = SmallestMultiple.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 20;
            int expected = 232792560;

            //Act
            var res = SmallestMultiple.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
