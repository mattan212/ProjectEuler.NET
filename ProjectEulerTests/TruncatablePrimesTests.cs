using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class TruncatablePrimesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 1_000_000;
            int expected = 748317;

            //Act
            var res = TruncatablePrimes.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
