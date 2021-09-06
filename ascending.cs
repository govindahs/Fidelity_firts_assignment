using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class ascending
    {
       
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the sorting values : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Sort sort = new Sort();
            sort.Sorted(a,b,c);
           
        }
    }

    class Sort 
    {
        public void Sorted(int a, int b, int c)
  
        {
            if ((a<=b) && (a<=c))
            {
                if (b <= a)
                {
                    Console.WriteLine(a + "" + b + "" + c);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(a + "" + c + "" + b);
                    Console.ReadLine();
                }
            }
            else if((b<=a) && (b<=c))
            {   if (a <= c)
                {
                    Console.WriteLine(b + "" + a + "" + c);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(b + "" + c + "" + a);
                    Console.ReadLine();
                }
            }
            else
            {
                if (a <= b)
                {
                    Console.WriteLine(c + "" + a + "" + b);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(c + "" + b + "" + a);
                    Console.ReadLine();
                }
      
            }
        }
    }
}
