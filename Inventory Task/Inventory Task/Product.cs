using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Task
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Mehsul: {Name} | Qiymet: {Price} AZN";
        }
    }
}
