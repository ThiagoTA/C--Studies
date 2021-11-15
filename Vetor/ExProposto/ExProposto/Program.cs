using System;

namespace ExProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine());

            if (N < 1 || N > 10)
            {
                Console.WriteLine("\n[ERRO] Número tem que ser entre 1 a 10");
            } else
            {
                Alunos[] vect = new Alunos[10];

                string nome;
                string email;
                int quarto;
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine("\nAluguel #{0}", i);
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Email: ");
                    email = Console.ReadLine();
                    Console.Write("Número do quarto: ");
                    quarto = int.Parse(Console.ReadLine());
                    vect[quarto] = new Alunos(nome, email);
                }

                Console.WriteLine("\nQuartos ocupados: ");
                for (int i = 0; i < 10; i++)
                {
                    if (vect[i] != null) { 
                        Console.WriteLine(i + ": " + vect[i]);
                    }
                }
            }
        }
    }
}
