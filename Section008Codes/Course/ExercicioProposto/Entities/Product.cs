using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section008Codes.Course.ExercicioProposto.Entities
{
    public class Product(string name, double price)
    {
        public string Name { get; set; } = name;
        public double Price { get; set; } = price;

        public override string ToString()
        {
            return $"{Name}, ${Price}";
        }
    }
}