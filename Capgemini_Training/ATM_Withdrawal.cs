using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
        class ATM_Withdrawal
        {
            static void Main(string[] args)
            {
                // Initial account balance
                int balance = 10000;

                // Ask user to insert ATM card
                Console.WriteLine("Insert Card (yes/no): ");
                string card = Console.ReadLine().ToLower();

                // Check if card is inserted
                if (card == "yes")
                {
                    // Ask user to enter PIN
                    Console.WriteLine("Enter PIN: ");
                    int pin = int.Parse(Console.ReadLine());

                    // Validate PIN
                    if (pin == 1234)   // Correct PIN
                    {
                        // Ask user to enter withdrawal amount
                        Console.WriteLine("Enter withdrawal amount: ");
                        int amount = int.Parse(Console.ReadLine());

                        // Check if balance is sufficient
                        if (amount <= balance)
                        {
                            // Deduct amount from balance
                            balance -= amount;

                            // Display successful transaction message
                            Console.WriteLine("Withdrawal Successful!");
                            Console.WriteLine("Remaining Balance: " + balance);
                        }
                        else
                        {
                            // Display insufficient balance message
                            Console.WriteLine("Insufficient Balance!");
                        }
                    }
                    else
                    {
                        // Display invalid PIN message
                        Console.WriteLine("Invalid PIN!");
                    }
                }
                else
                {
                    // Display message if card is not inserted
                    Console.WriteLine("Please insert card!");
                }
            }
        } 

}
