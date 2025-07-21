// using System.Globalization;
// using Section010Codes.ExercicioAula.entities;
// using Section010Codes.ExercicioAula.entities.exceptions;

// try
// {
//     Console.Write("Room number: ");
//     int roomNumber = int.Parse(Console.ReadLine());

//     Console.Write("Check-in date (dd/MM/yyyy): ");
//     DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

//     Console.Write("Check-out date (dd/MM/yyyy): ");
//     DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

//     Reservation reservation = new(roomNumber, checkIn, checkOut);

//     Console.WriteLine("Reservation: " + reservation);

//     Console.WriteLine();

//     Console.WriteLine("Enter data to update the reservation:");
//     Console.Write("Check-in date (dd/MM/yyyy): ");
//     checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

//     Console.Write("Check-out date (dd/MM/yyyy): ");
//     checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

//     reservation.UpdateDates(checkIn, checkOut);

//     Console.WriteLine("Reservation: " + reservation);
// }
// catch (DomainExecption e)
// {
//     Console.WriteLine("Error in reservation: " + e);
// }
// catch (FormatException e)
// {
//     Console.WriteLine("Format error: " + e);
// }
// catch (Exception e)
// {
//     Console.WriteLine("Unexpected error: " + e);
// }