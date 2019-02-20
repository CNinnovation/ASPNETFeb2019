using System;
using System.Collections.Generic;
using System.Text;

namespace DISample
{
    class HomeController
    {
        private readonly IGreetingService _greetingService;
        public HomeController(IGreetingService greetingService)
        {
            _greetingService = greetingService ?? throw new ArgumentNullException(nameof(greetingService));
        }
        public string Greet(string name) => _greetingService.Hello(name);
    }
}
