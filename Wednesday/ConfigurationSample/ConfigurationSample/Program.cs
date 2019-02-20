using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConfigurationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration = SetupConfiguration(args);
            ReadConfiguration();
        }

        private static void ReadConfiguration()
        {
            var setting1 = Configuration["MySetting1"];
            Console.WriteLine(setting1);
            var setting2 = Configuration.GetSection("MySection1")["Setting2"];
            Console.WriteLine(setting2);
            var conn1 = Configuration.GetConnectionString("BooksConnection");
            Console.WriteLine(conn1);
        }

        private static IConfiguration SetupConfiguration(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile("appsettings.staging.json", optional: true)
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();
            return config;
        }

        public static IConfiguration Configuration { get; private set; }
    }
}
