using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capgemini_Training
{
    class Profit_Loss
    {
        static void Main(string[] args)
        {
            // Ask user to enter Cost Price
            Console.WriteLine("Enter Cost Price:");
            double costPrice = double.Parse(Console.ReadLine());

            // Ask user to enter Selling Price
            Console.WriteLine("Enter Selling Price:");
            double sellingPrice = double.Parse(Console.ReadLine());

            // Check if there is profit
            if (sellingPrice > costPrice)
            {
                // Calculate profit amount
                double profit = sellingPrice - costPrice;

                // Calculate profit percentage
                double profitPercent = (profit / costPrice) * 100;

                Console.WriteLine("Profit Occurred");
                Console.WriteLine("Profit Percentage: " + profitPercent + "%");
            }
            // Check if there is loss
            else if (sellingPrice < costPrice)
            {
                // Calculate loss amount
                double loss = costPrice - sellingPrice;

                // Calculate loss percentage
                double lossPercent = (loss / costPrice) * 100;

                Console.WriteLine("Loss Occurred");
                Console.WriteLine("Loss Percentage: " + lossPercent + "%");
            }
            // If cost price and selling price are equal
            else
            {
                Console.WriteLine("No Profit No Loss");
            }
        }
    }
}

