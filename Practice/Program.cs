// See https://aka.ms/new-console-template for more information

using System;

namespace DiceThrowingSimulator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            if (!int.TryParse(Console.ReadLine(), out int rolls) || rolls <= 0)
            {
                Console.WriteLine("Please enter a positive whole number.");
                return;
            }

            // Call the second class to simulate rolls and return the counts array
            DiceRoller roller = new DiceRoller();
            int[] countsBySum = roller.SimulateRolls(rolls); // index 2..12 used

            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {rolls}.");
            Console.WriteLine();

            // Print histogram for sums 2..12
            for (int sum = 2; sum <= 12; sum++)
            {
                double percent = (countsBySum[sum] * 100.0) / rolls;

                // Each * = 1%. We must choose an integer number of stars.
                // Rounding to nearest int is typical; you can use Floor/Ceiling if your instructor prefers.
                int stars = (int)Math.Round(percent, MidpointRounding.AwayFromZero);

                Console.Write($"{sum}: ");
                Console.WriteLine(new string('*', stars));
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }

    class DiceRoller
    {
        private readonly Random _rand = new Random();

        // Returns an array where index = dice sum (2..12) and value = count
        public int[] SimulateRolls(int numberOfRolls)
        {
            int[] results = new int[13]; // 0..12, we will ignore 0 and 1

            for (int i = 0; i < numberOfRolls; i++)
            {
                int die1 = _rand.Next(1, 7); // 1..6
                int die2 = _rand.Next(1, 7); // 1..6
                int sum = die1 + die2;

                results[sum]++;
            }

            return results;
        }
    }
}


