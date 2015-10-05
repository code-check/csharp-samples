using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest.src
{
    [TestFixture]
    public class SumTest : Sum
    {
        [Test]
        public void IsCorrect()
        {
            Assert.AreEqual(Sum1(), 499500);
            Assert.AreEqual(Sum2(), 250000);
            Assert.AreEqual(Sum3(), 255500);
            Assert.AreEqual(Sum4(), 260);
            Assert.AreEqual(Sum5(), 392107500);
        }
    }
}
