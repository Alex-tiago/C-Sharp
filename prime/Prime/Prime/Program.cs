using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        public static void Main()
        {

            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(n))
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is not a prime number");


        }
    }
}
