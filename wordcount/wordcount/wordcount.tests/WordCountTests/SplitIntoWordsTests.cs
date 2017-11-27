using NUnit.Framework;

namespace wordcount.tests.WordCountTests
{
    [TestFixture]
    public class SplitIntoWordsTests
    {
        [Test]
        public void Some_words_separated_by_blanks() {
            var result = new WordCount().SplitIntoWords("a b c d e");
            Assert.That(result, Is.EqualTo(new[]{"a", "b", "c", "d", "e"}));
        }

        [Test]
        public void Two_words_separated_by_a_blank() {
            var result = new WordCount().SplitIntoWords("a b");
            Assert.That(result, Is.EqualTo(new[]{"a", "b"}));
        }

        [Test]
        public void Two_words_separated_by_multipls_blanks() {
            var result = new WordCount().SplitIntoWords("a       b");
            Assert.That(result, Is.EqualTo(new[]{"a", "b"}));
        }
    }
}