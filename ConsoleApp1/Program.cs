using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Welcome Message with input for num of rolls
            Console.Write("Welcome to the dice throwing simulator!: \n How many dice rolls would you like to simulate? ");
            int numRolls = Convert.ToInt32(Console.ReadLine());

            // create random class
            Random r = new Random();

            //create array
            int[] rollTotals = new int[11];

            // the roll of the die
            for (int i = 0; i < numRolls; i++)
            {
                // rolling of each individual dice
                int roll1 = r.Next(1,7);
                int roll2 = r.Next(1, 7);

                //total for the rolls
                int totalofRolls = roll1 + roll2;

                // takes the total 
                rollTotals[totalofRolls-2]++;
            }

            //output 
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n Each '*' represents 1% of the total number of rolls.\n Total number of rolls = " + numRolls.ToString());
            for (int i=2; i <= 13; i++)
            {
                double percentage = ((double)rollTotals[i-2] / numRolls) * 100;
                Console.WriteLine($" { i}: " + new string('*', (int)percentage));
            }

            Console.WriteLine("\n Thanks for using the dice throwing simulator. Goodbye!");
           
        }
    }
}
