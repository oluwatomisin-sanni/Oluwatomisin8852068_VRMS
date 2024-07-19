using System;
namespace VRMS
{
    public abstract class Vehicle
    {

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public double RentalPrice { get; set; }

        public Vehicle(string model, string manufacturer, double rentalPrice, int year)
        {

            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;

        }
        public virtual void DisplayDetails()
        {

            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Price: {RentalPrice}");
        }
    }

}
