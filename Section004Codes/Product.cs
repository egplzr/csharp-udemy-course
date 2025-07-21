using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourthSectionCodes
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public double StorageTotalValue()
        {
            return Price * Amount;
        }

        public void AddProductAmount(int q)
        {
            Amount += q;
        }

        public void RemoveProductAmount(int q)
        {
            Amount -= q;
        }

        override public string ToString()
        {
            return $"{Name}, ${Price.ToString("F2")}, {Amount} unidades, Total: ${StorageTotalValue().ToString("F2")}";
        }
    }
}