using System;
using System.Globalization;

namespace ExProposto5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor código da peça, o número de peças e o valor unitário");
            string[] vet1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet1[0]);
            int quant1 = int.Parse(vet1[1]);
            double preco1 = double.Parse(vet1[2]);

            double resultado1 = preco1 * quant1;

            Console.WriteLine("Digite o valor código da peça, o número de peças e o valor unitário");
            string[] vet2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet2[0]);
            int quant2 = int.Parse(vet2[1]);
            double preco2 = double.Parse(vet2[2]);

            double resultado2 = preco2 * quant2;

            double resultadoFinal = resultado1 + resultado2;

            Console.WriteLine("VALOR A PAGAR: " + resultadoFinal.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
