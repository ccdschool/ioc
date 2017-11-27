using System.IO;
using NUnit.Framework;
using without_ioc.viewmodel;

namespace without_ioc.tests
{
    [TestFixture]
    public class IntegrationTests
    {
        [SetUp]
        public void Setup() {
            Directory.SetCurrentDirectory(TestContext.CurrentContext.TestDirectory);
        }

        [Test]
        public void Values_are_added() {
            var sut = new Interactors();
            var result = sut.Add(new AddVM {X = "1", Y = "2"});
            Assert.That(result.Sum, Is.EqualTo("45"));
        }

        [Test]
        public void Protocol_is_written_to_console() {
            using (var consoleUi = new ConsoleUi()) {
                var sut = new Interactors();
                sut.Add(new AddVM {X = "1", Y = "2"});
                Assert.That(consoleUi.Output(), Is.EqualTo(new[]{"x = 1, y = 2, z = 42, sum = 45", ""}));
            }
        }
    }
}