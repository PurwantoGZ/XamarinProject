using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThread
{
    #region Class Program
    class Program
    {
        public bool done;
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

            /*2. 
            new Thread(Go).Start(); // Call Go() on a new Thread
            Go(); // Call Go() as a function main.
            */

            /*3. Thread a same instance
            Program tt = new Program();
            new Thread(tt._Go).Start();
            tt._Go();
            */
            Console.ReadLine();           
        }

        #region Function
        void _Go()
        {
            if (!done)
            {
                Console.WriteLine("Done"); done = true;
            }
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
        #endregion
    }
    #endregion

}
