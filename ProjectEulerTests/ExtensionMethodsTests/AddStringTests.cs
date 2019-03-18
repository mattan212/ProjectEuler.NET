using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet.Helpers;

namespace ProjectEulerTests.ExtensionMethodsTests
{
    [TestClass]
    public class AddStringTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var a = "123";
            var b = "2349";
            var expected = "2472";

            //Act
            var res = a.Add(b);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var a = "99";
            var b = "99";
            var expected = "198";

            //Act
            var res = a.Add(b);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var a = "999";
            var b = "9";
            var expected = "1008";

            //Act
            var res = a.Add(b);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
