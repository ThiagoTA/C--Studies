using System;

namespace ExProposto1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com uma senha!");
            int password = int.Parse(Console.ReadLine());

            while (password != 2002)
            {
                Console.WriteLine("\nSenha inválida\n");
                Console.WriteLine("Digite a senha novamente");
                password = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nAcesso permitido");
        }
    }
}
