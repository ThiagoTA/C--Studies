using System;
using System.Globalization;

namespace ExProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double comprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = ConversorDeMoeda.ConverterMoeda(dolar, comprar);

            Console.WriteLine("\nValor a ser pago em reais = " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
