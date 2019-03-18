using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class PandigitalMultiplesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int expected = 932718654;

            //Act
            var res = PandigitalMultiples.Solve();

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
