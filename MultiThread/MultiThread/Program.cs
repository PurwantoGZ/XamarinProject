using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    #region Class Program
    class Program
    {
        /*PASSING DATA to Thread*/
        static void Main(string[] args) {
            //Thread t = new Thread(()=>Print("Hello, Dunia"));
            Thread t = new Thread(()=> 
            {
                Console.WriteLine("I`m running on another thread");
                Console.WriteLine("This is so easy");
            });
            t.Start();
            Console.ReadLine();
        }
        static void Print(string message) { Console.WriteLine(message); }
        

        
    }
    #endregion

}
