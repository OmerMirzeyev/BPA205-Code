using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task.Moduls
{
    public class Product
    {
        private string _name;
        private double _price;
        private int _stock;
        public string Name { get; set; }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price cannot be negative.");
                }
            }
        }
        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value > 0)
                {
                    _stock = value;
                }
                else
                {
                     Console.WriteLine("Stock cannot be negative.");

                }
            }
        }
        public Product(string name, double price, int stock) 
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

    }
}
