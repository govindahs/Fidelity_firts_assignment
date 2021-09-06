using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Properties
{
    class date
    {
       static bool isLeap(int year)
        {
            // Return true if year
            // is a multiple pf 4 and
            // not multiple of 100.
            // OR year is multiple of 400.
            return (((year % 4 == 0) &&
                     (year % 100 != 0)) ||
                     (year % 400 == 0));
        }

        // Returns true if given
        // year is valid or not.
        static bool isValidDate(int d, int m, int y)
        {
            
            if (m < 1 || m > 12)
                return false;
            if (d < 1 || d > 31)
                return false;

            // Handle February month
            // with leap year
            if (m == 2)
            {
                if (isLeap(y))
                    return true;
                else
                    return false;
            }

            // Months of April, June,
            // Sept and Nov must have
            // number of days less than
            // or equal to 30.
            if (m == 4 || m == 6 ||
                m == 9 || m == 11)
                return (d <= 30);

            return true;
        }
        public static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (isValidDate(d, m, y))
            {
                Console.WriteLine("Valid");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("INVALID");
                Console.ReadLine();
            }
       

        }
    }
}
