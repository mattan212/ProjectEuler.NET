using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerTests.ExtensionMethodsTests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class PowTests
    {
        [TestMethod]
        public void MyTestMethod()
        {
            //arrange
            var a = "5";
            var b = 3;

            //Act
            var res = a.Pow(b);

            //Arrange
            Assert.AreEqual("125", res);
        }

    }
}
