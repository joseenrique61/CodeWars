using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars;

namespace CodeWars.Tests
{
    internal class HighAndLowTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", HighAndLow.Excercise("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("3 1", HighAndLow.Excercise("1 2 3"));
        }
    }
}
