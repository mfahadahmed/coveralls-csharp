using Coveralls_Net_Standard;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        private TestClass TestObj;

        [SetUp]
        public void Setup()
        {
            TestObj = new TestClass();
        }

        [Test]
        public void Test1()
        {
            Assert.Throws<NotImplementedException>(() => TestObj.IsValid());
        }
    }
}