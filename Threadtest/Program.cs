using System;
using System.Threading;

namespace Threadtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WrY);
            t.Start();

            for (int i = 0; i < 1000; i++) Console.Write("x");

            void WrY()
            {
                for (int i = 0; i < 1000; i++) Console.Write("y");
            }
        }

        
    }
}
