using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourthSectionCodes.exerciciosFixacao
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            ConversorDeMoedas.Moeda = 3.1;

            System.Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoedas.Converter(200));
        }
    }
}