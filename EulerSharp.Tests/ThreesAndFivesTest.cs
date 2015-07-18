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
            var input = 16;
            var output = EulerSharp.ThreesAndFives.find_sum(below_integer: input);
            Assert.AreEqual(output, 60);
        }
    }
}
