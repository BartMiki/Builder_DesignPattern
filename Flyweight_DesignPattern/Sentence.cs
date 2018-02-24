using System.Collections.Generic;

namespace Flyweight_DesignPattern
{
    public class Sentence
    {
        private List<string> words;
        private List<WordToken> wordTokens;

        public Sentence(string plainText)
        {
            words = new List<string>(plainText.Split(' '));
            wordTokens = new List<WordToken>();
        }

        public WordToken this[int index]
        {
            get
            {
                var wordToken = wordTokens.Find(token => token.Index == index);
                if (wordToken != null)
                {
                    return wordToken;
                }
                wordToken = new WordToken();
                wordToken.Index = index;
                wordTokens.Add(wordToken);
                return wordToken;
            }
        }

        public override string ToString()
        {
            for (var index = 0; index < words.Count; index++)
            {
                foreach (var token in wordTokens)
                {
                    if (token.Index == index && token.Capitalize)
                    {
                        words[index] = words[index].ToUpper();
                    }
                }
            }
            return string.Join(" ", words);
        }

        public class WordToken
        {
            public bool Capitalize;
            public int Index;
        }
    }
}