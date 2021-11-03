using System;

namespace ExProposto3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do produto\n1. Álcool\n2. Gasolina\n3. Diesel\n4. Fim");
            int code = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (code != 4) 
            {
                if (code == 1)
                {
                    alcool += 1;
                    Console.WriteLine("+1 no alcool\n");
                } else if (code == 2)
                {
                    gasolina += 1;
                    Console.WriteLine("+1 no gasolina\n");
                } else if (code == 3)
                {
                    diesel += 1;
                    Console.WriteLine("+1 no diesel\n");
                } else
                {
                    Console.WriteLine("\nCode inválido\n");
                }
                Console.WriteLine("Digite novamente o código");
                code = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nMUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
