using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section009Codes.ExercicioFixacao.entities
{
    public class Product(string name, double price)
    {
        public string Name { get; set; } = name;
        public double Price { get; set; } = price;

        public virtual string PriceTag()
        {
            return $"{Name} $ {Price}";
        }
    }
}