using System;

namespace ExProposto1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o primeiro valor:\n");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEntre com o segundo valor:\n");
            int b = int.Parse(Console.ReadLine());


            double soma = (double)a + b;

            Console.WriteLine($"\nSOMA = {soma}");
        }
    }
}
