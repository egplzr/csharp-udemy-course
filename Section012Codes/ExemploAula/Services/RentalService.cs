using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Section012Codes.ExemploAula.Entities;

namespace Section012Codes.ExemploAula.Services
{
    public class RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
    {
        public double PricePerHour { get; private set; } = pricePerHour;
        public double PricePerDay { get; private set; } = pricePerDay;

        private ITaxService _taxService = taxService;

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0;

            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}