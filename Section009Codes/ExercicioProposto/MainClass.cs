// using Section009Codes.ExercicioProposto.entities;

// Console.Write("Enter the number of tax payers: ");
// int nTaxPayers = int.Parse(Console.ReadLine());

// List<TaxPayer> taxPayers = [];

// for (int i = 1; i <= nTaxPayers; i++)
// {
//     Console.WriteLine($"Tax Payer #{i} data: ");
//     Console.Write("Individual or company? [i/c] ");
//     string PayerType = Console.ReadLine();

//     Console.Write("Name: ");
//     string PayerName = Console.ReadLine();

//     Console.Write("Anual Income: ");
//     double PayerIncome = double.Parse(Console.ReadLine());

//     if (PayerType.Equals("i"))
//     {
//         Console.Write("Health expenditures: ");
//         double PayerHealth = double.Parse(Console.ReadLine());

//         taxPayers.Add(new Individual(PayerName, PayerIncome, PayerHealth));
//     }
//     else if (PayerType.Equals("c"))
//     {
//         Console.Write("Number of employees: ");
//         int PayerEmployees = int.Parse(Console.ReadLine());

//         taxPayers.Add(new Company(PayerName, PayerIncome, PayerEmployees));
//     }
//     else
//     {
//         Console.Write("Argumento inválido.");
//     }
// }

// Console.WriteLine("TAXES PAID");
// foreach (TaxPayer taxPayer in taxPayers)
// {
//     Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.TaxesPaid()}");
// }

// Console.Write($"TOTAL TAXES: $ {TaxPayer.TotalTaxes(taxPayers)}");