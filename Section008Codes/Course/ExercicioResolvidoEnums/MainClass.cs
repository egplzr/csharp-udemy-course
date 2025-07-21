// using Section008Codes.Course.ExercicioResolvido.Entities;
// using Section008Codes.Course.ExercicioResolvido.Entities.Enums;

// System.Console.WriteLine("Enter department's name:");
// string departmentName = Console.ReadLine();

// Department department = new Department(departmentName);

// System.Console.WriteLine("Enter worker data:");
// System.Console.Write("Name: ");
// string workerName = Console.ReadLine();

// System.Console.Write("Level (Junior/MidLevel/Senior): ");
// string workerLevelTxt = Console.ReadLine();
// Enum.TryParse<WorkerLevel>(workerLevelTxt, out var workerLevel);

// System.Console.Write("Base Salary: ");
// double.TryParse(Console.ReadLine(), out var baseSalary);

// Worker worker = new Worker(workerName, workerLevel, baseSalary, department);

// System.Console.Write("How many contracts to this worker? ");
// int.TryParse(Console.ReadLine(), out var nContracts);

// for (int i = 0; i < nContracts; i++)
// {
//     System.Console.WriteLine($"Enter the #{i} contract data:");

//     System.Console.Write("Date (DD/MM/YYYY): ");
//     DateTime.TryParse(Console.ReadLine(), out var contractDate);

//     System.Console.Write("Value per hour: ");
//     double.TryParse(Console.ReadLine(), out var contractValue);

//     System.Console.Write("Duration (hours): ");
//     int.TryParse(Console.ReadLine(), out var contractHours);

//     worker.Contracts.Add(new HourContract(contractDate, contractValue, contractHours));
// }

// System.Console.WriteLine("Enter month and year to calculate income (MM/YYYY):");
// string monthYear = Console.ReadLine();

// int.TryParse(monthYear.Substring(0, 2), out var month);
// int.TryParse(monthYear.Substring(3), out var year);

// System.Console.WriteLine($"""
//     Worker's Name: {worker.Name}
//     Department: {worker.Department.Name}
//     Income for {monthYear}: {worker.Income(year, month)}
// """);