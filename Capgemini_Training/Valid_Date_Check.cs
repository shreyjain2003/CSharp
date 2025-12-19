using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
        class Valid_Date_Check
        {
            static void Main(string[] args)
            {
                // Input day, month, and year from user
                Console.WriteLine("Enter Day:");
                int day = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Month:");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Year:");
                int year = int.Parse(Console.ReadLine());

                bool isValid = true;

                // Check valid month
                if (month < 1 || month > 12)
                {
                    isValid = false;
                }
                else
                {
                    // Days in each month
                    int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                    // Check for leap year
                    if (month == 2 && IsLeapYear(year))
                    {
                        daysInMonth[1] = 29;
                    }

                    // Check valid day
                    if (day < 1 || day > daysInMonth[month - 1])
                    {
                        isValid = false;
                    }
                }

                // Output result
                if (isValid)
                {
                    Console.WriteLine("Valid Date");
                }
                else
                {
                    Console.WriteLine("Invalid Date");
                }
            }

            // Method to check leap year
            static bool IsLeapYear(int year)
            {
                return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            }
        }
    

}
