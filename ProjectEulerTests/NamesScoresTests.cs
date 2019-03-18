using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class NamesScoresTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var expected = 871198282;

            //Act
            var res = NamesScores.Solve();

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
