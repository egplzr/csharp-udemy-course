using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section006Codes.exercicioPropostoVetores
{
    public class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}