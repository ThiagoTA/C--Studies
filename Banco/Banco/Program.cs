using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá dépósito inicial (s/n)? ");
            string resposta = Console.ReadLine();

            Banco b = new Banco();
    
            if (resposta == "s") { 
                Console.Write("\nEntre com o valor do depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());
                b = new Banco(conta, nome, deposito);
            } else if (resposta == "n") {
                b = new Banco(conta, nome);
            } else
            {
                Console.WriteLine("[Erro]");
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(b);

            Console.Write("\nEntre com um valor para depósito: ");
            double depositar = double.Parse(Console.ReadLine());
            b.Depositar(depositar);

            Console.WriteLine("\nDados da conta Atualizados:");
            Console.WriteLine(b);

            Console.Write("\nEntre com um valor para saque: ");
            double sacar = double.Parse(Console.ReadLine());
            b.Sacar(sacar);

            Console.WriteLine("\nDados da conta Atualizados:");
            Console.WriteLine(b);


        }
    }
}
