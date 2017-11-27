using NUnit.Framework;

namespace wordcount.tests.WordCountTests
{
    [TestFixture]
    public class Integrationstests
    {
        [Test]
        public void Two_words_splitted_by_a_blank() {
            var result = new WordCount().CountWordsInText("a b");
            Assert.That(result, Is.EqualTo(2));
        }
    }
}