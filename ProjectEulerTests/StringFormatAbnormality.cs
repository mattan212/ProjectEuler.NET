using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEulerTests
{
    [TestClass]
    class StringFormatAbnormality
    {
        [TestMethod]
        public void Test1()
        {
            var testingEndpoints = new string[] { "https://endpoint1.com", "https://endpoint1.com" };

            var str = testingEndpoints + "/api/Account";

            Assert.AreEqual("System.String[]/api/Account", str);
            Assert.AreNotEqual("https://endpoint1.com/api/Account", str);
        }

        [TestMethod]
        public void Test2()
        {
            var testingEndpoints = new string[] { "https://endpoint1.com", "https://endpoint1.com" };

            var str = string.Format("{0}/api/Account", testingEndpoints);

            Assert.AreEqual("System.String[]/api/Account", str);
            Assert.AreNotEqual("https://endpoint1.com/api/Account", str);
        }

        [TestMethod]
        public void Test3()
        {
            var testingEndpoints = new string[] { "https://endpoint1.com", "https://endpoint1.com" };

            var str = $"{testingEndpoints}/api/Account";

            Assert.AreEqual("System.String[]/api/Account", str);
            Assert.AreNotEqual("https://endpoint1.com/api/Account", str);
        }

        [TestMethod]
        public void Test4()
        {
            var testingEndpoints = new List<string> { "https://endpoint1.com", "https://endpoint1.com" };

            var str = string.Format("{0}/api/Account", testingEndpoints);

            Assert.AreEqual("System.Collections.Generic.List`1[System.String]/api/Account", str);
            Assert.AreNotEqual("https://endpoint1.com/api/Account", str);
        }

        [TestMethod]
        public void Test5()
        {
            var testingEndpoints = new string[] { };

            var str = string.Format("{0}/api/Account", testingEndpoints);

            Assert.AreEqual("System.String[]/api/Account", str);
            Assert.AreNotEqual("https://endpoint1.com/api/Account", str);
        }

        [TestMethod]
        public void Test6()
        {
            var testingEndpoints = new int[] { 1, 2, 3 };

            var str = string.Format("{0}/api/Account", testingEndpoints);

            Assert.AreEqual("System.Int32[]//api/Account", str);
            Assert.AreNotEqual("https://endpoint1.com/api/Account", str);
        }

        [TestMethod]
        public void Test7()
        {
            object testingEndpoints = new string[] { "https://endpoint1.com", "https://endpoint1.com" };

            var str = string.Format("{0}/api/Account", testingEndpoints);

            Assert.AreEqual("System.Int32[]//api/Account", str);
            Assert.AreNotEqual("https://endpoint1.com/api/Account", str);
        }

        [TestMethod]
        public void Test8()
        {
            var testingEndpoints = new object[] { 1, 2 };

            var str = string.Format("{0}/api/Account", testingEndpoints);

            Assert.AreEqual("System.object[]//api/Account", str);
            Assert.AreNotEqual("https://endpoint1.com/api/Account", str);
        }

        [TestMethod]
        public void Test9()
        {
            var testingEndpoints = new object[] { new Func<string>(() => "endpoint"), "2" };

            var str = string.Format("{0}/api/Account", testingEndpoints);

            Assert.AreEqual("1/api/Account", str);
            Assert.AreNotEqual("https://endpoint1.com/api/Account", str);
        }
    }
}
