using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet.Helpers;

namespace ProjectEulerTests.ExtensionMethodsTests
{
    [TestClass]
    public class DivideByOneTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var n = 8;
            var expected = "0.125";

            //Act
            var res = n.DivideByOne(50);

            //Assert
            Assert.AreEqual(expected, res);
        }
    

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var n = 23;
            var expected = "0.04347826086956521739130434782608695652173913043478260869565217391304347826086956521739130434782608695";

            //Act
            var res = n.DivideByOne(100);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
