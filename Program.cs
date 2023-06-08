using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int attempts = 0;
            int maxAttempts = 6;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("The computer has generated a random number between 1 and 99.");
            Console.WriteLine("You have 6 attempts to guess the number.");

            while (attempts < maxAttempts)
            {
                Console.Write("Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    Console.ReadLine();
                    return;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("The actual number is higher than your guess.");
                }
                else
                {
                    Console.WriteLine("The actual number is lower than your guess.");
                }

                attempts++;
            }

            Console.WriteLine($"You have used all your attempts. The correct number was: {randomNumber}");
            Console.WriteLine("Game over!");
            Console.ReadLine();
        }
    }
}
