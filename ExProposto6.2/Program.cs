using System;

namespace ExProposto6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um valor:");
            double num = double.Parse(Console.ReadLine());

            if (num < 0 || num > 100)
            {
                Console.WriteLine("Fora de Intervalo");
            }
            else if (num <= 25.0)
            {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (num <= 50.0)
            {
                Console.WriteLine("Intervalo [25, 50]");
            }
            else if (num <= 75.0)
            {
                Console.WriteLine("Intervalo [50, 75]");
            }
            else if (num <= 100)
            {
                Console.WriteLine("Intervalo [75, 100]");
            } 
        }
    }
}
