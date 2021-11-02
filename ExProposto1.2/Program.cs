using System;

namespace ExProposto1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque um número:\n");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Negativo");
            } else
            {
                Console.WriteLine("Não é negativo");
            }
        }
    }
}
