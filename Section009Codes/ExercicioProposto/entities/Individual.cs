using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section009Codes.ExercicioProposto.entities
{
    public class Individual(string name, double anualIncome, double healthExpenditures) : TaxPayer(name, anualIncome)
    {
        public double HealthExpenditures { get; set; } = healthExpenditures;

        public override double TaxesPaid()
        {
            if (HealthExpenditures > 0)
            {
                if (AnualIncome < 20000)
                {
                    return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
                }
                else
                {
                    return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
                }
            }
            else
            {
                if (AnualIncome < 20000)
                {
                    return AnualIncome * 0.15;
                }
                else
                {
                    return AnualIncome * 0.25;
                }
            }
        }
    }
}