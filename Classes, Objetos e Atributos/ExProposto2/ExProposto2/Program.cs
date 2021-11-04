using System;

namespace ExProposto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados f1, f2;

            f1 = new Dados();
            f2 = new Dados();

            Console.WriteLine("Entre com os dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Entre com os dados do segundo funcuinário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Dados da primeiro funcionário:\nNome: {0}\nSalário: {1}", f1.Nome, f1.Salario);
            Console.WriteLine("\nDados da segundo funcionário:\nNome: {0}\nnSalário: {1}", f2.Nome, f2.Salario);

            double medio = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("\nSalário médio = " + medio.ToString("F2"));
        }
    }
}
