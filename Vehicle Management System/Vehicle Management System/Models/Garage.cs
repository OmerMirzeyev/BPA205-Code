using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Management_System.Models
{
    public class Garage
    {
        private List<Vehicle> _vehicles;
        public Garage()
        {
            _vehicles = new List<Vehicle>();
        }
        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
            Console.WriteLine($"Masin ugurla elave edildi {vehicle.Brand},{vehicle.Model}");
        }
        public void ShowAllVehicles()
        {
            Console.WriteLine("Butun masinlarin siyahisi; ");
            if (_vehicles.Count == 0)
            {
                Console.WriteLine("Hazırda qaraj boşdur.");
                return;
            }
            foreach (var v in _vehicles)
            {
                Console.WriteLine($"Brand: {v.Brand}, Model: {v.Model}, Year: {v.Year}");
            }
           
        }
    }
}
