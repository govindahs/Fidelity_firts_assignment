using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class avg
    {   
        static void Main(string[] args)
        {
            int sum = 0;
            int neg = 0;
           
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                int k = int.Parse(Console.ReadLine());
                if (k >= 0)
                    sum += k;
                else
                    neg += k;
            }
            Console.WriteLine("Average of positive numbers is"+sum/n);
            Console.WriteLine("Average of negitive numbers is"+neg/n);
        }
    }
}
