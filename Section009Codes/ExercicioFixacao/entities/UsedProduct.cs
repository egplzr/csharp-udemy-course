using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section009Codes.ExercicioFixacao.entities
{
    public class UsedProduct(string name, double price, DateTime manufactureDate)
    : Product(name, price)
    {
        public DateTime ManufactureDate { get; set; } = manufactureDate;
        
        public override string PriceTag()
        {
            return $"{Name} $ {Price} (Manufacture date: {ManufactureDate.ToShortDateString()})";
        }
    }
}