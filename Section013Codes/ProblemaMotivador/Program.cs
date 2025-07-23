// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Section013Codes.ProblemaMotivador
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             PrintService<int> printService = new();

//             System.Console.Write("How many values? ");
//             int n = int.Parse(Console.ReadLine());
            
//             for (int i = 0; i < n; i++)
//             {
//                 int x = int.Parse(Console.ReadLine());
//                 printService.AddValue(x);
//             }

//             printService.Print();
//             System.Console.WriteLine("First: " + printService.First());
//         }
//     }
// }