using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class CodedTriangleNumbersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var expected = 162;

            //Act
            var res = CodedTriangleNumbers.Solve();

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
