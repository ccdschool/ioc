using NUnit.Framework;

namespace wordcount.tests.WordCountTests
{
    [TestFixture]
    public class CountWordsTests
    {
        [Test]
        public void One_word() {
            var result = new WordCount().CountWords(new[]{"a"});
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Some_worde() {
            var result = new WordCount().CountWords(new[]{"a", "a", "a"});
            Assert.That(result, Is.EqualTo(3));
        }
    }
}