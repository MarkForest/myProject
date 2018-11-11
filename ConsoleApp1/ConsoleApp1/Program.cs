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
            someFunc2();
        }

        private static void someFunc2()
        {
            foreach (var item in "Hello Git")
            {
                Console.WriteLine(item);
                Thread.Sleep(500);
                Console.Beep();
            }
        }
    }
}
