using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Day_02
{
    class methods
    {   static int Mymethods(int a,int b)
        {
            Console.WriteLine("Im method here");
            return a + b;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c=Mymethods(a,b);
            Console.WriteLine(c);
        }
    }
}
