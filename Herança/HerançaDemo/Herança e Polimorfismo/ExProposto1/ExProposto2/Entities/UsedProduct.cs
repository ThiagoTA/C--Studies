﻿using System;
using System.Globalization;

namespace ExProposto2.Entities
{
    class UsedProduct : Product
    {
        public DateTime Manufacture { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacture)
            : base(name, price)
        {
            Manufacture = manufacture;
        }

        public override string PriceTag()
        {
            return Name + " (used) " +
                "$ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " " +
                    "(Manufacture date: " + Manufacture.ToString("dd/MM/yyyy") + ")";

        }
    }
}
