using System;

namespace ExProposto4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hora Inicial:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Hora Final:");
            int end = int.Parse(Console.ReadLine());

            int total;

            if (start < end)
            {
                total = end - start;
            } else
            {
                total = 24 - start - end;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", total);
        }
    }
}
