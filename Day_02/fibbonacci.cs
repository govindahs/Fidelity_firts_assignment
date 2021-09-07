using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Day_02
{
    class Class1
    {
        static void fibbonacci(int a = 0, int b = 1)
        {
            int c = a + b;
            b = a;
            a = c;
            Console.Write(c + " ");
            if (c <= 200)
            {
                fibbonacci(a, b);
            }
        }
        static void Main(string[] a)
        {
          
                fibbonacci();
          
        }
    }
}
