using System;
// using declaration

namespace ResourceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();

            GC.Collect();  // only use with testing
            Console.ReadLine();
        }

        private static void NewMethod()
        {
            var myResource = new MyResource();
            try
            {
                myResource.Foo();
            }
            finally
            {
                myResource.Dispose();
            }

            // using statement
            using (var myres2 = new MyResource())
            {
                myres2.Foo();
            }
        }
    }
}
