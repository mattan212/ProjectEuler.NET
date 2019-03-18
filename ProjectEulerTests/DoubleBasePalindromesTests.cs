using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class DoubleBasePalindromesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 1_000_000;
            int expected = 872187;

            //Act
            var res = DoubleBasePalindromes.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
