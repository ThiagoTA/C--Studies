using System;
using System.Globalization;
using ExProposto3.Entities;
using ExProposto3.Entities.Enums;

namespace ExProposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client cl = new Client(name, email, birth);

            Console.WriteLine("Enter order data:");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order or = new Order(DateTime.Now, status, cl);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nEnter #{0} item data:", i);
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product pd = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem oi = new OrderItem(quantity, productPrice, pd);
                or.AddItem(oi);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(or);
    
        }
    }
}
