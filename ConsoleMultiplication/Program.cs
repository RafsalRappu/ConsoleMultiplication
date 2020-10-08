using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultiplication
{
    class multiTable
    {
        static void multiplication(int N, int i)
        {
            if (i > 10)
                return;
            Console.WriteLine(N + " * " + i + " = " + N * i);
            multiplication(N, i + 1);
        }
        static void Main(string[] args)
        {
            int N = 8;
            multiplication(N, 1);
            Console.ReadKey();
        }
    }
}
