using System;
using System.Globalization;
using Section012Codes.ExemploAula.Entities;
using Section012Codes.ExemploAula.Services;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter rental data");

        Console.Write("Car model: ");
        string carModel = Console.ReadLine();

        Console.Write("Pickup (dd/MM/yyyy hh:ss): ");
        string pickupInput = Console.ReadLine();
        DateTime pickupDate = DateTime.ParseExact(pickupInput, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Return (dd/MM/yyyy hh:ss): ");
        string returnInput = Console.ReadLine();
        DateTime returnDate = DateTime.ParseExact(returnInput, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Enter price per hour: ");
        double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Enter price per day: ");
        double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        CarRental carRental = new(pickupDate, returnDate, new Vehicle(carModel));

        RentalService rentalService = new(pricePerHour, pricePerDay, new BrazilTaxService());
        rentalService.ProcessInvoice(carRental);

        Console.WriteLine(carRental.Invoice);
    }
}