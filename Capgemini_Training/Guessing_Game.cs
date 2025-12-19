using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    class Guessing_Game
    {
        static void Main(string[] args)
        {
            // Define the secret number to be guessed
            int secretNumber = 7;

            // Variable to store user's guess
            int guess;

            Console.WriteLine("🎯 Welcome to the Guessing Game!");
            Console.WriteLine("Guess the secret number between 1 and 10");

            // do-while loop ensures the game runs at least once
            do
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());

                // Check if the guess is correct
                if (guess != secretNumber)
                {
                    Console.WriteLine("❌ Wrong guess! Try again.\n");
                }

            } while (guess != secretNumber); // Loop continues until correct guess

            // This message is shown only when the correct number is guessed
            Console.WriteLine("✅ Congratulations! You guessed the correct number.");
        }
    }
}

