using System;


namespace Dice_Rolling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] totals = new int[13];

            int diceRoll1;
            int diceRoll2;

            var randomNumbers = new Random();//generates random number

            //rolls dice 
            for (int roll = 1; roll <= 36000; roll++)
            {
                diceRoll1 = randomNumbers.Next(1, 7);
                diceRoll2 = randomNumbers.Next(1, 7);

                ++totals[diceRoll1 + diceRoll2];
            }
            //displays table lables
            Console.WriteLine("{0,8}{1,12}{2,12}", "Roll", "Frequency", "Percentage");

            //outputs each array element value & percent of value rolled
            for (int p = 2; p < totals.Length; p++)
            {
                double percent = totals[p] / (360.0);
                Console.WriteLine("{0,8}{1,12}{2,12:F}",
                p, totals[p], percent);
            }

            Console.ReadKey();
        }
    }
}