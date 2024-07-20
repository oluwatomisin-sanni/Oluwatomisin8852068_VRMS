using System;
using VRMS;
namespace VRMS
{
	public class Car : Vehicle
	{
        public int Seats { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public bool Convertible { get; set; }

        public Car(string model, string manufacturer, double rentalPrice, int year, int seats, string engineType, string transmission, bool convertible) : base(model, manufacturer, rentalPrice, year)
		{
            Seats = seats;
            EngineType = engineType;
            Transmission = transmission;
            Convertible = convertible;
        }

        public override void DisplayDetails()
        {

            Console.WriteLine("This Vehicle is a Car");
            base.DisplayDetails();
            Console.WriteLine($"Seats: {Seats}");
            Console.WriteLine($"Engine Type: {EngineType}");
            Console.WriteLine($"Transmission: {Transmission}");
            Console.WriteLine($"Convertible: {(Convertible ? "Yes" : "No")}");

        }
    }

}
