using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Vehicle_Management_System.Models
{
    public class Motorcycle : Vehicle
    {
        private string _fuelType;
        private int _engineSize;

        public string FuelType
        {
            get { return _fuelType; }
            set { _fuelType = value; }
        }

        public int EngineSize
        {
            get { return _engineSize; }
            set { _engineSize = value; }
        }
        public Motorcycle(string brand, string model, int year, string fuelType, int engineSize)
        : base(brand, model, year)
        {
            FuelType = fuelType;
            EngineSize = engineSize;
        }
        public static void GetInfo(Motorcycle motorcycle)
        {
            Console.WriteLine($"Fuel type; {motorcycle.FuelType}, Engine size; {motorcycle.EngineSize}cc");
        }
    }
}
