using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Day_02
{
    class names
    {
        static void Main(string[] a)
        {
            int size = int.Parse(Console.ReadLine());
            string[] names = new string[size];
            for(int i=0;i<size;i++)
            {
                names[i]= Console.ReadLine();

            }
            foreach(string values in names)
            {
                Console.WriteLine(values);
            }
        }
    }
}
