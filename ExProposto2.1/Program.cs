using System;
using System.Globalization;

namespace ExProposto2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.WriteLine("Entre com o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            double area = pi * (raio * raio);

            Console.WriteLine("A = {0:F4}", area);
        }
    }
}
