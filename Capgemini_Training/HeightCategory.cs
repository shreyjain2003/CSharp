using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training
{
    public class HeightCategory
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height in CM: ");
            int height=int.Parse(Console.ReadLine());
            if (height < 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if(height>=150 && height < 165)
            {
                Console.WriteLine("Average");
            }
            else if(height>=165 && height < 190)
            {
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Abnormal");
            }
        }
    }
}
