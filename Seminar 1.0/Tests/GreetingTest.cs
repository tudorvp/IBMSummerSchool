using NUnit.Framework;
using Seminar1.ProductionCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1.Tests
{
    [TestFixture]
    class GreetingTest
    {
        Greeting greeting = new Greeting();

        public void ExecuteTest(string name, string expected)
        {
            //Arrange

            //Act
            string result = greeting.Greet(name);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ShouldGreetBob()
        {
            ExecuteTest("Bob","Hello, Bob.");
        }
        [Test]
        public void ShouldHandleNull()
        {

            ExecuteTest(null, "Hello, my friend.");
        }
        [Test]
        public void ShouldGreetGigi()
        {

            ExecuteTest("Gigi", "Hello, Gigi.");
        }
        [Test]
        public void ShouldHandleShouting()
        {

            ExecuteTest("JERRY", "HELLO, JERRY!");
        }

        [Test]
        public void ShouldHandleTwoNames()
        {
            //Arrange
            string[] names = { "Jill", "Jane" };

            //Act
            string result = greeting.Greet(names);
            //Assert
            Assert.AreEqual("Hello, Jill and Jane.", result);

        }
    }
}