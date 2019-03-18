using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class PandigitalPrimeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int expected = 7652413;

            //Act
            var res = PandigitalPrime.Solve();

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
