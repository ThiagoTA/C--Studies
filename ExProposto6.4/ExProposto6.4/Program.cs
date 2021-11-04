using System;

namespace ExProposto6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                if(N % i == 0)
                {
                    Console.WriteLine(i);
                }
               
            }
        }
    }
}
