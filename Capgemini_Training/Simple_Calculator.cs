using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            // Input first number
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            // Input operator
            Console.Write("Enter operator (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            // Input second number
            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            // Switch case for operations
            switch (op)
            {
                case '+':
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;

                case '/':
                    if (num2 != 0)
                        Console.WriteLine("Result: " + (num1 / num2));
                    else
                        Console.WriteLine("Cannot divide by zero!");
                    break;

                default:
                    Console.WriteLine("Invalid Operator!");
                    break;
            }
        }
    }
}

