using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class ReciprocalCyclesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 10;
            int expected = 7;

            //Act
            var res = ReciprocalCycles.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }


        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 1000;
            int expected = 983;

            //Act
            var res = ReciprocalCycles.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
