using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class MultiplesOf3And5Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 10;
            int expected = 23;

            //Act
            var res = MultiplesOf3And5.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 1000;
            int expected = 233168;

            //Act
            var res = MultiplesOf3And5.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
