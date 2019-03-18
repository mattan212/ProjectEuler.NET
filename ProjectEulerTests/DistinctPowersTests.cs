using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class DistinctPowersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var n = 5;
            var expected = 15;

            //Act
            var res = DistinctPowers.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var cutoff = 100;
            var expected = 9183;

            //Act
            var res = DistinctPowers.Solve(cutoff);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}


