using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstASPNETCoreMVCApp.Models;
using MyFirstASPNETCoreMVCApp.Services;

namespace MyFirstASPNETCoreMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGreetingService _greetingService;
        private readonly ILogger _logger;
        public HomeController(IGreetingService greetingService, ILogger<HomeController> logger)
        {
            _greetingService = greetingService;
            _logger = logger;
        }

        public string Hello(string name)
        {
            _logger.LogTrace("Hello invoked with {0}", name);
            return _greetingService.Hello(name);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewBag.Message = "abc";


            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
