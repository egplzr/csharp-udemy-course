using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Section009Codes.ExercicioResolvidoAbstracao.entities.enums;

namespace Section009Codes.ExercicioResolvidoAbstracao.entities
{
    public abstract class Shape(Color color)
    {
        public Color Color { get; set; } = color;

        public abstract double Area();
    }
}