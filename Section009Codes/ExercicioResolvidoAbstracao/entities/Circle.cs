using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Section009Codes.ExercicioResolvidoAbstracao.entities.enums;

namespace Section009Codes.ExercicioResolvidoAbstracao.entities
{
    public class Circle(Color color, double radius) : Shape(color)
    {
        public double Radius { get; set; } = radius;

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}