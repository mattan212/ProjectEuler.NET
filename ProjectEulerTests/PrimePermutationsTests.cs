using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class PrimePermutationsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var n = 0;
            var expected = "148748178147";

            //Act
            var res = PrimePermutations.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var n = 1;
            var expected = "296962999629";

            //Act
            var res = PrimePermutations.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
