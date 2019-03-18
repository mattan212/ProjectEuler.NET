using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet.Models;

namespace ProjectEulerTests.ModelsTests
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var input = @"3
7 4
2 4 6
8 5 9 3";

            //Act
            var tree = BinaryTree<int>.Parse(input, num => int.Parse(num));

            //Assert
            Assert.IsNotNull(tree);
            Assert.AreEqual(3, tree.Value);
            Assert.AreEqual(0, tree.Level);

            Assert.AreEqual(7, tree.Left.Value);
            Assert.AreEqual(1, tree.Left.Level);

            Assert.AreEqual(4, tree.Right.Value);
            Assert.AreEqual(1, tree.Right.Level);

            Assert.AreEqual(2, tree.Left.Left.Value);
            Assert.AreEqual(2, tree.Left.Right.Level);
        }
    }
}
