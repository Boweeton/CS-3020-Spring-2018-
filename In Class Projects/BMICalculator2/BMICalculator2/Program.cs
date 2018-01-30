using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to Luke's BMI system!\n");
            Console.WriteLine("----------------------------------------\n");

            // Request user data
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter your weight in pounds: ");
            double userWeightPounds = double.Parse(Console.ReadLine());

            Console.Write("Enter your height in inches: ");
            double userHeightInches = double.Parse(Console.ReadLine());

            // Calculate the BMI
            double userBmi = (userWeightPounds * 703) / (userHeightInches * userHeightInches);

            // Report the BMI
            Console.WriteLine($"\nOk {userName}, your BMI = {userBmi:F2}\n");
            Console.WriteLine("----------------------------------------\n");

            // Make judgment based off of the BMI
            Console.WriteLine("Some friendly \"health advise\":\n");

            // BMI 0 - 10
            if (userBmi >= 0 && userBmi < 10)
            {
                Console.WriteLine($"{userName}, you really need to gain weight!");
            }
            // BMI 10 - 20
            else if (userBmi >= 10 && userBmi < 20)
            {
                Console.WriteLine($"{userName}, you could user a bit more weight.");
            }
            // BMI 20 - 30
            else if (userBmi >= 20 && userBmi < 30)
            {
                Console.WriteLine($"{userName}, your BMI looks good.");
            }
            // BMI 30 - 40
            else if (userBmi >= 30 && userBmi < 40)
            {
                Console.WriteLine($"{userName}, you might want to think about losing some weight in the near future.");
            }
            // BMI 40+
            else
            {
                Console.WriteLine($"{userName}, you really need to lose a LOT of weight to be healthy!");
                Console.WriteLine("(Here's the number for a personal trainer: (612) 763-3300.)");
            }
            Console.WriteLine();
        }
    }
}
