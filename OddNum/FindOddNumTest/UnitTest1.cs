using NUnit.Framework;

namespace FindOddNumber
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
            Assert.AreEqual(2, Kata.Find(new []{2,2,2,4,4}));
            
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(2, Kata.Find(new []{2,2,4,4,2}));
            
        }
         [Test]
        public void Test3()
        {           
            Assert.AreEqual(5, Kata.Find(new []{20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5}));
           
        }

        [Test]
        public void Test4()
        {           
            Assert.AreEqual(-1, Kata.Find(new []{20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2}));
        }

        [Test]
        public void Test5()
        {           
            Assert.AreEqual(-1, Kata.Find(new []{2,2,4,4}));
        }

        [Test]
        public void Test6()
        {           
            Assert.AreEqual(10, Kata.Find(new []{10}));
        }
    }
}