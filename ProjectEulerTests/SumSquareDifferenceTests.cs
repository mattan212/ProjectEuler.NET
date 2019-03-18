using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class SumSquareDifferenceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 10;
            int expected = 2640;

            //Act
            var res = SumSquareDifference.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 100;
            int expected = 25164150;

            //Act
            var res = SumSquareDifference.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
