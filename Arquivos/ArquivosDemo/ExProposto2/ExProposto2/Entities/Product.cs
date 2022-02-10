using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProposto2
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public double Total()
        {
            return Price * Amount;
        }
    }
}
