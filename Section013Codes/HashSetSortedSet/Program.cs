// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Section013Codes.HashSetSortedSet
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             SortedSet<int> a = [0, 2, 4, 5, 6, 8, 10];
//             SortedSet<int> b = [5, 6, 7, 8, 9, 10];

//             //Union
//             SortedSet<int> c = new(a);
//             c.UnionWith(b);
//             PrintCollection(c);

//             //Intersection
//             SortedSet<int> d = new(a);
//             d.IntersectWith(b);
//             PrintCollection(d);

//             //Difference
//             SortedSet<int> e = new(a);
//             e.ExceptWith(b);
//             PrintCollection(e);
//         }

//         static void PrintCollection<T>(IEnumerable<T> collection)
//         {
//             foreach (T item in collection)
//             {
//                 Console.Write(item + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }