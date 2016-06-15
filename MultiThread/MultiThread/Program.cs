using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Make Thread
            Thread t = new Thread(writeY);
            t.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
            }
            */

            /*2. */
            new Thread(Go).Start(); // Call Go() on a new Thread
            Go(); // Call Go() as a function main.


            Console.ReadLine();           
        }
        static void Go()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("?");
            }
        }

        static void writeY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
            Console.WriteLine();
        }
    }
}
