using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        // public string Index() => "Index";

        public IActionResult Index()
        {
            // await HttpContext.Response.WriteAsync("<h1>Index</h1>");
            return base.Redirect("https://csharp.christiannagel.com");
        }

        public IActionResult About()
        {
            return View("MyAbout");
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int AnotherAction(int id)
        {
            return id + 39;
        }

        public IActionResult UseMyLayout()
        {
            return View();
        }
    }
}
