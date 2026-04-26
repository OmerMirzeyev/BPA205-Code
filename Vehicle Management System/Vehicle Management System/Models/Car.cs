using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Management_System.Models
{
    public class Car : Vehicle
    {
        private string _fuelType;
        private int _doorCount;

        public string FuelType
        {
            get { return _fuelType; }
            set { _fuelType = value; }
        }

        public int DoorCount
        {
            get { return _doorCount; }
            set { _doorCount = value; }
        }
      

        public static void GetInfo(Car car)
        {
            Console.WriteLine($"Fuel type; {car.FuelType}, Door count; {car.DoorCount}");
        }
        public Car(string brand, string model, int year, string fuelType, int doorCount)
          : base(brand, model, year)
        {
            FuelType = fuelType;
            DoorCount = doorCount;
        }
    }
}
