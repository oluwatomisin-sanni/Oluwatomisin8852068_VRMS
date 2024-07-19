using System;
using System.Collections.Generic;

namespace VRMS
{
    public class RentalAgency
    {
        private List<Vehicle> Fleet { get; set; }
        public double TotalRevenue { get; private set; }

        public RentalAgency()
        {
            Fleet = new List<Vehicle>();
            TotalRevenue = 0;
        }

        public void AddVehicle(Vehicle vehicle)
        {

            if (vehicle != null)
            {
                Fleet.Add(vehicle);
                Console.WriteLine($"\n{vehicle.Manufacturer}, {vehicle.Model} has been added\n");
            }
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            if (Fleet.Contains(vehicle))
            {
                Fleet.Remove(vehicle);
                Console.WriteLine($"\n{vehicle.Manufacturer}, {vehicle.Model} has been removed\n");
            }
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            if (Fleet.Contains(vehicle))
            {
                double rentalCost = vehicle.RentalPrice * days;
                TotalRevenue += rentalCost;
                Console.WriteLine($"\n{vehicle.Manufacturer}, {vehicle.Model} has been rented.\nFee:{vehicle.rentalCost}\n");
            }
            else
            {
                Console.WriteLine("Vehicle not available in the fleet.");
            }
        }
        public void DisplayTotalRevenue()
        {
            Console.WriteLine($"Total Revenue: ${TotalRevenue}");
        }

    }

    

}

