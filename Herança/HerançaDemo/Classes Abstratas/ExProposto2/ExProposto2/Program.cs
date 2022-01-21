using ExProposto2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExProposto2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contributor> list = new List<Contributor>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'i')
                {
                    Console.Write("Heath expenditures: ");
                    double heathExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PhysicalPerson(name, annualIncome, heathExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(name, annualIncome, employees));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            foreach (Contributor ct in list)
            {
                Console.WriteLine($"{ct.Name}: $ {ct.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            double sum = 0.0;
            foreach (Contributor ct in list)
            {
                sum += ct.Tax();
            }

            Console.WriteLine("\nTOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
