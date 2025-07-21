// using Section009Codes.ExemploAula.Entities;
// using Section009Codes.ExercicioResolvido.entities;

// Console.Write("Enter the number of employees: ");
// bool number = int.TryParse(Console.ReadLine(), out var nEmployees);

// if (number)
// {
//     List<Employee> employees = [];
//     int i = 1;

//     do
//     {
//         Console.WriteLine($"Employee {i}# data:");
//         Console.Write("Outsourced? [y/n]");
//         string outsourcedConfirmation = Console.ReadLine();
        
//         Console.Write("Name: ");
//         string employeeName = Console.ReadLine();

//         Console.Write("Hours: ");
//         int employeeHours = int.Parse(Console.ReadLine());

//         Console.Write("Value per hour: ");
//         double employeeValuePerHour = double.Parse(Console.ReadLine());

//         if (outsourcedConfirmation.Equals("y"))
//         {
//             Console.Write("Additional charge: ");
//             double additionalCharge = double.Parse(Console.ReadLine());

//             employees.Add(new OutsourcedEmployee(employeeName, employeeHours, employeeValuePerHour, additionalCharge));
//         }
//         else
//         {
//             employees.Add(new(employeeName, employeeHours, employeeValuePerHour));
//         }

//         i++;
//     } while (i <= nEmployees);

//     Console.WriteLine("PAYMENTS:");
//     foreach (Employee employee in employees)
//     {
//         Console.WriteLine(employee.Name + " - $ " + employee.Payment());
//     }
// }
// else
// {
//     Console.Write("Argumento inválido, digite um número válido.");
// }