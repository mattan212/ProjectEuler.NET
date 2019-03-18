using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class SelfPowersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 10;
            var expected = 405071317;

            //Act
            var res = SelfPowers.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 1000;
            var expected = 9110846700;

            //Act
            var res = SelfPowers.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

    }
}
