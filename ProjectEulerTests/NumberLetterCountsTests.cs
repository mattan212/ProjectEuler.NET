using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerNet;

namespace ProjectEulerTests
{
    [TestClass]
    public class NumberLetterCountsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 5;
            int expected = 19;

            //Act
            var res = NumberLetterCounts.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 1000;
            int expected = 21124;

            //Act
            var res = NumberLetterCounts.Solve(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestStringify()
        {
            var dict = new Dictionary<int, int>
            {
                {1, 3},
                {2, 3},
                {3, 5},
                {4, 4},
                {5, 4},
                {6, 3},
                {7, 5},
                {8, 5},
                {9, 4},
                {10, 3},
                {11, 6},
                {12, 6},
                {13, 8},
                {14, 8},
                {15, 7},
                {16, 7},
                {17, 9},
                {18, 8},//eighteen
                {19, 8},
                {20, 6},
                {21, 9},
                {32, 9},
                {43, 10},
                {54, 9},
                {65, 9},
                {76, 10},
                {87, 11},
                {98, 11},
                {100, 10},
                {101, 13 + 3},
                {115, 13 + 7},
                {164, 13 + 9},
                {181, 13 + 6 + 3},
                {212, 13 + 6},
                {250, 13 + 5},
                {287, 13 + 6 + 5},
                {320, 15 + 6},
                {342, 23},
                {400, 4 + 7},
                {499, 14 + 6 + 4},
                {513, 4 + 7 + 3 + 8},
                {1000, 3 + 8},
            };

            //Act
            foreach (var entry in dict)
            {
                var res = NumberLetterCounts.Stringify(entry.Key);

                //Assert
                Assert.AreEqual(entry.Value, res, $"Testing {entry.Key}. Expected: <{entry.Value}>. Actual: <{res}>");
            }
        }
    }
}
