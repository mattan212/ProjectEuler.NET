using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class SpecialPythagoreanTripletTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 12;
            int expected = 60;

            //Act
            var res = SpecialPythagoreanTriplet.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 1000;
            int expected = 31875000;

            //Act
            var res = SpecialPythagoreanTriplet.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
