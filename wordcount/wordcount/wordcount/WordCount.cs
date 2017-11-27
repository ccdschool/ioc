using System;
using System.Collections.Generic;
using System.Linq;

namespace wordcount
{
    public class WordCount
    {
        public int CountWordsInText(string text) {
            var words = SplitIntoWords(text);
            var result = CountWords(words);
            return result;
        }

        internal IEnumerable<string> SplitIntoWords(string text) {
            return text.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        }

        internal int CountWords(IEnumerable<string> words) {
            return words.Count();
        }
    }
}