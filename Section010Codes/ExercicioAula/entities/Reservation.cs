using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Section010Codes.ExercicioAula.entities.exceptions;

namespace Section010Codes.ExercicioAula.entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainExecption("Check-out date must be after chek-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainExecption("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainExecption("Check-out date must be after chek-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"""
            Room {RoomNumber},
            Check-in: {CheckIn.ToString("dd/MM/yyyy")},
            Check-out: {CheckOut.ToString("dd/MM/yyyy")},
            {Duration()} nights.
            """;
        }
    }
}