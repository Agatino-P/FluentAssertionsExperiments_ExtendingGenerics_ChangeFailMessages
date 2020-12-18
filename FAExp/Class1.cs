using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAExp
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void AssertIt()
        {
            int a = 1;
            int b = 2;
            a.Should().Be(b,"*{0}={1}*", nameof(b),b);
            a.Should().Be2(b, $"{nameof(a)}={a}, != {nameof(b)}={b}");
            a.Should().Be(b);
        }
    }
}
