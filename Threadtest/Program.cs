using System;
using System.Threading;

namespace Threadtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(sleepyThread);
            t.Start();


            for (int i = 0; i < 1000; i++) Console.Write("x");

            void sleepyThread()
            {
                Thread.Sleep(5000);
                WrY();
                Thread.Sleep(5000);
                WrY();
            }
            void WrY()
            {
                for (int i = 0; i < 1000; i++) Console.Write("y");
            }
        }

        
    }
}
