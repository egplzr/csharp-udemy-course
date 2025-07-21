using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section009Codes.ExercicioResolvido.entities
{
    public class Employee(string name, int hours, double valuePerHour)
    {
        public string Name { get; set; } = name;
        public int Hours { get; set; } = hours;
        public double ValuePerHour { get; set; } = valuePerHour;

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }
    }
}