using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section012Codes.ExemploAula.Entities
{
    public class CarRental(DateTime start, DateTime finish, Vehicle vehicle)
    {
        public DateTime Start { get; set; } = start;
        public DateTime Finish { get; set; } = finish;
        public Vehicle Vehicle { get; set; } = vehicle;
        public Invoice Invoice { get; set; }
    }
}