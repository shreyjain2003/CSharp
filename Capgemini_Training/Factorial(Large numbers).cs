using System;
using System.Numerics; // Required for BigInteger to handle large factorial values
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Capgemini_Training
{
    class Factorial_LargeNumbers
    {
        static void Main(string[] args)
        {
            // Ask user to enter a number
            Console.WriteLine("Enter a number to calculate its factorial:");
            int n = int.Parse(Console.ReadLine());

            // BigInteger is used to avoid overflow for large factorial values
            BigInteger factorial = 1;

            // Loop to calculate factorial
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            // Display the result
            Console.WriteLine("Factorial of " + n + " is:");
            Console.WriteLine(factorial);

            // Keep console window open
            Console.ReadLine();
        }
    }
}
