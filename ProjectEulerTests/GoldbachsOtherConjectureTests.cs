using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class GoldbachsOtherConjectureTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int end = 10_000;
            int expected = 5777;

            //Act
            var res = GoldbachsOtherConjecture.Solve(end);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
