using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerSharp.Tests
{
    [TestClass]
    public class ThreesAndFivesTest
    {
        [TestMethod]
        public void Test_find_sum()
        {
            var input = 10;
            var output = EulerSharp.ThreesAndFives.find_sum(below_integer: input);
            Assert.AreEqual(output, 0);
        }
        [TestMethod]
        public void Test_find_sum_list()
        {
            var number_to_multiple = 3;
            var below_integer = 10;
            var output = EulerSharp.ThreesAndFives.sum_of_list(number_to_multiple: number_to_multiple, below_integer: below_integer);
            Assert.AreEqual(output, 3 + 6 + 9);
        }
    }
}
