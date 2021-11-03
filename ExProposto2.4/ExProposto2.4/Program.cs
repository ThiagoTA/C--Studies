using System;

namespace ExProposto2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com valor de N: ");
            int N = int.Parse(Console.ReadLine());

            int entrada = 0;
            int saida = 0;

            for (int i = 1; i <= N; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor < 10 || valor > 20)
                {
                    saida += 1;
                } else
                {
                    entrada += 1;
                }
            }
            Console.WriteLine("\n"+ entrada + " in");
            Console.WriteLine(saida + " out");
        }
    }
}
