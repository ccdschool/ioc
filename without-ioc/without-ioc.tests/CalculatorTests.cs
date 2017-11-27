using System.IO;
using NUnit.Framework;
using without_ioc.domain;

namespace without_ioc.tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [SetUp]
        public void Setup() {
            Directory.SetCurrentDirectory(TestContext.CurrentContext.TestDirectory);
        }
        
        [Test]
        public void Adds_three_values() {
            var sut = new Calculator();    
            var result = sut.Sum("3", "4", "42");
            Assert.That(result, Is.EqualTo(49));
        }
    }
}