using System;
using System.Text;
using System.Globalization;

namespace ExProposto3.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = Price;
            Product = product;
        }

        public double SubTotal()
        {
            return Product.Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name + ", "
                    + Product.Price.ToString("F2", CultureInfo.InvariantCulture) + ", "
                    + "Quantity: " + Quantity + ", "
                    + "SubTotal: " + " $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
