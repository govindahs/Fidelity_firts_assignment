using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class fahrenheit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of Celsius: ");
            int celsius = int.Parse(Console.ReadLine());
            Console.WriteLine("Kelvine is =");
            Console.WriteLine(celsius + 273);
            Console.WriteLine(" fahrenheit is =");
            Console.WriteLine(celsius * 18 / 10 + 32);
        }
    }
}
