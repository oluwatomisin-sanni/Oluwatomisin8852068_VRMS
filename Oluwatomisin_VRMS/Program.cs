using System;
using VRMS;
namespace VRMS
{
    public class Program
    {
        private static RentalAgency agency = new RentalAgency();
        static void Main(string[] args)
        {
           
           
            // instantiating the vehicles and their attributes

            Car car1 = new Car("Model 3", "Tesla", 80.0, 2023, 5, "Electric", "Automatic", false);
            Truck truck1 = new Truck("F-150", "Ford", 90.0, 2021, 2000, "Pickup", true);
            Motorcycle motorcycle1 = new Motorcycle("Ninja", "Kawasaki", 50.0, 2022, 1000, "Gasoline", true);

            // Add the instantiated vehicles to the fleet
            agency.AddVehicle(car1);
            agency.AddVehicle(truck1);
            agency.AddVehicle(motorcycle1);

            // Display details of each vehicle
            Console.WriteLine("\nVehicle Details:");
            car1.DisplayDetails();
            Console.WriteLine();
            truck1.DisplayDetails();
            Console.WriteLine();
            motorcycle1.DisplayDetails();
            Console.WriteLine();

            // Renting vehicles
            Console.WriteLine("\nRenting Vehicles:");
            agency.RentVehicle(car1, 3);
            agency.RentVehicle(motorcycle1, 2);

            // Displaying the total revenue
            Console.WriteLine("\nAgency Revenue:");
            agency.DisplayTotalRevenue();

            // Remove a vehicle
            Console.WriteLine("\nRemoving a Vehicle:");
            agency.RemoveVehicle(car1);

            // Try to rent the removed vehicle
            Console.WriteLine("\nAttempting to Rent Removed Vehicle:");
            agency.RentVehicle(motorcycle1, 1);
        }
    }
}
