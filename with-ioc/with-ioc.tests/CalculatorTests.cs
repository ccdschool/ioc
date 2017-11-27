using System.IO;
using Moq;
using NUnit.Framework;
using with_ioc.domain;
using with_ioc.provider;

namespace with_ioc.tests
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
            var sut = new Calculator(new Protokoll(), new ValueProvider());    
            var result = sut.Sum("3", "4");
            Assert.That(result, Is.EqualTo(49));
        }

        [Test]
        public void Gets_third_value_from_file() {
            var valueProvider = new Mock<ValueProvider>();
            var sut = new Calculator(new Protokoll(), valueProvider.Object);

            valueProvider.Setup(x => x.ReadZ()).Returns(10);
            var result = sut.Sum("3", "4");
            
            Assert.That(result, Is.EqualTo(17));
        }

        [Test]
        public void Protocol_will_be_written() {
            var protokoll = new Mock<Protokoll>();
            var sut = new Calculator(protokoll.Object, new ValueProvider());    
            
            protokoll.Setup(x => x.Log("3", "4", 42, 49)).Verifiable();
            sut.Sum("3", "4");
            
            protokoll.Verify();
        }
    }
}