using Section010Codes.ExercicioProposto.entities;

Console.WriteLine("Enter the account data");
Console.Write("Number: ");
int accountNumber = int.Parse(Console.ReadLine());

Console.Write("Holder: ");
string accountHolder = Console.ReadLine();

Console.Write("Initial Balance: ");
double accountBalance = double.Parse(Console.ReadLine());

Console.Write("Withdraw limit: ");
double accountLimit = double.Parse(Console.ReadLine());

Account account = new(accountNumber, accountHolder, accountBalance, accountLimit);

Console.Write("Enter the amount for withdraw: ");
account.Withdraw(double.Parse(Console.ReadLine()));

Console.WriteLine("New balance: " + account.Balance);