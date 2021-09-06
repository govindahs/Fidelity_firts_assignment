using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class prime
    {   
        
        static bool isPrimeNumber(int n)
        {   if (n % 2 == 0)
                return true;
            else
            return false;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            if (isPrimeNumber(n))
            {
                Console.WriteLine("it's a prime number");
            }
            else
                Console.WriteLine("it's not a prime number");
        }
    }
}
