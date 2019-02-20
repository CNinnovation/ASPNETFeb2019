using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    class HomeController
    {
        private readonly IGreetingService _greetingService;
        private readonly ILogger _logger;
        public HomeController(IGreetingService greetingService, ILogger<HomeController> logger)
        {
            _greetingService = greetingService ?? throw new ArgumentNullException(nameof(greetingService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public string Greet(string name)
        {
            _logger.LogTrace("Greet invoked");
            _logger.LogError("Sample for an error");
            return _greetingService.Hello(name);
        }
    }
}
