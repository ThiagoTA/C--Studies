using System;

namespace ExProposto3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor de 'A'");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor de 'B");
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São Multiplos");
            } else
            {
                Console.WriteLine("Não são Multiplos");
            }
        }
    }
}
