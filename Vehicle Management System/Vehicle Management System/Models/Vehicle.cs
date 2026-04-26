using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Management_System.Models
{
    public class Vehicle
    {
        private string _brand;
        private string _model;
        private int _year;
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1900)
                {
                    Console.WriteLine($"{Brand} {Model} 1900'dan kicik oldugu ucun elave edilmedi");
                }
                else { _year = value; }
            }
        }

        public static void GetInfo(Vehicle vehicle)
        {
            Console.WriteLine($"Brand: {vehicle.Brand}, Model: {vehicle.Model}, Year: {vehicle.Year}");
        }
    
    public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

    }
}
