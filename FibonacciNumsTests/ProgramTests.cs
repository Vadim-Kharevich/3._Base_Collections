using NUnit.Framework;
using FibonacciNums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNums.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [TestCase(1, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(8, 5)]
        [TestCase(21, 7)]
        public void FibonacciNumsTest(int expected,int param)
        {
            Assert.AreEqual(expected,Program.FibonacciNums(param));
        }
    }
}