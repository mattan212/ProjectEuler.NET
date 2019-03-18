using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet.Helpers;

namespace ProjectEulerTests.ExtensionMethodsTests
{
    [TestClass]
    public class MultiplyStringTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var a = "3";
            var b = 6;
            var expected = "18";

            //Act
            var res = a.Multiply(b);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var a = "12";
            var b = 10;
            var expected = "120";

            //Act
            var res = a.Multiply(b);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var a = "123";
            var b = 2349;
            var expected = "288927";

            //Act
            var res = a.Multiply(b);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
