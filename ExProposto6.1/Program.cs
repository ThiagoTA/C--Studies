using System;
using System.Globalization;

namespace ExProposto6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor de 'A', 'B' e 'C':");
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);

            double triangulo = (a * c) / 2;
            double circulo = 3.14159 * c * c;
            double trapezio = (a + b) / 2 * c;
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
