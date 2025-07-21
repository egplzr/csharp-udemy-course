using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section006Codes.exercicioPropostoListas
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary}";
        }

        public void SalaryIncrease(double percentage)
        {
            double increase = Salary * (percentage / 100);
            Salary += increase;
        }
    }
}