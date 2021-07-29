using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecretTest.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SecretTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LineBotConfig _lineBotConfig;

        public HomeController(ILogger<HomeController> logger, LineBotConfig lineBotConfig)
        {
            _logger = logger;
            _lineBotConfig = lineBotConfig;
        }

        public IActionResult Index()
        {
            string a = _lineBotConfig.Channel_access_token;
            ViewBag.KK = a;
            return View();
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
