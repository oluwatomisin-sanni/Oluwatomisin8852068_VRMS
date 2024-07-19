using System;
namespace VRMS
{
    public class Motorcycle : Vehicle
    {
        public int EnigineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }

        public Motorcycle(string model, string manufacturer, double rentalPrice, int year, int engineCapacity, string fuelType, bool hasFairing) : base(model, manufacturer, rentalPrice, year)
        {
            EngineCapacity = engineCapacity;
            FuelType = fuelType;
            HasFairing = hasFairing;
        }

        public override void DisplayDetails()
        {

            Console.WriteLine("This Vehicle is a Motorcycle");
            base.DisplayDetails();
            Console.WriteLine($"Capacity: {EngineCapacity}");
            Console.WriteLine($"Truck Type: {FuelType}");
            Console.WriteLine($"Four-Wheel Drive ?: {(HasFairing ? "Yes" : "No")}");

        }
    }

}
