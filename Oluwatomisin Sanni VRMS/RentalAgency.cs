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
    }

    public void AddVehicle(Vehicle vehicle)
    {
       
        if (vehicle != null)
        {
            vehicles.Add(vehicle);
            Console.WriteLine($"\n{vehicle.Manufacturer}, {vehicle.Model} has been added\n");
        }
    }
}

