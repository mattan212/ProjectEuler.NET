using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class CountingSundaysTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var start = new DateTime(1901, 1, 1);
            var end = new DateTime(2000, 12, 31);

            int expected = 171;

            //Act
            var res = CountingSundays.Solve(start, end);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
