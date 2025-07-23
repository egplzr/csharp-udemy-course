using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Section013Codes.RestricoesGenericas
{
    public class Product(string name, double price) : IComparable
    {
        public string Name { get; set; } = name;
        public double Price { get; set; } = price;

        public int CompareTo(object obj)
        {
            if (obj is not Product)
            {
                throw new ArgumentException("Comparing error: argument is not a product");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}