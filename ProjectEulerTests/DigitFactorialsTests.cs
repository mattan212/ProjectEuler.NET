using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class DigitFactorialsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int expected = 40730;

            //Act
            var res = DigitFactorials.Solve();

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
