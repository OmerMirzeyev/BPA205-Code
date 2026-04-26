using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task.Moduls
{
    public class Phone : Product
    {
        private string _brand;
        private int _storage;
        public string Brand { get; set; }
        public int Storage { get; set; }
     

public Phone(string name, double price, int stock, string brand, int storage) 
        : base(name, price, stock)
    {
        Brand = brand;
        Storage = storage;
    }

    }
}
