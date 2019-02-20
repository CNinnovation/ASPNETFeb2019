using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Logging;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            Container = RegisterServices();
            Run();
            Console.ReadLine();
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
            services.AddLogging(options =>
            {
                options.AddFilter(level => true);
                options.AddConsole();
                options.AddDebug();
            });
            return services.BuildServiceProvider();
        }
    }
}
