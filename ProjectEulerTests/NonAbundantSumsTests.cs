using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class NonAbundantSumsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 28123;
            int expected = 4179871;

            //Act
            var res = NonAbundantSums.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
