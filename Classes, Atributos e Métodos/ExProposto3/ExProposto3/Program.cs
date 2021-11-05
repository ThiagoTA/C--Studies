using System;

namespace ExProposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            string[] vet = Console.ReadLine().Split(' ');
            a.Tr1 = double.Parse(vet[0]);
            a.Tr2 = double.Parse(vet[1]);
            a.Tr3 = double.Parse(vet[2]);

            Console.WriteLine();
            Console.WriteLine("Nota final = " + a.NotaFinal().ToString("F2"));

            if (a.Aprovado())
            {
                Console.WriteLine("Aprovado");
            } else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + a.NotaFaltando() + " pontos");
            }
        }
    }
}
