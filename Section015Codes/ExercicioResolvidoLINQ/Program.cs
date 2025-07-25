using System.Globalization;
using ExercicioResolvidoLINQ;

string path = @"C:\Users\EEEenxxeee\Desktop\ExercicioResolvidoLINQ\in.txt";

List<Product> products = [];

using StreamReader streamReader = File.OpenText(path);
while (!streamReader.EndOfStream)
{
    string[] fields = streamReader.ReadLine().Split(',');
    string name = fields[0];
    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

    products.Add(new Product(name, price));
}

double average = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
var productsBelowAverage = products.Where(p => p.Price < average).Select(p => p.Name).OrderDescending();

System.Console.WriteLine("Average price: " + average.ToString("F2", CultureInfo.InvariantCulture));
foreach (var product in productsBelowAverage)
{
    System.Console.WriteLine(product);
}
