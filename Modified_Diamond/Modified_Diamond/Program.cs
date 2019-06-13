using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modified_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a odd number: ");
            int size = Convert.ToInt32(Console.ReadLine());

            
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = i; j < (size - 1); j++)
                        Console.Write(" ");
                    for (int k = 0; k <= i; k++)
                        Console.Write("*");
                    for (int l = 1; l <= i; l++)
                        Console.Write("*");

                    Console.WriteLine();
                }

                for (int i = 0; i < (size - 1); i++)
                {
                    for (int j = 0; j <= i; j++)
                        Console.Write(" ");
                    for (int k = (size - 1); k > i; k--)
                        Console.Write("*");
                    for (int l = (size - 2); l > i; l--)
                        Console.Write("*");

                    Console.WriteLine();
                }

                Console.ReadKey();
            }
        }
    }
}
