using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section012Codes.ExemploAula.Entities
{
    public class Vehicle(string model)
    {
        public string Model { get; set; } = model;
    }
}