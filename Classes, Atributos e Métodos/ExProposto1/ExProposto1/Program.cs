using System;

namespace ExProposto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(r);
        }
    }
}
