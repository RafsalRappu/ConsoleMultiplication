using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleMultiplication
{
    class multiTable
    {
        
        static void multiplication(int N, int i)
        {
            Thread.Sleep(500);
            if (i > 10)
                return;
            Console.WriteLine(+ N + " X " +  +  i  +  " = " + N * i);
            multiplication(N, i + 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication table for 8 upto 10");
            Console.WriteLine("——————————————————————————————————");
            int N = 8;
            multiplication(N, 1);
            Console.WriteLine("Click any key to exit");
            Console.ReadKey();
        }
    }
}
