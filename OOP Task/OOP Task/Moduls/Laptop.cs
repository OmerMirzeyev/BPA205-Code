using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task.Moduls
{
    public class Laptop : Product
    {
        private string _processor;
        private int _ram;
        public string Processor { get; set; }
        public int Ram { get; set; }
        public Laptop(string name, double price, int stock, string processor, int ram) 
            : base(name, price, stock)
        {
            Processor = processor;
            Ram = ram;
        }

    }
}
