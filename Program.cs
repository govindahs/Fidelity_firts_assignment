using System;
namespace sample
{
    class Program
    {
        static void Main(string[] args)
        { int a = 1;
            Console.WriteLine("Enter a Number U want to make a rable");
            int n = int.Parse(Console.ReadLine());
            while(a<=10)
            {
                
                Console.WriteLine(n+"*"+a+"="+a * n);
                a++;
            }
        }
    }
}
