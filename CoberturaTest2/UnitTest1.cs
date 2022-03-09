using NUnit.Framework;

namespace CoberturaTest2
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
            //var c = new ClassLibrary1.Class1();
            //c.Covered2();
            new ClassLibrary2.Class2().Method();
        }

        //[Test]
        //public void CoverUncover()
        //{
        //    //var c = new ClassLibrary1.Class1();
        //    //c.Uncovered();
        //}
    }
}