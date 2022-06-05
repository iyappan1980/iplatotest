using NUnit.Framework;
using System.IO;
using System;

namespace UnitTest
{
    public class Tests
    {
        private const string Expected = "Hello World!";

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            
            var teststring =new List<string>();
            teststring.Add("Iyappan");
            var teststrings = teststring.Find(str => str == "Iyappan");
            Assert.IsNotNull(teststrings);
            Assert.That(teststrings, Is.EqualTo("Iyappan"));
            
            
        }

        
    }
}