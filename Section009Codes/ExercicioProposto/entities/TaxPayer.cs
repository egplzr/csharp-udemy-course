using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section009Codes.ExercicioProposto.entities
{
    public abstract class TaxPayer(string name, double anualIncome)
    {
        public string Name { get; set; } = name;
        public double AnualIncome { get; set; } = anualIncome;

        public abstract double TaxesPaid();
        public static double TotalTaxes(List<TaxPayer> taxPayers)
        {
            double total = 0;
            foreach (TaxPayer taxPayer in taxPayers)
            {
                total += taxPayer.TaxesPaid();
            }

            return total;
        }
    }
}