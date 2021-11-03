using System;
using System.Globalization;

namespace ExProposto3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {

                Console.WriteLine("\nEntre com {0} médias:", N);
                string[] notas = Console.ReadLine().Split(' ');
                double a = double.Parse(notas[0]);
                double b = double.Parse(notas[1]);
                double c = double.Parse(notas[2]);

                double soma = (a * 2.0 + b * 3.0 + c * 5.0) / 10;

                Console.WriteLine("\n" + soma.ToString("F1", CultureInfo.InvariantCulture));
            }   
        }
    }
}
