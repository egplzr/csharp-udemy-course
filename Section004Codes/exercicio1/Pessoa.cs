using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourthSectionCodes.exercicio1
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(){}
        
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public static string PessoaMaisVelha(Pessoa a, Pessoa b)
        {
            if (a.Idade > b.Idade)
            {
                return a.Nome;
            }
            else
            {
                return b.Nome;
            }
        }
    }
}