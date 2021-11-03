using System;

namespace ExProposto2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o primeiro valor");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("\nSegundo");
                } else if (x > 0 && y > 0) {
                    Console.WriteLine("\nPrimeiro");
                } else if (x < 0 && y < 0)
                {
                    Console.WriteLine("\nTerceiro");
                } else
                {
                    Console.WriteLine("\nQuarto");
                }
                Console.WriteLine("\nEntre com um novo valor");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Valor Nulo");
        }
    }
}
