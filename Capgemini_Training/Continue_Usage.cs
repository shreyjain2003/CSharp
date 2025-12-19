using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    class Continue_Example
    {
        static void Main(string[] args)
        {
            // Loop from 1 to 50
            for (int i = 1; i <= 50; i++)
            {
                // Check if the number is a multiple of 3
                if (i % 3 == 0)
                {
                    // Skip the current iteration and move to the next number
                    continue;
                }

                // Print the number if it is NOT a multiple of 3
                Console.Write(i + " ");
            }

            // Keep console window open
            Console.ReadLine();
        }
    }
}

