using NUnit.Framework;
using System.Threading;

namespace CoberturaTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Thread.Sleep(10000);
            var c = new ClassLibrary1.Class1();
            c.Covered();
        }
    }
}