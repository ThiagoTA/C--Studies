using System;

namespace ExProposto1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
