using System;

namespace DiceSimulator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate?");

            int rolls;
            while (!int.TryParse(Console.ReadLine(), out rolls)) 
            {
                Console.WriteLine("Invalid input. Please try again.");
            }

            DiceRoller roller = new DiceRoller();
            int[] results = roller.RollDice(rolls);

            Console.WriteLine("DiceResults: ");
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine($"Total number of rolls ={rolls} ");
            Console.WriteLine();

            for (int i = 2; i <= 12; i++)
            {
                int percentage = (results[i] * 100) / rolls;
                Console.WriteLine($"{i}: ");

                for (int j = 0; j < percentage; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine(" ");
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
        
    }
}