using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourthSectionCodes.exerciciosFixacao
{
    public class ConversorDeMoedas
    {
        public static double Moeda { get; set; }

        public static double Converter(double valor)
        {
            double valorConvertido = valor * Moeda;
            return valorConvertido += valorConvertido * 0.06;
        }
    }
}