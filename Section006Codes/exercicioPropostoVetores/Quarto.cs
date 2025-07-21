using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Section006Codes.exercicioPropostoVetores
{
    public class Quarto
    {
        public int NumeroDoQuarto { get; set; }
        public Estudante Estudante { get; set; }

        public Quarto(int numeroDoQuarto)
        {
            NumeroDoQuarto = numeroDoQuarto;
            Estudante = null;
        }

        public override string ToString()
        {
            if (Estudante != null)
            {
                return $"""
                ------------------------------------------------
                Número do Quarto: {NumeroDoQuarto},
                Estudante ocupando o Quarto: {Estudante.Nome},
                ------------------------------------------------
                """;
            }
            return "";
        }
    }
}