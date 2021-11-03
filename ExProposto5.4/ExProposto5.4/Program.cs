using System;

namespace ExProposto5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            int resultado = 1;
            for (int i = 1; i <= N; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine(resultado);
        }
    }
}
