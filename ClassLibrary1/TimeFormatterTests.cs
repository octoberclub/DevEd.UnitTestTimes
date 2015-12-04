using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]

    public class TestClockDisplaysTests
    {
        [Test]
        public void TestClockDisplaysNow()
        {
            var sut = new NowFormatter();

            Assert.That(sut.ToString(), Is.EqualTo("09:15"));
        }
    }

    public class NowFormatter
    {
        public override string ToString()
        {
            return DateTime.Now.ToString("hh:mm");
        }
    }
}
