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
            var sut = new NowFormatter(()=>DateTime.Parse("2015-12-04 09:15"));

            Assert.That(sut.ToString(), Is.EqualTo("09:15"));
        }
    }

    public class NowFormatter
    {
        private readonly Func<DateTime> now;

        public NowFormatter(Func<DateTime> now )
        {
            this.now = now;
        }

        public override string ToString()
        {
            return now().ToString("hh:mm");
        }
    }
}
