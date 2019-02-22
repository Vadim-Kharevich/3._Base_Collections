using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciNums;

namespace FibonacciNumsTest
{
    [TestClass]
    public class FibonacciNumsTest
    {
        [TestMethod]
        public void FibonacciNumsProcedureTest()
        {
            //Arrange
            int expected = 1;

            //Act
            Assert.AreEqual(expected, Program.FibonacciNums(1));
        }
    }
}
