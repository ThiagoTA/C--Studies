using System;

namespace ExProposto4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\nEntre com dois valores");
                string[] divisao = Console.ReadLine().Split(' ');
                double a = double.Parse(divisao[0]);
                double b = double.Parse(divisao[1]);

                if (b == 0)
                {
                    Console.WriteLine("\nDivisão impossivel!");
                } else
                {
                    double resultado = a / b;
                    Console.WriteLine("\n" + resultado);
                }
            }
        }
    }
}
