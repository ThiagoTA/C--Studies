using System;
using System.Globalization;

namespace ExProposto4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número do funcionário");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o múmero de horas trabalhadas");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Ente com o salário desse funcionário");
            double money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = money * hours ;

            Console.WriteLine("NUMBER = {0}", number);
            Console.WriteLine($"SALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
