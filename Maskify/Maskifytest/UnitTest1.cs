using NUnit.Framework;

namespace Maskify
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
            Assert.AreEqual("####4321",Kata.Maskify("87654321"));
            Assert.AreEqual("1", Kata.Maskify("1")); 
            Assert.AreEqual("#####5678", Kata.Maskify("1#2345678"));
            Assert.AreEqual("",Kata.Maskify(""));
            
        }

    }
}