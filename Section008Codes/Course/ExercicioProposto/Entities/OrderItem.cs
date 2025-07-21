using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section008Codes.Course.ExercicioProposto.Entities
{
    public class OrderItem(int quantity, Product product)
    {
        public int Quantity { get; set; } = quantity;
        public Product Product { get; set; } = product;
        public double Price { get; set; } = product.Price;

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Product}, Quantity: {Quantity}, Subtotal: {SubTotal()}";
        }
    }
}