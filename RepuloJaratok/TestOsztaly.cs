using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepuloJaratok
{
    [TestFixture]
    class TestOsztaly
    {
        Class1 c;

        [SetUp]
        public void Setup()
        {
            c = new Class1();
        }

        [Test]
        public void UjJarat()
        {
            c.UjJarat("Első járat", "Belgium", "Róma", DateTime.Now);
            c.UjJarat("Masodik járat", "Róma", "Budapest", DateTime.Now);
            Assert.AreEqual(0, c.MikorIndul("Első járat"));
        }

    }
}
