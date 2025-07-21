using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section012Codes.ExemploAula.Entities
{
    public class Invoice(double basicPayment, double tax)
    {
        public double BasicPayment { get; set; } = basicPayment;
        public double Tax { get; set; } = tax;
        public double TotalPayment { get { return BasicPayment + Tax; } }

        public override string ToString()
        {
            return $"""
            INVOICE:
            Basic Payment: {BasicPayment.ToString("F2")},
            Tax: {Tax},
            Total Payment: {TotalPayment.ToString("F2")}
            """;
        }
    }
}