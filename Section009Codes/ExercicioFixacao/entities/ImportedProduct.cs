using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section009Codes.ExercicioFixacao.entities
{
    public class ImportedProduct(string name, double price, double customsFee)
    : Product(name, price)
    {
        public double CustomsFee { get; set; } = customsFee;

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice()} (Customs fee: $ {CustomsFee})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}