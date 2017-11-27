namespace wordcount
{
    internal class Program
    {
        public static void Main(string[] args) {
            var wordCount = new WordCount();
            var consoleUi = new ConsoleUi();

            var text = consoleUi.GetText();
            var numberOfWords = wordCount.CountWordsInText(text);
            consoleUi.ShowNumberOfWords(numberOfWords);
        }
    }
}