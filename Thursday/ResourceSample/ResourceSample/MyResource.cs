using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceSample
{
    class MyResource : IDisposable
    {
        private InnerResource inner = new InnerResource();

        public MyResource()
        {
            Console.WriteLine("allocate native resource");
        }

        public void Foo()
        {
            Console.WriteLine("use resource");
        }

        ~MyResource()
        {
            // Console.WriteLine("Finalize");
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                inner.Dispose();
                GC.SuppressFinalize(this);
            }
            Console.WriteLine("Dispose");



        }
    }
}
