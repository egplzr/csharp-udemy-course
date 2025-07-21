using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourthSectionCodes.exercicio2
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(){}

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
        
        public static double SalarioMedio(Funcionario a, Funcionario b)
        {
            return (a.Salario + b.Salario) / 2;
        }
    }
}