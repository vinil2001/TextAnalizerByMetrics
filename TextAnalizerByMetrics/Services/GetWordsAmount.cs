using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextAnalizerByMetrics.Models;

namespace TextAnalizerByMetrics.Services
{
    public class GetWordsAmount : ITextAnalizerService
    {
        public IMetric GetMetrics(string inputText)
        {
            WordsAmount wordsInText = new WordsAmount();
            wordsInText.MetricValues = new Dictionary<string, int>();

            char[] delimiterChars = { ' ', ',', '.', ':' };
            var orderedWords = inputText
              .Split(delimiterChars)
              .GroupBy(x => x)
              .Select(x => new
              {
                  Word = x.Key,
                  Amount = x.Count()

              })
              .OrderByDescending(x => x.Amount).ToList();

            for (int i = 0; i < orderedWords.Count(); i++)
            {
                if (orderedWords[i].Word == "")
                    orderedWords.Remove(orderedWords[i]);
                else
                {
                    wordsInText.MetricValues.Add(orderedWords[i].Word, orderedWords[i].Amount);
                }
            }
            return wordsInText;
        }
    }
}
