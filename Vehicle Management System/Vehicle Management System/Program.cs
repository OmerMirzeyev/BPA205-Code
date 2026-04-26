using Vehicle_Management_System.Models;

namespace Vehicle_Management_System
{
    public class Program
    {
        static void Main(string[] args)
        {

            Garage myGarage = new Garage();
            Console.WriteLine("Add car info");
            Console.WriteLine("Brand; ");
            string carBrand = Console.ReadLine();

            Console.WriteLine("Model; ");
            string carModel = Console.ReadLine();

            Console.WriteLine("Year; ");
            int carYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Fuel; ");
            string carFuel = Console.ReadLine();

            Console.WriteLine("Door; ");
            int carDoor = int.Parse(Console.ReadLine());

            Car myCar = new Car(carBrand,carModel,carYear,carFuel,carDoor);
            Console.WriteLine("\n Add motorcyle info");
            Console.WriteLine("Brand; ");
            string motoBrand = Console.ReadLine();

            Console.WriteLine("Model; ");
            string motoModel = Console.ReadLine();

            Console.WriteLine("Year; ");
            int motoYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Fuel; ");
            string motoFuel = Console.ReadLine();

            Console.WriteLine("Enginesize; ");
            int motongine = int.Parse(Console.ReadLine());

            Motorcycle myMotorcycle = new Motorcycle(motoBrand,motoModel,motoYear,motoFuel,motongine);

            Console.WriteLine("\n Add truck info");
            Console.WriteLine("Brand; ");
            string truckBrand = Console.ReadLine();

            Console.WriteLine("Model; ");
            string truckModel = Console.ReadLine();

            Console.WriteLine("Year; ");
            int truckYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Load capasity; ");
            double truckLoad = double.Parse(Console.ReadLine());

            Truck myTruck = new Truck(truckBrand,truckModel,truckYear,truckLoad);

            myGarage.AddVehicle(myCar);
            myGarage.AddVehicle(myMotorcycle);
            myGarage.AddVehicle(myTruck);
            Console.WriteLine("All info added");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("ALL CAR; ");
            myGarage.ShowAllVehicles();
        }
    }
}
