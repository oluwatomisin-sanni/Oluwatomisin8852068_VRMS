using System;
namespace VRMS
{
    public class Truck : Vehicle
    {
        public int Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }
        
        public Truck(string model, string manufacturer, double rentalPrice, int year, int capacity, string truckType, bool fourWheelDrive) : base(model, manufacturer, rentalPrice, year)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        public override void DisplayDetails()
        {

            Console.WriteLine("This Vehicle is a Car");
            base.DisplayDetails();
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Truck Type: {TruckType}");
            Console.WriteLine($"Four-Wheel Drive ?: {(FourWheelDrive ? "Yes" : "No")}");

        }
    }

}
