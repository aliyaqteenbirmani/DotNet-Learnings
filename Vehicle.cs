using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Vehicle(string make,string model,int year,string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Make: {Make}\nModel: {Model}\nYear: {Year}\nColor: {Color}");
        }
    }

    class Car:Vehicle
    {
        public int NumberOfDoors { get; set; }
        public bool HasSunRoof { get; set; }

        public Car( string make, string model, int year, string color, int numberOfDoors, bool hasSunRoof) :base(make,model,year,color)
        {
            NumberOfDoors = numberOfDoors;
            HasSunRoof = hasSunRoof;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}\nHas Sunroof: {HasSunRoof}");
        }
    }

    class Truck:Vehicle
    {
        public int PayLoadCapacity { get; set; }
        public int NumberOfAxles { get; set; }

        public Truck(string make, string model, int year, string color, int payLoadCapacity, int numberOfAxles) :base(make,model,year,color)
        {
            PayLoadCapacity = payLoadCapacity;
            NumberOfAxles = numberOfAxles;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Payload Capacity: {PayLoadCapacity}\nNumber of Axles: {NumberOfAxles}");
        }

    }

    class Motorcycle:Vehicle
    {
        public bool HasSideCar { get; set; }
        public string EngineType { get; set; }

        public Motorcycle(string make, string model, int year, string color,bool hasSideCar,string engineType) : base(make, model, year, color)
        {
            HasSideCar = hasSideCar;
            EngineType = engineType;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar: {HasSideCar}\nEngine Type: {EngineType}");
        }

    }

    class VehicleManagementSystem
    {
        private List<Vehicle> vehicles;

        public VehicleManagementSystem()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            Console.WriteLine("Vehicle is added successfully!");
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            if (vehicles.Contains(vehicle))
            {
                vehicles.Remove(vehicle);
                Console.WriteLine("Vehicle is removed successfully!");
            }
            else
                Console.WriteLine("Vehicle not found!");
        }

        public void DisplayAllVehicles()
        {
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                Console.WriteLine();
            }
        }


        //static void Main()
        //{
        //    Vehicle c1 = new Car("Fortuner", "RangeRover", 2020, "Black", 4, true);
        //    VehicleManagementSystem vm = new VehicleManagementSystem();
        //    Car car = new Car("Toyota", "Camry", 2020, "Red", 4, true);
        //    Truck truck = new Truck("Ford", "F-150", 2019, "Blue", 3000, 4);
        //    Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Street 750", 2021, "Black", false, "V-Twin");

        //    c1.DisplayInfo();
        //    //vm.AddVehicle(car);
        //    //vm.AddVehicle(c1);
        //    //vm.AddVehicle(truck);
        //    //vm.AddVehicle(motorcycle);

        //    vm.DisplayAllVehicles();

        //    Console.ReadLine();

        //}
    }
}
