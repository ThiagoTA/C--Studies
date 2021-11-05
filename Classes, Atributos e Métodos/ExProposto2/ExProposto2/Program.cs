using System;

namespace ExProposto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados f = new Dados();

            Console.WriteLine("Entre com os dados do Funcionário:");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double pt = double.Parse(Console.ReadLine());
            f.AumentarSalario(pt);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}
