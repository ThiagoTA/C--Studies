using System;
using ExProposto.Entities;
using ExProposto.Entities.Exceptions;
using System.Globalization;

namespace ExProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account acc = new Account();

                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Deposit(balance);
                Console.Write("Withdraw limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc = new Account(number, holder, balance, withDrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.WithDraw(withDraw);

                Console.WriteLine(acc);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }

        }
    }
}
