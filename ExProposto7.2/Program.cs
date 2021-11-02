using System;

namespace ExProposto7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do X e do Y");
            string[] num = Console.ReadLine().Split(' ');
            double X = double.Parse(num[0]);
            double Y = double.Parse(num[1]);

            if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            } else if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            } else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            } else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            } else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
