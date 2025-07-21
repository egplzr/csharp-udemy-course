using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section009Codes.ExercicioResolvido.entities
{
    public class OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
    : Employee(name, hours, valuePerHour)
    {
        public double AdditionalCharge { get; set; } = additionalCharge;

        public override double Payment()
        {
            double bonus = AdditionalCharge * 1.1;
            return ValuePerHour * Hours + bonus;
        }
    }
}