using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextAnalizerByMetrics.Models
{
    public class WordsAmount : IMetric
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, int> MetricValues { get; set; }   // данные метрики   
    }
}
