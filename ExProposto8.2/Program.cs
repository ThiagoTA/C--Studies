using System;
using System.Globalization;

namespace ExProposto8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do salário:");
            double salary = double.Parse(Console.ReadLine());

            double imposto;
            if (salary <= 2000.0)
            {
                imposto = 0.0;
            } else if (salary <= 3000.0)
            {
                imposto = (salary - 2000.00) * 0.08;
            } else if (salary <= 4500.0) 
            {
                imposto = (salary - 3000.00) * 0.18 + 1000.0 * 0.08;
            } else
            {
                imposto = (salary - 4500.00) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            } else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
       
        }
    }
}
