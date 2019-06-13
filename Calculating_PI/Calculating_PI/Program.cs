using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating_PI
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 4;
            Boolean operation = true;
            for (int i = 3; i <= 500; i += 2)
            {
                if (operation)
                {
                    pi -= (4.0 / i);
                }
                else
                {
                    pi += (4.0 / i);

                }

                operation = !operation;
                Console.WriteLine("{0} ", pi);

                if (pi >= 3.14 && pi < 3.15)
                {
                    Console.WriteLine("First repetition of 3.14 is at 4/{0}.", i);
                }
                Console.ReadKey();

            }
        }
    }
}
