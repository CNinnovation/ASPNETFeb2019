using System;

namespace AnonymousMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            Func<int> f1 = delegate { return x; };

            Func<int> f2 = () => 42;

            x = 11;
            var result = f1();
            Console.WriteLine(result);
        }
    }
}
