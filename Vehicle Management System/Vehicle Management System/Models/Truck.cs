using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Management_System.Models
{
    public class Truck : Vehicle
    {
        private double _loadCapacity;

        public double LoadCapacity
        {
            get { return _loadCapacity; }
            set { _loadCapacity = value; }
        }

        public Truck(string brand, string model, int year, double loadCapacity)
            : base(brand, model, year)
        {
            LoadCapacity = loadCapacity;
        }
        public static void GetInfo(Truck truck)
        {
            Console.WriteLine($"Load capacity; {truck.LoadCapacity} tons");
        }
    }
}
