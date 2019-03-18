using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class LargestPalindromeProductTests
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 2;
            int expected = 9009;

            //Act
            var res = LargestPalindromeProduct.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 3;
            int expected = 906609;

            //Act
            var res = LargestPalindromeProduct.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
