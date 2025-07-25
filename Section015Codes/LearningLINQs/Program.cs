using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Section015Codes.LearningLINQs.DemoLINQs;

namespace Section015Codes.LearningLINQs
{
    public class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            System.Console.WriteLine(message);
            foreach (T item in collection)
            {
                System.Console.WriteLine(item);
            }
        }
        public static void Main(string[] args)
        {
            Category c1 = new() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new() { Id = 1, Name = "Computers", Tier = 1 };
            Category c3 = new() { Id = 1, Name = "Electronics", Tier = 1 };

            List<Product> products = [
                new() {Id = 1, Name = "Computer", Price = 1100, Category = c2},
                new() {Id = 2, Name = "Hammer", Price = 90, Category = c1},
                new() {Id = 3, Name = "TV", Price = 1700, Category = c3},
                new() {Id = 4, Name = "Notebook", Price = 1300, Category = c2},
                new() {Id = 5, Name = "Saw", Price = 80, Category = c1},
                new() {Id = 6, Name = "Tablet", Price = 700, Category = c2},
                new() {Id = 7, Name = "Camera", Price = 700, Category = c3},
                new() {Id = 8, Name = "Printer", Price = 350, Category = c3},
                new() {Id = 9, Name = "MacBook", Price = 1800, Category = c2},
                new() {Id = 10, Name = "Sound Bar", Price = 700, Category = c3},
                new() {Id = 11, Name = "Level", Price = 70, Category = c1}
            ];

            // var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900
                select p;
            Print("TIER 1 AND PRICE < 900: ", r1);

            // var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p;
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            // var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            Print("NAMES STARTED WITCH 'C' AND ANONYMOUS OBJECTS", r3);

            // var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME: ", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME THEN SKIP 2 AND TAKE 4: ", r5);

            var r6 = products.First();
            System.Console.WriteLine("First test1: " + r6);
        }
    }
}