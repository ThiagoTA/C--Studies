using System;

namespace ExProposto3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do 'A'");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor do 'B'");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor do 'C'");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o vlaor do 'D'");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b) - (c * d);

            Console.WriteLine("\n DIFERENCA = {0}", diferenca);

        }
    }
}
