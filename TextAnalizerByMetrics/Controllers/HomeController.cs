using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TextAnalizerByMetrics.Models;
using TextAnalizerByMetrics.Services;

namespace TextAnalizerByMetrics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GetWordsAmount _getWordsAmount;

        public HomeController(ILogger<HomeController> logger, GetWordsAmount getWordsAmount)
        {
            _logger = logger;
            _getWordsAmount = getWordsAmount;
        }

        public IActionResult Index(string inputText = null)
        {
            TextAnalizerViewModel textAnalizerViewModel = new TextAnalizerViewModel();
            textAnalizerViewModel.Metrics = new List<IMetric>();
            if (inputText != null)
                textAnalizerViewModel.Metrics.Add(_getWordsAmount.GetMetrics(inputText));
            return View(textAnalizerViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
