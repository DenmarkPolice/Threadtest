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
                WrY("S");
                Thread.Sleep(5000);
                WrY("L");
            }
            void WrY(string Letter)
            {
                for (int i = 0; i < 1000; i++) Console.Write(Letter);
            }
        }

        
    }
}
