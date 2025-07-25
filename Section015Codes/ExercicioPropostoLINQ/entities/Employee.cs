using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPropostoLINQ.entities
{
    public class Employee(string name, string email, double salary)
    {
        public string Name { get; set; } = name;
        public string Email { get; set; } = email;
        public double Salary { get; set; } = salary;
    }
}