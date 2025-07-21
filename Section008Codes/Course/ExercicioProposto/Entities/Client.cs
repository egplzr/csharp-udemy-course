using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section008Codes.Course.ExercicioProposto.Entities
{
    public class Client(string name, string email, DateTime birthDate)
    {
        public string Name { get; set; } = name;
        public string Email { get; set; } = email;
        public DateTime BirthDate { get; set; } = birthDate;

        public override string ToString()
        {
            return $"{Name} ({BirthDate}) - {Email}";
        }
    }
}