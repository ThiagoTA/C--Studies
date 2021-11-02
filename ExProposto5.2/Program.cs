using System;

namespace ExProposto5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o código e a quantidade do item:");
            string[] item = Console.ReadLine().Split(' ');
            int cod = int.Parse(item[0]);
            int quant = int.Parse(item[1]);

            double total;

            if (cod == 1)
            {
                total = quant * 4.0;
            } else if (cod == 2)
            {
                total = quant * 4.5;
            } else if (cod == 3)
            {
                total = quant * 5.0;
            } else if (cod == 4)
            {
                total = quant * 2.0;
            } else 
            {
                total = quant * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2"));

        }
    }
}
