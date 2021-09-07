using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Day_02
{
    class sumof
    {   static int sumOfPrimes(int fro,int too)
        {
            Console.WriteLine((fro + too));
            return 0;
        }
        static void Main(string[] a)
        {
            sumOfPrimes(4,5);
            sumOfPrimes(6, 7);
            sumOfPrimes(6, 10);
            sumOfPrimes(3, 6);
        }
    }
}
