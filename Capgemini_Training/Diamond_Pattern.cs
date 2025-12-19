using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capgemini_Training
{
    class Diamond_Pattern
    {
        static void Main(string[] args)
        {
            // Ask user for number of rows (half of the diamond)
            Console.WriteLine("Enter number of rows:");
            int n = int.Parse(Console.ReadLine());

            // -------------------------
            // Upper half of the diamond
            // -------------------------
            for (int i = 1; i <= n; i++)
            {
                // Print spaces
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int star = 1; star <= (2 * i - 1); star++)
                {
                    Console.Write("*");
                }

                // Move to next line
                Console.WriteLine();
            }

            // -------------------------
            // Lower half of the diamond
            // -------------------------
            for (int i = n - 1; i >= 1; i--)
            {
                // Print spaces
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int star = 1; star <= (2 * i - 1); star++)
                {
                    Console.Write("*");
                }

                // Move to next line
                Console.WriteLine();
            }
        }
    }
}
