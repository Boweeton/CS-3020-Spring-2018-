using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassChallenege2
{
    class Program
    {
        static void Main()
        {
            CheckingAccount ca = new CheckingAccount(0.25m, 1969.0m);
            SavingsAccount sa = new SavingsAccount(0.04m, 503.56m);

            // Print State
            Console.WriteLine("---Before Transactions---");
            Console.WriteLine($"Checking accout balance: ${ca.Balance}");
            Console.WriteLine($"Savings accout balance: ${sa.Balance}");
            Console.WriteLine();

            // Transact
            ca.Debit(32.50m);
            sa.CalculateInterest();

            // Print State
            Console.WriteLine("---Before Transactions---");
            Console.WriteLine($"Checking accout balance: ${ca.Balance}");
            Console.WriteLine($"Savings accout balance: ${sa.Balance}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
