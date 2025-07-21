using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section006Codes.exercicioPropostoMatriz
{
    public class MainClass
    {
        // public static void Main(string[] args)
        // {
        //     int linha = 3;
        //     int coluna = 4;

        //     int[,] matriz = new int[linha, coluna];

        //     Random random = new Random();

        //     for (int i = 0; i < linha; i++)
        //     {
        //         for (int j = 0; j < coluna; j++)
        //         {
        //             matriz[i, j] = random.Next(10);
        //         }
        //     }

        //     for (int i = 0; i < linha; i++)
        //     {
        //         for (int j = 0; j < coluna; j++)
        //         {
        //             System.Console.Write(matriz[i, j] + " | ");
        //         }
        //         System.Console.WriteLine(' ');
        //     }

        //     int numeroBolado = 3;

        //     for (int i = 0; i < linha; i++)
        //     {
        //         for (int j = 0; j < coluna; j++)
        //         {
        //             if (matriz[i, j] == numeroBolado)
        //             {
        //                 System.Console.WriteLine("Number: " + matriz[i, j]);
        //                 System.Console.WriteLine("Position: "+i+", "+j);

        //                 if (i > 0)
        //                 {
        //                     System.Console.WriteLine("Up: " + matriz[i-1, j]);                            
        //                 }

        //                 if (i < linha - 1)
        //                 {
        //                     System.Console.WriteLine("Down: " + matriz[i+1, j]);
        //                 }

        //                 if (j > 0)
        //                 {
        //                     System.Console.WriteLine("Left: " + matriz[i, j-1]);
        //                 }

        //                 if (j < coluna - 1)
        //                 {
        //                     System.Console.WriteLine("Right: " + matriz[i, j+1]);
        //                 }
        //             }
        //         }
        //     }
        // }
    }
}