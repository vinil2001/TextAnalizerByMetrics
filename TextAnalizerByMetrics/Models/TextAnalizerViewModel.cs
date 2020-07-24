using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextAnalizerByMetrics.Models
{
    public class TextAnalizerViewModel
    {
        public List<IMetric> Metrics { get; set; }
        public string InputText { get; set; }

    }
}
