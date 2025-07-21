using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Section009Codes.ExercicioResolvidoAbstracao.entities.enums;

namespace Section009Codes.ExercicioResolvidoAbstracao.entities
{
    public class Rectangle(Color color, double width, double height) : Shape(color)
    {
        public double Width { get; set; } = width;
        public double Height { get; set; } = height;

        public override double Area()
        {
            return Width * Height;
        }
    }
}