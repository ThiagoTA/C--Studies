using System;

namespace ExProposto7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int quadrado = i * i;
                int cubo = i * i * i;
                Console.WriteLine("{0} {1} {2}", i, quadrado, cubo);
            }
        }
    }
}
