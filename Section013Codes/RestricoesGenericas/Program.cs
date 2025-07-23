// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Section013Codes.RestricoesGenericas
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             List<Product> products = [];

//             System.Console.WriteLine("Enter N:");
//             int n = int.Parse(Console.ReadLine());

//             for (int i = 0; i < n; i++)
//             {
//                 System.Console.Write("Nome do produto: ");
//                 string prodName = Console.ReadLine();

//                 System.Console.Write("Preço do produto: ");
//                 double prodPrice = double.Parse(Console.ReadLine());

//                 products.Add(new(prodName, prodPrice));
//             }

//             CalculationService calculationService = new();

//             Product biggestPrice = calculationService.Max(products);

//             System.Console.WriteLine("Most expensive:\n" + biggestPrice);
//         }
//     }
// }