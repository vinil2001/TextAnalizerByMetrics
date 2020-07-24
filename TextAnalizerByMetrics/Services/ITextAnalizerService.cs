using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextAnalizerByMetrics.Models;

namespace TextAnalizerByMetrics.Services
{
    public interface ITextAnalizerService
    {
        public IMetric GetMetrics(string inputText);
    }
}
