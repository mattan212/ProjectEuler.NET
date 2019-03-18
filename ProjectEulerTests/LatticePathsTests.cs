using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class LatticePathsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 2;
            int expected = 6;

            //Act
            var res = LatticePaths.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 3;
            int expected = 20;

            //Act
            var res = LatticePaths.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int n = 20;
            long expected = 137846528820;

            //Act
            var res = LatticePaths.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
