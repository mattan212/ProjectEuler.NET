using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class LexicographicPermutationsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var n = 3;
            var index = 3;
            var expected = "120";

            //Act
            var res = LexicographicPermutations.Solve(n, index);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var n = 10;
            var index = 1_000_000 - 1;
            var expected = "2783915460";

            //Act
            var res = LexicographicPermutations.Solve(n, index);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
