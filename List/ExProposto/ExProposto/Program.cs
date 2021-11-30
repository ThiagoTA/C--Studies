using System;
using System.Collections.Generic;

namespace ExProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emplyoee>emplyoeeId;

            Emplyoee e = new Emplyoee();

            Console.Write("Entre com o número de funcionários para registrar: ");
            int start = int.Parse(Console.ReadLine());

            emplyoeeId = new List<Emplyoee>();

            for (int i = 1; i <= start; i++)
            {
                Console.WriteLine("\nEmployee #" + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                if (emplyoeeId.Find(x => x.Id == id) == null)
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Salary: ");
                    double salary = double.Parse(Console.ReadLine());
                    emplyoeeId.Add(new Emplyoee(id, name, salary));
                } else
                {
                    Console.WriteLine("Esse 'id' já existe");
                }
            }

            Console.Write("\nInsira o 'id' do funcionário que terá aumento no salário: ");
            int findid = int.Parse(Console.ReadLine());

            if (emplyoeeId.Find(x => x.Id == findid) == null) {
                Console.WriteLine("\nEsse ID não existe");
            } else
            {
                Console.Write("Insira a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine());
                emplyoeeId.Find(x => x.Id == findid).increaseSalary(percentage);
                Console.WriteLine();
            }

            Console.WriteLine("\nLista Atualizada:");
            foreach (Emplyoee p in emplyoeeId)
            {
                Console.WriteLine(p.Id + ", " + p.Name + ", " + p.Salary);
            }





        }
    }
}
