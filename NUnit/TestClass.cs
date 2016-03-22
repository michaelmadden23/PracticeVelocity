using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit
{
    [TestFixture]
    public class TestClass
    {
        [TestCase]
        public void AddTest()
        {
            int result = 20 + 30;
            Assert.AreEqual(30, result);
        }

        [TestCase]
        public void SubtractTest()
        {
            int result = 25 - 10;
            Assert.AreEqual(10, result);
        }
    }
}
