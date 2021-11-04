using System;

namespace ExProposto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados pessoa1, pessoa2;

            pessoa1 = new Dados();
            pessoa2 = new Dados();

            Console.WriteLine("Entre com os dados da primeira pessoa");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com os dados da segunda pessoa");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("\nDados da primeira pessoa:\nNome: {0}\nIdade: {1}", pessoa1.Nome, pessoa1.Idade);
            Console.WriteLine("\nDados da segunda pessoa:\nNome: {0}\nIdade: {1}", pessoa2.Nome, pessoa2.Idade);

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("\nPessoa mais velha: " + pessoa1.Nome);
            } else if (pessoa1.Idade < pessoa2.Idade) {
                Console.WriteLine("\nPessoa mais velha: " + pessoa2.Nome);
            } else
            {
                Console.WriteLine("\nPossuem a mesma idade");
            }
        }
    }
}
