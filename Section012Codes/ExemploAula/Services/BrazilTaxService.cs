using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section012Codes.ExemploAula.Services
{
    public class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}