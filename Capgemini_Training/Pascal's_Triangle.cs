using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capgemini_Training
{
    class Pascals_Triangle
    {
        static void Main(string[] args)
        {
            // Ask user for number of rows
            Console.Write("Enter number of rows: ");
            int n = int.Parse(Console.ReadLine());

            // Loop for each row
            for (int i = 0; i < n; i++)
            {
                int number = 1; // First value in every row is always 1

                // Print spaces for triangle shape
                for (int space = 0; space < n - i - 1; space++)
                {
                    Console.Write(" ");
                }

                // Loop to print numbers in each row
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number + " ");

                    // Formula to calculate next value in the row
                    number = number * (i - j) / (j + 1);
                }

                // Move to next line after each row
                Console.WriteLine();
            }
        }
    }
}

