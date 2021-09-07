using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Day_02
{
    class array
    {
        static void Main(String[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int[,] aa = new int[a, 3];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    aa[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(aa[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
