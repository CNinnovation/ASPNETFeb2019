using Microsoft.Extensions.DependencyInjection;
using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            Container = RegisterServices();
            Run();
        }

        private static void Run()
        {
            // var controller = new HomeController(new GreetingService());
            var controller = Container.GetService<HomeController>();
            string result = controller.Greet("Katharina");
            Console.WriteLine(result);
        }

        public static IServiceProvider Container { get; private set; }

        public static IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IGreetingService, GreetingService>();
            services.AddTransient<HomeController>();
            return services.BuildServiceProvider();
        }
    }
}
