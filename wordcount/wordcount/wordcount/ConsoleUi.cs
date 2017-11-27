using System;

namespace wordcount
{
    public class ConsoleUi
    {
        public string GetText() {
            Console.Write("Enter your text: ");
            return Console.ReadLine();
        }

        public void ShowNumberOfWords(int numberOfWords) {
            var message = FormatNumberOfWords(numberOfWords);
            Console.WriteLine(message);
        }

        internal string FormatNumberOfWords(int numberOfWords) {
            return $"Number of words: {numberOfWords}";
        }
    }
}