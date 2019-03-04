using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // MyRunnerAsync().Wait();
            await MyRunnerAsync();
            Console.WriteLine("Main completed");
        }

        static async Task MyAdvancedRunnerAsync()
        {
            Task<string> t1 = GreetingAsync("Katharina", 3000);
            Task<string> t2 = GreetingAsync("Stephanie", 2000);
            await Task.WhenAll(t1, t2);

        }

        static async Task MyRunnerAsync()
        {
            string result = await GreetingAsync("Katharina", 3000);
            Console.WriteLine(result);
            Console.WriteLine("MyRunner completed");

            //Task<string> t1 = GreetingAsync("Matthias", 3000);
            //t1.ContinueWith(t1a =>
            //{
            //    string result = t1a.Result;
            //    Console.WriteLine(result);
            //    Console.WriteLine("MyRunner completed");
            //});
            //return t1;
        }

        static string Greeting(string name, int ms)
        {
            Thread.Sleep(ms);
            return $"Hello, {name}";
        }

        static Task<string> GreetingAsync(string name, int ms)
        {
            return Task<string>.Run<string>(() =>
            {
                string result = Greeting(name, ms);
                return result;
            });
        }

        static void SomeIssue()
        {
            try
            {
                MyAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static async void MyAsync()
        {
            await Task.Delay(3000);
            throw new Exception("bad bad");
        }
    }
}
