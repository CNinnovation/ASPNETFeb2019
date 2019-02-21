using System;
using System.Threading;

namespace ThreadPoolSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(MyTask));
            ThreadPool.GetAvailableThreads(out int workercount, out int complcount);
            Console.WriteLine(workercount);
            Console.WriteLine(complcount);

            Console.ReadLine();
        }

        public static void MyTask(object o)
        {
            Console.WriteLine("running in a thread");
        }
    }
}
