using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETCoreMVCApp.Services
{
    public class GreetingService : IGreetingService
    {
        public string Hello(string name) => $"Hello, {name}";
    }
}
