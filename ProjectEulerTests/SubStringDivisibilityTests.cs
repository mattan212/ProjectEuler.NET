using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class SubStringDivisibilityTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            long expected = 16695334890;

            //Act
            var res = SubStringDivisibility.Solve();

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
