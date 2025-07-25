using System.Globalization;
using ExercicioPropostoLINQ.entities;

string path = @"C:\Users\EEEenxxeee\Desktop\ExercicioPropostoLINQ\files\in.txt";
List<Employee> employees = [];

using StreamReader streamReader = File.OpenText(path);
while (!streamReader.EndOfStream)
{
    string[] info = streamReader.ReadLine().Split(",");
    string name = info[0];
    string email = info[1];
    double salary = double.Parse(info[2], CultureInfo.InvariantCulture);

    employees.Add(new(name, email, salary));
}

double salaryFilter = 2000;

var salaryBiggerThanFilter = employees.Where(p => p.Salary > salaryFilter).Select(p => p.Email);
double sumSalaryNameWithM = employees.Where(p => p.Name.StartsWith('M')).Sum(p => p.Salary);

System.Console.WriteLine("Email of people whose salary is more than 2000:");
foreach (string email in salaryBiggerThanFilter)
{
    System.Console.WriteLine(email);
}

System.Console.WriteLine("Sum people with M: " + sumSalaryNameWithM);