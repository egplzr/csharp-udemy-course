using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section009Codes.ExercicioProposto.entities
{
    public class Company(string name, double anualIncome, int numberEmployees)
    : TaxPayer(name, anualIncome)
    {
        public int NumberEmployees { get; set; } = numberEmployees;

        public override double TaxesPaid()
        {
            if (NumberEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}