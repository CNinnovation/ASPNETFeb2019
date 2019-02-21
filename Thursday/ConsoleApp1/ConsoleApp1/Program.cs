using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Semaphore s1 = new Semaphore(4, 4);
            s1.WaitOne();
            s1.Release();

            SemaphoreSlim s2 = new SemaphoreSlim(4, 4);
            s2.Wait();
            s2.Release();

            AutoResetEvent ev1 = new AutoResetEvent(false);
            ManualResetEvent ev2 = new ManualResetEvent(false);
            
            ManualResetEventSlim ev3 = new ManualResetEventSlim();

        }
    }
}
