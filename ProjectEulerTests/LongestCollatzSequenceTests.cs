using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class LongestCollatzSequenceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 10;
            int expected = 9;

            //Act
            var res = LongestCollatzSequence.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 1_000_000;
            int expected = 837799;

            //Act
            var res = LongestCollatzSequence.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
